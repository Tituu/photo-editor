namespace GraphicsLabPhotos
{
    partial class photoEditorForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(photoEditorForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtresStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negetiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolsButton = new System.Windows.Forms.ToolStripButton();
            this.applyColorChangesButton = new System.Windows.Forms.ToolStripButton();
            this.restoreChangesButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripDropDownButton,
            this.filtresStripButton,
            this.colorToolsButton,
            this.applyColorChangesButton,
            this.restoreChangesButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileStripDropDownButton
            // 
            this.fileStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileStripDropDownButton.Image")));
            this.fileStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileStripDropDownButton.Name = "fileStripDropDownButton";
            this.fileStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.fileStripDropDownButton.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filtresStripButton
            // 
            this.filtresStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtresStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem,
            this.negetiveToolStripMenuItem});
            this.filtresStripButton.Image = ((System.Drawing.Image)(resources.GetObject("filtresStripButton.Image")));
            this.filtresStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtresStripButton.Name = "filtresStripButton";
            this.filtresStripButton.Size = new System.Drawing.Size(51, 22);
            this.filtresStripButton.Text = "Filters";
            this.filtresStripButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyScaleToolStripMenuItem.Text = "Grey Scale ";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // negetiveToolStripMenuItem
            // 
            this.negetiveToolStripMenuItem.Name = "negetiveToolStripMenuItem";
            this.negetiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negetiveToolStripMenuItem.Text = "Negetive";
            this.negetiveToolStripMenuItem.Click += new System.EventHandler(this.negetiveToolStripMenuItem_Click);
            // 
            // colorToolsButton
            // 
            this.colorToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("colorToolsButton.Image")));
            this.colorToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorToolsButton.Name = "colorToolsButton";
            this.colorToolsButton.Size = new System.Drawing.Size(70, 22);
            this.colorToolsButton.Text = "Color Tools";
            this.colorToolsButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // applyColorChangesButton
            // 
            this.applyColorChangesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.applyColorChangesButton.Image = ((System.Drawing.Image)(resources.GetObject("applyColorChangesButton.Image")));
            this.applyColorChangesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applyColorChangesButton.Name = "applyColorChangesButton";
            this.applyColorChangesButton.Size = new System.Drawing.Size(123, 22);
            this.applyColorChangesButton.Text = "Apply Color Changes";
            this.applyColorChangesButton.ToolTipText = "Apply color changes";
            this.applyColorChangesButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // restoreChangesButton
            // 
            this.restoreChangesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.restoreChangesButton.Image = ((System.Drawing.Image)(resources.GetObject("restoreChangesButton.Image")));
            this.restoreChangesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.restoreChangesButton.Name = "restoreChangesButton";
            this.restoreChangesButton.Size = new System.Drawing.Size(119, 22);
            this.restoreChangesButton.Text = "Restore All Changes ";
            this.restoreChangesButton.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 425);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(626, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(162, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // photoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "photoEditorForm";
            this.Text = "Photo Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton colorToolsButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton applyColorChangesButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripDropDownButton filtresStripButton;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negetiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton restoreChangesButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

