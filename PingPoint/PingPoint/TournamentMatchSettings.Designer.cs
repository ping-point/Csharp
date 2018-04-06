namespace PingPoint
{
    partial class TournamentMatchSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_choose = new System.Windows.Forms.Button();
            this.dataGridView_tournament = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tournament)).BeginInit();
            this.SuspendLayout();
            // 
            // button_choose
            // 
            this.button_choose.Location = new System.Drawing.Point(13, 185);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(441, 65);
            this.button_choose.TabIndex = 1;
            this.button_choose.Text = "Wybierz turniej";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_tournament
            // 
            this.dataGridView_tournament.AllowUserToAddRows = false;
            this.dataGridView_tournament.AllowUserToDeleteRows = false;
            this.dataGridView_tournament.AllowUserToResizeColumns = false;
            this.dataGridView_tournament.AllowUserToResizeRows = false;
            this.dataGridView_tournament.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_tournament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tournament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Points,
            this.Sets,
            this.Overview});
            this.dataGridView_tournament.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_tournament.MultiSelect = false;
            this.dataGridView_tournament.Name = "dataGridView_tournament";
            this.dataGridView_tournament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tournament.Size = new System.Drawing.Size(442, 167);
            this.dataGridView_tournament.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.FillWeight = 50F;
            this.Type.Frozen = true;
            this.Type.HeaderText = "Typ";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.Frozen = true;
            this.Points.HeaderText = "Punkty";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // Sets
            // 
            this.Sets.Frozen = true;
            this.Sets.HeaderText = "Sety";
            this.Sets.Name = "Sets";
            this.Sets.ReadOnly = true;
            // 
            // Overview
            // 
            this.Overview.Frozen = true;
            this.Overview.HeaderText = "Opis";
            this.Overview.Name = "Overview";
            this.Overview.ReadOnly = true;
            // 
            // TournamentMatchSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 254);
            this.Controls.Add(this.dataGridView_tournament);
            this.Controls.Add(this.button_choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TournamentMatchSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tournament Match Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.DataGridView dataGridView_tournament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overview;
    }
}