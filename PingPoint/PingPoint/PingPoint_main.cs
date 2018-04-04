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
        point p;
        
        //Rest variables
        bool logged1 = true; //player 1 logged
        bool logged2 = true; //player 2 logged
        bool choosed = true; //match mode is choosed
        public static decimal set_max = 7;
        public static decimal point_max = 12; //points in set
        int point1; //value of player 1 points
        int point2; //value of player 2 points
        int sets_player1 = 0; //number of player1 won sets 
        int sets_player2 = 0; //number of player2 won sets
        public static bool rematch = false;
        public static bool change_set = false;
        public static string my_login;
        public static string my_password;

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
            if (point1 < point_max)
            {
                label_points_up1.Visible = true;
                label_points_up1.Text = (point1 + 1).ToString();
            }
            else
            {
                label_points_up1.Visible = false;
            }
            if (point2 < point_max)
            {
                label_points_up2.Visible = true;
                label_points_up2.Text = (point2 + 1).ToString();
            }
            else
            {
                label_points_up2.Visible = false;
            }
        }

        public void sets_update(int win)
        {
            int set = sets_player1 + sets_player2;
            //insert danych do tabeli punkty 
            if (win == point1)
            {
                switch (sets_player1)//set - w przypadku ukośnego zaznaczania punktów (nie blokowego)
                {
                    case 1:
                        pictureBox_point1_1.Visible = true;
                        break;
                    case 2:
                        pictureBox_point1_2.Visible = true;
                        break;
                    case 3:
                        pictureBox_point1_3.Visible = true;
                        break;
                    case 4:
                        pictureBox_point1_4.Visible = true;
                        break;
                    case 5:
                        pictureBox_point1_5.Visible = true;
                        break;
                    case 6:
                        pictureBox_point1_6.Visible = true;
                        break;
                    case 7:
                        pictureBox_point1_7.Visible = true;
                        break;
                }
            }
            else
            {
                switch (sets_player2)//set - w przypadku ukośnego zaznaczania punktów (nie blokowego)
                {
                    case 1:
                        pictureBox_point2_1.Visible = true;
                        break;
                    case 2:
                        pictureBox_point2_2.Visible = true;
                        break;
                    case 3:
                        pictureBox_point2_3.Visible = true;
                        break;
                    case 4:
                        pictureBox_point2_4.Visible = true;
                        break;
                    case 5:
                        pictureBox_point2_5.Visible = true;
                        break;
                    case 6:
                        pictureBox_point2_6.Visible = true;
                        break;
                    case 7:
                        pictureBox_point2_7.Visible = true;
                        break;
                }
            }
            if(sets_player1 == set_max)//set - w przypadku ukośnego zaznaczania punktów (nie blokowego)
            {
                endgame(point1);
            }
            else if(sets_player2 == set_max)//set - w przypadku ukośnego zaznaczania punktów (nie blokowego)
            {
                endgame(point2);
            }
            else
            {
                label_set.Text = (set + 1).ToString();
                points.Clear();
                points_update();
            }
            
        }
        private void cleanup(bool all)
        {
            //cleanup sets value
            pictureBox_point1_1.Visible = false;
            pictureBox_point1_2.Visible = false;
            pictureBox_point1_3.Visible = false;
            pictureBox_point1_4.Visible = false;
            pictureBox_point1_5.Visible = false;
            pictureBox_point1_6.Visible = false;
            pictureBox_point1_7.Visible = false;
            pictureBox_point2_1.Visible = false;
            pictureBox_point2_2.Visible = false;
            pictureBox_point2_3.Visible = false;
            pictureBox_point2_4.Visible = false;
            pictureBox_point2_5.Visible = false;
            pictureBox_point2_6.Visible = false;
            pictureBox_point2_7.Visible = false;
            sets_player1 = 0;
            sets_player2 = 0;
            label_set.Text = "1";
            //cleanup visible elements
            panel_sets1.Visible = false;
            panel_sets2.Visible = false;
            label_static_set.Visible = false;
            label_set.Visible = false;
            label_colon.Visible = false;
            label_points1.Visible = false;
            label_points2.Visible = false;
            label_points_up1.Visible = false;
            label_points_up2.Visible = false;
            label_player1.Visible = false;
            label_player2.Visible = false;
            //cleanup enabled elements
            button_login1.Enabled = true;
            button_login2.Enabled = true;
            listBox_rodzaj.Enabled = true;
            button_start.Enabled = true;
            if(all == true)
            {
                //cleanup variables
                logged1 = false;
                logged2 = false;
                listBox_rodzaj.ClearSelected();
                label_player1.Text = "Zawodnik1";
                label_player2.Text = "Zawodnik2";
                choosed = false;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if(logged1 && logged2 && choosed)
            {
                cleanup(false);
                //initialize visible
                panel_sets1.Visible = true;
                panel_sets2.Visible = true;
                label_static_set.Visible = true;
                label_set.Visible = true;
                label_colon.Visible = true;
                label_points1.Visible = true;
                label_points2.Visible = true;
                label_points_up1.Visible = true;
                label_points_up2.Visible = true;
                //initialize list of players points, begin with 0
                points.Clear();
                p = new point(1, 0);
                points.Add(p);
                p = new point(2, 0);
                points.Add(p);
                points_update();
                button_login1.Enabled = false;
                button_login2.Enabled = false;
                listBox_rodzaj.Enabled = false;
                button_start.Enabled = false;
                button_start.Text = "Start";
            }
            else if(logged1 && choosed) MessageBox.Show("Player 2 is not logged in!");
            else if(logged2 && choosed) MessageBox.Show("Player 1 is not logged in!");
            else MessageBox.Show("Set all match settings and log in!");
        }
        private void button_login1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();

            string sql = "SELECT haslo FROM gracze WHERE login='" + my_login + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows == true)
            {
                if (label_player2.Text != my_login)
                {
                    if (rdr[0].ToString() == my_password)
                    {
                        label_player1.Text = my_login;
                        label_player1.Visible = true;
                        logged1 = true;
                    }
                    else MessageBox.Show("Bledne haslo!");
                }
                else MessageBox.Show("Osoba juz zalogowana!");
            }
            else MessageBox.Show("Bledny login!");
            rdr.Close();
        }
        private void button_login2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();

            string sql = "SELECT haslo FROM gracze WHERE login='" + my_login + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows == true)
            {
                if(label_player1.Text != my_login)
                {
                    if (rdr[0].ToString() == my_password)
                    {
                        label_player2.Text = my_login;
                        label_player2.Visible = true;
                        logged2 = true;
                    }
                    else MessageBox.Show("Bledne haslo!");
                }
                else MessageBox.Show("Osoba juz zalogowana!");
            }
            else MessageBox.Show("Bledny login!");
            rdr.Close();
        }
        private void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_auto.Checked == true)
            {
                //otrzymuj sygnały z programu Michała i dodawaj pkt
            }
            else
            {
            }
        }
        private void listBox_rodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listBox_rodzaj.SelectedItem != null)
            {
                if (this.listBox_rodzaj.SelectedItem.ToString() == "Turniej")
                {
                    //tutaj to samo co do meczu towarzyskiego
                }
                if (this.listBox_rodzaj.SelectedItem.ToString() == "Mecz towarzyski")
                {
                    FriendlyMatchSettings settings = new FriendlyMatchSettings();
                    settings.ShowDialog();
                }
                choosed = true;
            }
        }
        private void label_points_up1_Click(object sender, EventArgs e)
        {
            point k = new point(1, point1 + 1);
            points.Add(k);
            points_update();
            if (point1 == point_max)
            {
                Wait change = new Wait(label_player1.Text, this);
                change.ShowDialog();
                if (change_set == false)
                {
                    sets_player1++;
                    sets_update(point1);
                }
                else
                {
                    points.Remove(k);
                    points_update();
                }
            }
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
            if (point2 == point_max)
            {
                //funkcja czekająca na zmiany 5 sekund np
                Wait change = new Wait(label_player2.Text, this);
                change.ShowDialog();
                if (change_set == false)
                {
                    sets_player2++;
                    sets_update(point2);
                }
                else
                {
                    points.Remove(k);
                    points_update();
                }
            }
        }

        private void label_points_down2_Click(object sender, EventArgs e)
        {
            point k = new point(2, point2);
            points.Remove(k);
            points_update();
        }
        public void endgame(int win)
        {
            string winner;
            bool turniej = false;
            if (win == point1)
            {
                winner = label_player1.Text;
            }
            else
            {
                winner = label_player2.Text;
            }
            if (listBox_rodzaj.SelectedItem.ToString() == "Turniej")
            {
                turniej = true;
            }
            else
            {
                turniej = false;
            }
            Endgame end = new Endgame(winner, turniej);
            label_points_down1.Visible = false;
            label_points_down2.Visible = false;
            label_points_up1.Visible = false;
            label_points_up2.Visible = false;
            end.ShowDialog();
            if (rematch == false)
            {
                //funkcja czyszcząca
                cleanup(true);
            }
            else
            {
                button_start.Enabled = true;
                button_start.Text = "Rewanż";
            }
        }
    }
}
