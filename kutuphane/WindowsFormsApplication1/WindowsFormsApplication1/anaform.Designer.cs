namespace WindowsFormsApplication1
{
    partial class anaform
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tümkitaplar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kitapekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kullanıcı = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cıkıs2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümkitaplar,
            this.toolStripSeparator1,
            this.kitapekle,
            this.toolStripSeparator2,
            this.kullanıcı,
            this.toolStripSeparator3,
            this.cıkıs2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tümkitaplar
            // 
            this.tümkitaplar.Image = global::WindowsFormsApplication1.Properties.Resources.Double_J_Design_Ravenna_3d_Books;
            this.tümkitaplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tümkitaplar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tümkitaplar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tümkitaplar.Name = "tümkitaplar";
            this.tümkitaplar.Size = new System.Drawing.Size(107, 36);
            this.tümkitaplar.Text = "tüm kitaplar";
            this.tümkitaplar.Click += new System.EventHandler(this.tümkitaplar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // kitapekle
            // 
            this.kitapekle.Image = global::WindowsFormsApplication1.Properties.Resources.Kyo_Tux_Delikate_Add;
            this.kitapekle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitapekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(93, 36);
            this.kitapekle.Text = " kitapekle";
            this.kitapekle.Click += new System.EventHandler(this.kitapekle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // kullanıcı
            // 
            this.kullanıcı.Image = global::WindowsFormsApplication1.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Man;
            this.kullanıcı.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kullanıcı.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(87, 36);
            this.kullanıcı.Text = "kullanıcı";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // cıkıs2
            // 
            this.cıkıs2.Image = global::WindowsFormsApplication1.Properties.Resources.Oxygen_Icons1;
            this.cıkıs2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cıkıs2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cıkıs2.Name = "cıkıs2";
            this.cıkıs2.Size = new System.Drawing.Size(66, 36);
            this.cıkıs2.Text = "cıkıs";
            this.cıkıs2.Click += new System.EventHandler(this.cıkıs2_Click);
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "anaform";
            this.Text = "Kütüphane sıstemı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.anaform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tümkitaplar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton kitapekle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton kullanıcı;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cıkıs2;
    }
}