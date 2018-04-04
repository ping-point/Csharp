using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPoint
{
    public partial class Wait : Form
    {
        string winner;
        decimal seconds = 5;
        public Wait(string win, PingPoint_main o)
        {
            InitializeComponent();
            int X = o.Location.X + 150;
            int Y = o.Location.Y + 30;
            Point point = new Point(X,Y);
            this.Location = point;
            winner = win;
            label_change.Text = "Set wygrał " + winner;
            label_time.Text = seconds.ToString();
        }

        private void Wait_Load(object sender, EventArgs e)
        {
            Timer clock = new Timer();
            clock.Interval = 1000;
            Timer exit = new Timer();
            exit.Interval = 5000;
            exit.Start();
            clock.Start();
            exit.Tick += new EventHandler(exit_Tick);
            clock.Tick += new EventHandler(clock_Tick);
        }
        private void exit_Tick(object sender, EventArgs e)
        {
            PingPoint_main.change_set = false;
            this.Close();
        }
        private void clock_Tick(object sender, EventArgs e)
        {
            seconds--;
            label_time.Text = seconds.ToString();
        }

        private void label_change_Click(object sender, EventArgs e)
        {
            PingPoint_main.change_set = true;
            this.Close();
        }

        private void label_change_MouseEnter(object sender, EventArgs e)
        {
            label_change.Text = "Kliknij by poprawić wynik setu";
        }

        private void label_change_MouseLeave(object sender, EventArgs e)
        {
            label_change.Text = "Set wygrał " + winner;
        }
    }
}
