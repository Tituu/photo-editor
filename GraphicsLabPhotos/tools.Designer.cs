namespace GraphicsLabPhotos
{
    partial class Tools
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(96, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ustawienia kolorów";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 351);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.textBoxRed);
            this.panel5.Controls.Add(this.textBoxGreen);
            this.panel5.Controls.Add(this.textBoxBlue);
            this.panel5.Controls.Add(this.trackBarBlue);
            this.panel5.Controls.Add(this.trackBarGreen);
            this.panel5.Controls.Add(this.trackBarRed);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 110);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(4, 87);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(100, 20);
            this.textBoxRed.TabIndex = 11;
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(142, 87);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(100, 20);
            this.textBoxGreen.TabIndex = 10;
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(271, 87);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlue.TabIndex = 9;
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(267, 36);
            this.trackBarBlue.Maximum = 128;
            this.trackBarBlue.Minimum = -127;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(138, 36);
            this.trackBarGreen.Maximum = 128;
            this.trackBarGreen.Minimum = -127;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 45);
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(0, 36);
            this.trackBarRed.Maximum = 128;
            this.trackBarRed.Minimum = -127;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 45);
            this.trackBarRed.TabIndex = 5;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(300, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Blue";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(153, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Green";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Red";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.textBoxContrast);
            this.panel4.Controls.Add(this.trackBarContrast);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 94);
            this.panel4.TabIndex = 7;
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(142, 71);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast.TabIndex = 12;
            this.textBoxContrast.TextChanged += new System.EventHandler(this.textBoxContrast_TextChanged);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(16, 33);
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(355, 45);
            this.trackBarContrast.TabIndex = 8;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(144, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kontrast";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.textBoxBrightness);
            this.panel3.Controls.Add(this.trackBarBrightness);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 95);
            this.panel3.TabIndex = 6;
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(142, 72);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrightness.TabIndex = 13;
            this.textBoxBrightness.TextChanged += new System.EventHandler(this.textBoxBrightness_TextChanged);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(16, 37);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = -100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(355, 45);
            this.trackBarBrightness.TabIndex = 9;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(143, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jasność";
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 351);
            this.Controls.Add(this.panel1);
            this.Name = "Tools";
            this.Text = "tools";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TextBox textBoxBrightness;
    }
}