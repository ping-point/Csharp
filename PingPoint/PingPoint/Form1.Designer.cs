namespace PingPoint
{
    partial class PingPoint_main
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_login1 = new System.Windows.Forms.Button();
            this.button_login2 = new System.Windows.Forms.Button();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.label_static_baza = new System.Windows.Forms.Label();
            this.label_baza = new System.Windows.Forms.Label();
            this.label_static_tryb = new System.Windows.Forms.Label();
            this.listBox_rodzaj = new System.Windows.Forms.ListBox();
            this.textBox_kod = new System.Windows.Forms.TextBox();
            this.label_static_kod = new System.Windows.Forms.Label();
            this.label_player1 = new System.Windows.Forms.Label();
            this.label_player2 = new System.Windows.Forms.Label();
            this.label_colon = new System.Windows.Forms.Label();
            this.label_points_down2 = new System.Windows.Forms.Label();
            this.label_points_up2 = new System.Windows.Forms.Label();
            this.label_points_down1 = new System.Windows.Forms.Label();
            this.label_points_up1 = new System.Windows.Forms.Label();
            this.label_points2 = new System.Windows.Forms.Label();
            this.label_points1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.Location = new System.Drawing.Point(-11, 456);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(149, 110);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(-11, -11);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(149, 109);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_login1
            // 
            this.button_login1.Location = new System.Drawing.Point(-11, 155);
            this.button_login1.Name = "button_login1";
            this.button_login1.Size = new System.Drawing.Size(149, 70);
            this.button_login1.TabIndex = 3;
            this.button_login1.Text = "Zaloguj Zawodnika1";
            this.button_login1.UseVisualStyleBackColor = true;
            this.button_login1.Click += new System.EventHandler(this.button_login1_Click);
            // 
            // button_login2
            // 
            this.button_login2.Location = new System.Drawing.Point(-11, 235);
            this.button_login2.Name = "button_login2";
            this.button_login2.Size = new System.Drawing.Size(149, 70);
            this.button_login2.TabIndex = 4;
            this.button_login2.Text = "Zaloguj Zawodnika2";
            this.button_login2.UseVisualStyleBackColor = true;
            this.button_login2.Click += new System.EventHandler(this.button_login2_Click);
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_auto.Checked = true;
            this.checkBox_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_auto.Location = new System.Drawing.Point(-2, 120);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(140, 19);
            this.checkBox_auto.TabIndex = 5;
            this.checkBox_auto.Text = "automatyczne punkty";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            this.checkBox_auto.CheckedChanged += new System.EventHandler(this.checkBox_auto_CheckedChanged);
            // 
            // label_static_baza
            // 
            this.label_static_baza.AutoSize = true;
            this.label_static_baza.Location = new System.Drawing.Point(10, 430);
            this.label_static_baza.Name = "label_static_baza";
            this.label_static_baza.Size = new System.Drawing.Size(64, 13);
            this.label_static_baza.TabIndex = 12;
            this.label_static_baza.Text = "Połączenie:";
            // 
            // label_baza
            // 
            this.label_baza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_baza.Location = new System.Drawing.Point(80, 430);
            this.label_baza.Name = "label_baza";
            this.label_baza.Size = new System.Drawing.Size(60, 13);
            this.label_baza.TabIndex = 17;
            this.label_baza.Text = "OFFLINE";
            this.label_baza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_static_tryb
            // 
            this.label_static_tryb.AutoSize = true;
            this.label_static_tryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_static_tryb.Location = new System.Drawing.Point(70, 321);
            this.label_static_tryb.Name = "label_static_tryb";
            this.label_static_tryb.Size = new System.Drawing.Size(68, 15);
            this.label_static_tryb.TabIndex = 18;
            this.label_static_tryb.Text = "Rodzaj gry:";
            // 
            // listBox_rodzaj
            // 
            this.listBox_rodzaj.FormattingEnabled = true;
            this.listBox_rodzaj.Items.AddRange(new object[] {
            "Mecz towarzyski",
            "Turniej"});
            this.listBox_rodzaj.Location = new System.Drawing.Point(-11, 339);
            this.listBox_rodzaj.Name = "listBox_rodzaj";
            this.listBox_rodzaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox_rodzaj.Size = new System.Drawing.Size(149, 30);
            this.listBox_rodzaj.TabIndex = 20;
            this.listBox_rodzaj.SelectedIndexChanged += new System.EventHandler(this.listBox_rodzaj_SelectedIndexChanged);
            // 
            // textBox_kod
            // 
            this.textBox_kod.Location = new System.Drawing.Point(-11, 392);
            this.textBox_kod.MaxLength = 10;
            this.textBox_kod.Name = "textBox_kod";
            this.textBox_kod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_kod.Size = new System.Drawing.Size(149, 20);
            this.textBox_kod.TabIndex = 21;
            this.textBox_kod.Visible = false;
            // 
            // label_static_kod
            // 
            this.label_static_kod.AutoSize = true;
            this.label_static_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_static_kod.Location = new System.Drawing.Point(58, 374);
            this.label_static_kod.Name = "label_static_kod";
            this.label_static_kod.Size = new System.Drawing.Size(80, 15);
            this.label_static_kod.TabIndex = 22;
            this.label_static_kod.Text = "Kod Turnieju:";
            this.label_static_kod.Visible = false;
            // 
            // label_player1
            // 
            this.label_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_player1.Location = new System.Drawing.Point(160, 100);
            this.label_player1.Name = "label_player1";
            this.label_player1.Size = new System.Drawing.Size(300, 50);
            this.label_player1.TabIndex = 23;
            this.label_player1.Text = "Zawodnik1";
            this.label_player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_player1.Visible = false;
            // 
            // label_player2
            // 
            this.label_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_player2.Location = new System.Drawing.Point(470, 100);
            this.label_player2.Name = "label_player2";
            this.label_player2.Size = new System.Drawing.Size(300, 50);
            this.label_player2.TabIndex = 24;
            this.label_player2.Text = "Zawodnik2";
            this.label_player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_player2.Visible = false;
            // 
            // label_colon
            // 
            this.label_colon.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_colon.Location = new System.Drawing.Point(440, 173);
            this.label_colon.Name = "label_colon";
            this.label_colon.Size = new System.Drawing.Size(50, 360);
            this.label_colon.TabIndex = 46;
            this.label_colon.Text = ":";
            this.label_colon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_colon.Visible = false;
            // 
            // label_points_down2
            // 
            this.label_points_down2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points_down2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_points_down2.Location = new System.Drawing.Point(470, 430);
            this.label_points_down2.Name = "label_points_down2";
            this.label_points_down2.Size = new System.Drawing.Size(300, 130);
            this.label_points_down2.TabIndex = 45;
            this.label_points_down2.Text = "9";
            this.label_points_down2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_points_down2.Visible = false;
            this.label_points_down2.Click += new System.EventHandler(this.label_points_down2_Click);
            // 
            // label_points_up2
            // 
            this.label_points_up2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points_up2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_points_up2.Location = new System.Drawing.Point(470, 150);
            this.label_points_up2.Name = "label_points_up2";
            this.label_points_up2.Size = new System.Drawing.Size(300, 130);
            this.label_points_up2.TabIndex = 44;
            this.label_points_up2.Text = "11";
            this.label_points_up2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_points_up2.Visible = false;
            this.label_points_up2.Click += new System.EventHandler(this.label_points_up2_Click);
            // 
            // label_points_down1
            // 
            this.label_points_down1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points_down1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_points_down1.Location = new System.Drawing.Point(160, 430);
            this.label_points_down1.Name = "label_points_down1";
            this.label_points_down1.Size = new System.Drawing.Size(300, 130);
            this.label_points_down1.TabIndex = 43;
            this.label_points_down1.Text = "9";
            this.label_points_down1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_points_down1.Visible = false;
            this.label_points_down1.Click += new System.EventHandler(this.label_points_down1_Click);
            // 
            // label_points_up1
            // 
            this.label_points_up1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points_up1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_points_up1.Location = new System.Drawing.Point(160, 150);
            this.label_points_up1.Name = "label_points_up1";
            this.label_points_up1.Size = new System.Drawing.Size(300, 130);
            this.label_points_up1.TabIndex = 42;
            this.label_points_up1.Text = "11";
            this.label_points_up1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_points_up1.Visible = false;
            this.label_points_up1.Click += new System.EventHandler(this.label_points_up1_Click);
            // 
            // label_points2
            // 
            this.label_points2.Font = new System.Drawing.Font("Microsoft Sans Serif", 140F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points2.Location = new System.Drawing.Point(470, 250);
            this.label_points2.Name = "label_points2";
            this.label_points2.Size = new System.Drawing.Size(300, 200);
            this.label_points2.TabIndex = 41;
            this.label_points2.Text = "10";
            this.label_points2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_points2.Visible = false;
            // 
            // label_points1
            // 
            this.label_points1.Font = new System.Drawing.Font("Microsoft Sans Serif", 140F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_points1.Location = new System.Drawing.Point(160, 250);
            this.label_points1.Name = "label_points1";
            this.label_points1.Size = new System.Drawing.Size(300, 200);
            this.label_points1.TabIndex = 40;
            this.label_points1.Text = "10";
            this.label_points1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_points1.Visible = false;
            // 
            // PingPoint_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label_colon);
            this.Controls.Add(this.label_points_down2);
            this.Controls.Add(this.label_points_up2);
            this.Controls.Add(this.label_points_down1);
            this.Controls.Add(this.label_points_up1);
            this.Controls.Add(this.label_points2);
            this.Controls.Add(this.label_points1);
            this.Controls.Add(this.label_player2);
            this.Controls.Add(this.label_player1);
            this.Controls.Add(this.label_static_kod);
            this.Controls.Add(this.textBox_kod);
            this.Controls.Add(this.listBox_rodzaj);
            this.Controls.Add(this.label_static_tryb);
            this.Controls.Add(this.label_baza);
            this.Controls.Add(this.label_static_baza);
            this.Controls.Add(this.checkBox_auto);
            this.Controls.Add(this.button_login2);
            this.Controls.Add(this.button_login1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PingPoint_main";
            this.Text = "PingPoint";
            this.Load += new System.EventHandler(this.PingPoint_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_login1;
        private System.Windows.Forms.Button button_login2;
        private System.Windows.Forms.CheckBox checkBox_auto;
        private System.Windows.Forms.Label label_static_baza;
        private System.Windows.Forms.Label label_baza;
        private System.Windows.Forms.Label label_static_tryb;
        private System.Windows.Forms.ListBox listBox_rodzaj;
        private System.Windows.Forms.TextBox textBox_kod;
        private System.Windows.Forms.Label label_static_kod;
        private System.Windows.Forms.Label label_player1;
        private System.Windows.Forms.Label label_player2;
        private System.Windows.Forms.Label label_colon;
        private System.Windows.Forms.Label label_points_down2;
        private System.Windows.Forms.Label label_points_up2;
        private System.Windows.Forms.Label label_points_down1;
        private System.Windows.Forms.Label label_points_up1;
        private System.Windows.Forms.Label label_points2;
        private System.Windows.Forms.Label label_points1;
    }
}

