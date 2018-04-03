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
    public partial class Endgame : Form
    {
        string winner;
        public Endgame(string win)
        {
            InitializeComponent();
            winner = win;
            label_winner.Text = winner;

        }

        private void button_show_score_Click(object sender, EventArgs e)
        {
            PingPoint_main.rematch = true;
            this.Close();
        }

        private void button_endgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
