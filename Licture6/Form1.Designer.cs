namespace Licture6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenB = new System.Windows.Forms.ToolStripButton();
            this.CopyB = new System.Windows.Forms.ToolStripButton();
            this.PasteB = new System.Windows.Forms.ToolStripButton();
            this.FrameB = new System.Windows.Forms.ToolStripButton();
            this.ScreenShotB = new System.Windows.Forms.ToolStripButton();
            this.Photo1 = new System.Windows.Forms.PictureBox();
            this.Photo2 = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenB,
            this.CopyB,
            this.PasteB,
            this.FrameB,
            this.ScreenShotB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenB
            // 
            this.OpenB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenB.Image = ((System.Drawing.Image)(resources.GetObject("OpenB.Image")));
            this.OpenB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(40, 22);
            this.OpenB.Text = "Open";
            this.OpenB.Click += new System.EventHandler(this.OpenB_Click);
            // 
            // CopyB
            // 
            this.CopyB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CopyB.Enabled = false;
            this.CopyB.Image = ((System.Drawing.Image)(resources.GetObject("CopyB.Image")));
            this.CopyB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyB.Name = "CopyB";
            this.CopyB.Size = new System.Drawing.Size(39, 22);
            this.CopyB.Text = "Copy";
            this.CopyB.Click += new System.EventHandler(this.CopyB_Click);
            // 
            // PasteB
            // 
            this.PasteB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PasteB.Enabled = false;
            this.PasteB.Image = ((System.Drawing.Image)(resources.GetObject("PasteB.Image")));
            this.PasteB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteB.Name = "PasteB";
            this.PasteB.Size = new System.Drawing.Size(39, 22);
            this.PasteB.Text = "Paste";
            this.PasteB.Click += new System.EventHandler(this.PasteB_Click);
            // 
            // FrameB
            // 
            this.FrameB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FrameB.Enabled = false;
            this.FrameB.Image = ((System.Drawing.Image)(resources.GetObject("FrameB.Image")));
            this.FrameB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrameB.Name = "FrameB";
            this.FrameB.Size = new System.Drawing.Size(44, 22);
            this.FrameB.Text = "Frame";
            this.FrameB.Click += new System.EventHandler(this.FrameB_Click);
            // 
            // ScreenShotB
            // 
            this.ScreenShotB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ScreenShotB.Image = ((System.Drawing.Image)(resources.GetObject("ScreenShotB.Image")));
            this.ScreenShotB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScreenShotB.Name = "ScreenShotB";
            this.ScreenShotB.Size = new System.Drawing.Size(69, 22);
            this.ScreenShotB.Text = "Screenshot";
            this.ScreenShotB.Click += new System.EventHandler(this.ScreenShotB_Click);
            // 
            // Photo1
            // 
            this.Photo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Photo1.Location = new System.Drawing.Point(0, 25);
            this.Photo1.Name = "Photo1";
            this.Photo1.Size = new System.Drawing.Size(470, 425);
            this.Photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo1.TabIndex = 1;
            this.Photo1.TabStop = false;
            this.Photo1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Photo1_DragDrop);
            this.Photo1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Photo1_DragEnter);
            this.Photo1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Photo2_MouseDown);
            // 
            // Photo2
            // 
            this.Photo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo2.Location = new System.Drawing.Point(470, 25);
            this.Photo2.Name = "Photo2";
            this.Photo2.Size = new System.Drawing.Size(330, 425);
            this.Photo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo2.TabIndex = 2;
            this.Photo2.TabStop = false;
            this.Photo2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Photo2_DragDrop);
            this.Photo2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Photo2_DragEnter);
            // 
            // OFD
            // 
            this.OFD.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Photo2);
            this.Controls.Add(this.Photo1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenB;
        private System.Windows.Forms.ToolStripButton CopyB;
        private System.Windows.Forms.ToolStripButton PasteB;
        private System.Windows.Forms.ToolStripButton FrameB;
        private System.Windows.Forms.ToolStripButton ScreenShotB;
        private System.Windows.Forms.PictureBox Photo1;
        private System.Windows.Forms.PictureBox Photo2;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

