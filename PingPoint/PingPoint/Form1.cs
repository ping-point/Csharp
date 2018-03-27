using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;

public struct point
{
    public int player;
    public int value;
    public point(int p1, int p2)
    {
        player = p1;
        value = p2;
    }
};

namespace PingPoint
{
    public partial class PingPoint_main : Form
    {
        //Connection strings - via putty or from faculty
        protected static string ConnString = "SERVER=127.0.0.1; Port=5432; DATABASE=pz2017_10; UID=pz2017_10; PASSWORD=vV8bdtj2fGMhaG2u;";//putty
        //protected static string ConnString = "SERVER=labsql; Port=3306; DATABASE=pz2017_10; UID=pz2017_10; PASSWORD=vV8bdtj2fGMhaG2u;";//wydzial
        protected MySqlConnection conn = new MySqlConnection(ConnString);

        //Players points
        List<point> points = new List<point>();
        point p = new point(1, 0);
        
        //Rest variables
        bool logged1 = false; //player 1 logged
        bool logged2 = false; //player 2 logged
        bool choosed = false; //match mode is choosed
        bool auto_points = false; //auto points is up
        int max = 12; //points in set
        int point1; //value of player 1 points
        int point2; //value of player 2 points

        public PingPoint_main()
        {
            InitializeComponent();
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                this.label_baza.Text = "ONLINE";
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    case 1042:
                        MessageBox.Show("Can't resolve the client IP address into a hostname");
                        break;
                    default:
                        MessageBox.Show("Unknown error");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void PingPoint_main_Load(object sender, EventArgs e)
        {
            OpenConnection();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            CloseConnection();
            Application.Exit();
        }
        //searching for latest points
        private int last_point(int player)
        {
            for (int i = 1; i < points.Count + 1; i++)
            {
                point k;
                k = points[points.Count - i];
                if (k.player == player)
                {
                    return k.value;
                }
            }
            return 0;
        }
        public void points_update()
        {
            //initialize score labels
            point1 = last_point(1);
            point2 = last_point(2);
            label_points1.Text = point1.ToString();
            label_points2.Text = point2.ToString();
            //down
            if (point1 > 0)
            {
                label_points_down1.Visible = true;
                label_points_down1.Text = (point1 - 1).ToString();
            }
            else
            {
                label_points_down1.Visible = false;
            }
            if (point2 > 0)
            {
                label_points_down2.Visible = true;
                label_points_down2.Text = (point2 - 1).ToString();
            }
            else
            {
                label_points_down2.Visible = false;
            }
            //up
            if (point1 < max)
            {
                label_points_up1.Visible = true;
                label_points_up1.Text = (point1 + 1).ToString();
            }
            else
            {
                label_points_up1.Visible = false;
            }
            if (point2 < max)
            {
                label_points_up2.Visible = true;
                label_points_up2.Text = (point2 + 1).ToString();
            }
            else
            {
                label_points_up2.Visible = false;
            }
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            if(logged1 && logged2 && choosed)
            {
                //initialize visible
                label_colon.Visible = true;
                label_points1.Visible = true;
                label_points2.Visible = true;
                label_points_up1.Visible = true;
                label_points_up2.Visible = true;
                //initialize list of players points, begin with 0 
                points.Add(p);
                p = new point(2, 0);
                points.Add(p);
                points_update();
                button_login1.Enabled = false;
                button_login2.Enabled = false;
                listBox_rodzaj.Enabled = false;
            }
            else if(logged1 && choosed)
            {
                MessageBox.Show("Player 2 is not logged in!");
            }
            else if(logged2 && choosed)
            {
                MessageBox.Show("Player 1 is not logged in!");
            }
            else
            {
                MessageBox.Show("Set all match settings and log in!");
            }
        }
        private void button_login1_Click(object sender, EventArgs e)
        {
            //logowanie do bazy danych
            string name = "Player1";//pobierz nazwę gracza z bazy danych
            label_player1.Text = name;
            label_player1.Visible = true;
            logged1 = true;
        }

        private void button_login2_Click(object sender, EventArgs e)
        {
            //logowanie do bazy danych
            string name = "Player2";//pobierz nazwę gracza z bazy danych
            label_player2.Text = name;
            label_player2.Visible = true;
            logged2 = true;
        }
        private void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_auto.Checked == true)
            {
                auto_points = true;
                //otrzymuj sygnały z programu Michała i dodawaj pkt
            }
            else
            {
                auto_points = false;
            }
        }

        private void listBox_rodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox_rodzaj.SelectedItem.ToString() == "Turniej")
            {
                label_static_kod.Visible = true;
                textBox_kod.Visible = true;
            }
            if (this.listBox_rodzaj.SelectedItem.ToString() == "Mecz towarzyski")
            {
                label_static_kod.Visible = false;
                textBox_kod.Visible = false;
            }
            choosed = true;
        }

        private void label_points_up1_Click(object sender, EventArgs e)
        {
            point k = new point(1, point1 + 1);
            points.Add(k);
            points_update();
        }

        private void label_points_down1_Click(object sender, EventArgs e)
        {
            point k = new point(1, point1);
            points.Remove(k);
            points_update();
        }

        private void label_points_up2_Click(object sender, EventArgs e)
        {
            point k = new point(2, point2 + 1);
            points.Add(k);
            points_update();
        }

        private void label_points_down2_Click(object sender, EventArgs e)
        {
            point k = new point(2, point2);
            points.Remove(k);
            points_update();
        }


    }
}
