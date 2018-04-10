﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PingPoint
{
    public partial class TournamentMatchSettings : Form
    {
        int points = 0;
        int sets = 0;

        public TournamentMatchSettings(List<string> tablica, MySqlConnection conn)
        {
            InitializeComponent();
            string prev_id = "";
            for (int i = 0; i < tablica.Count; i++)
            {
                string tournamet_info = "SELECT * FROM turnieje WHERE turnieje_id = '" + tablica[i] + "'";
                MySqlCommand cmd_info = new MySqlCommand(tournamet_info, conn);
                MySqlDataReader rdr2 = cmd_info.ExecuteReader();
                DataTable data_tournament_info = new DataTable();
                data_tournament_info.Load(rdr2);
                DataRow row = data_tournament_info.Rows[0];
                string id = row["turnieje_id"].ToString();
                string type = row["typ"].ToString();
                string pkt = row["do_ilu_punkty"].ToString();
                string set = row["do_ilu_sety"].ToString();
                string overview = row["opis"].ToString();
                if(id != prev_id)
                {
                    dataGridView_tournament.Rows.Add(type, pkt, set, overview);
                    prev_id = id;
                }

                Int32.TryParse(pkt, out points);
                Int32.TryParse(set, out sets);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PingPoint_main.point_max = points;
            PingPoint_main.set_max = sets;
            this.Close();
        }
    }
}