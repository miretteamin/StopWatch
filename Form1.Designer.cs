namespace StopWatch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Minuteslbl = new System.Windows.Forms.Label();
            this.Hourslbl = new System.Windows.Forms.Label();
            this.Secondslbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Exitbtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Exitbtn.ForeColor = System.Drawing.Color.DeepPink;
            this.Exitbtn.Location = new System.Drawing.Point(244, 139);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 34);
            this.Exitbtn.TabIndex = 0;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Resetbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Resetbtn.ForeColor = System.Drawing.Color.Purple;
            this.Resetbtn.Location = new System.Drawing.Point(126, 140);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(75, 34);
            this.Resetbtn.TabIndex = 1;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LavenderBlush;
            this.Start.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.Purple;
            this.Start.Location = new System.Drawing.Point(12, 139);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 34);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Minuteslbl
            // 
            this.Minuteslbl.AutoSize = true;
            this.Minuteslbl.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
            this.Minuteslbl.ForeColor = System.Drawing.Color.Purple;
            this.Minuteslbl.Location = new System.Drawing.Point(124, 42);
            this.Minuteslbl.Name = "Minuteslbl";
            this.Minuteslbl.Size = new System.Drawing.Size(77, 52);
            this.Minuteslbl.TabIndex = 3;
            this.Minuteslbl.Text = "00";
            // 
            // Hourslbl
            // 
            this.Hourslbl.AutoSize = true;
            this.Hourslbl.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
            this.Hourslbl.ForeColor = System.Drawing.Color.Purple;
            this.Hourslbl.Location = new System.Drawing.Point(19, 42);
            this.Hourslbl.Name = "Hourslbl";
            this.Hourslbl.Size = new System.Drawing.Size(77, 52);
            this.Hourslbl.TabIndex = 4;
            this.Hourslbl.Text = "00";
            // 
            // Secondslbl
            // 
            this.Secondslbl.AutoSize = true;
            this.Secondslbl.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold);
            this.Secondslbl.ForeColor = System.Drawing.Color.DeepPink;
            this.Secondslbl.Location = new System.Drawing.Point(235, 42);
            this.Secondslbl.Name = "Secondslbl";
            this.Secondslbl.Size = new System.Drawing.Size(77, 52);
            this.Secondslbl.TabIndex = 5;
            this.Secondslbl.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(202, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(91, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 51);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(335, 196);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Secondslbl);
            this.Controls.Add(this.Hourslbl);
            this.Controls.Add(this.Minuteslbl);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Exitbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(351, 235);
            this.MinimumSize = new System.Drawing.Size(351, 235);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Minuteslbl;
        private System.Windows.Forms.Label Hourslbl;
        private System.Windows.Forms.Label Secondslbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

