namespace PingPoint
{
    partial class Wait
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
            this.label_change = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_change
            // 
            this.label_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_change.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_change.Location = new System.Drawing.Point(0, 0);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(640, 150);
            this.label_change.TabIndex = 0;
            this.label_change.Text = "Kliknij by poprawić wynik setu";
            this.label_change.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_change.Click += new System.EventHandler(this.label_change_Click);
            this.label_change.MouseEnter += new System.EventHandler(this.label_change_MouseEnter);
            this.label_change.MouseLeave += new System.EventHandler(this.label_change_MouseLeave);
            // 
            // label_time
            // 
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_time.ForeColor = System.Drawing.Color.Crimson;
            this.label_time.Location = new System.Drawing.Point(600, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(40, 60);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "5";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 150);
            this.ControlBox = false;
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wait";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Wait";
            this.Load += new System.EventHandler(this.Wait_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_change;
        private System.Windows.Forms.Label label_time;
    }
}