namespace PingPoint
{
    partial class FriendlyMatchSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_set = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_point = new System.Windows.Forms.NumericUpDown();
            this.button_save = new System.Windows.Forms.Button();
            this.button_var1 = new System.Windows.Forms.Button();
            this.button_var3 = new System.Windows.Forms.Button();
            this.button_var2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_point)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba setów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba punktów";
            // 
            // numericUpDown_set
            // 
            this.numericUpDown_set.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_set.Location = new System.Drawing.Point(162, 114);
            this.numericUpDown_set.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_set.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_set.Name = "numericUpDown_set";
            this.numericUpDown_set.ReadOnly = true;
            this.numericUpDown_set.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_set.TabIndex = 2;
            this.numericUpDown_set.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_point
            // 
            this.numericUpDown_point.Location = new System.Drawing.Point(162, 150);
            this.numericUpDown_point.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_point.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_point.Name = "numericUpDown_point";
            this.numericUpDown_point.ReadOnly = true;
            this.numericUpDown_point.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_point.TabIndex = 3;
            this.numericUpDown_point.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 197);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(260, 53);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Zapisz";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_var1
            // 
            this.button_var1.Location = new System.Drawing.Point(13, 32);
            this.button_var1.Name = "button_var1";
            this.button_var1.Size = new System.Drawing.Size(80, 60);
            this.button_var1.TabIndex = 10;
            this.button_var1.Text = "Krótki";
            this.button_var1.UseVisualStyleBackColor = true;
            this.button_var1.Click += new System.EventHandler(this.button_var1_Click);
            // 
            // button_var3
            // 
            this.button_var3.Location = new System.Drawing.Point(184, 32);
            this.button_var3.Name = "button_var3";
            this.button_var3.Size = new System.Drawing.Size(80, 60);
            this.button_var3.TabIndex = 9;
            this.button_var3.Text = "Długi";
            this.button_var3.UseVisualStyleBackColor = true;
            this.button_var3.Click += new System.EventHandler(this.button_var3_Click);
            // 
            // button_var2
            // 
            this.button_var2.Location = new System.Drawing.Point(98, 32);
            this.button_var2.Name = "button_var2";
            this.button_var2.Size = new System.Drawing.Size(80, 60);
            this.button_var2.TabIndex = 8;
            this.button_var2.Text = "Standardowy";
            this.button_var2.UseVisualStyleBackColor = true;
            this.button_var2.Click += new System.EventHandler(this.button_var2_Click);
            // 
            // FriendlyMatchSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_var1);
            this.Controls.Add(this.button_var3);
            this.Controls.Add(this.button_var2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.numericUpDown_point);
            this.Controls.Add(this.numericUpDown_set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FriendlyMatchSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Friendly Match Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_set;
        private System.Windows.Forms.NumericUpDown numericUpDown_point;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_var1;
        private System.Windows.Forms.Button button_var3;
        private System.Windows.Forms.Button button_var2;
    }
}