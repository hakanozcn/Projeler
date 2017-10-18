namespace WindowsFormsApplication1
{
    partial class logın
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logın));
            this.txtkulanıcıadı = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtkulanıcıadı
            // 
            this.txtkulanıcıadı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkulanıcıadı.Location = new System.Drawing.Point(95, 63);
            this.txtkulanıcıadı.MaxLength = 10;
            this.txtkulanıcıadı.Name = "txtkulanıcıadı";
            this.txtkulanıcıadı.Size = new System.Drawing.Size(135, 13);
            this.txtkulanıcıadı.TabIndex = 0;
            this.txtkulanıcıadı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Location = new System.Drawing.Point(95, 95);
            this.txtsifre.MaxLength = 10;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(135, 13);
            this.txtsifre.TabIndex = 1;
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btngiris.Image = global::WindowsFormsApplication1.Properties.Resources.Custom_Icon_Design_Mini_Login_in;
            this.btngiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiris.Location = new System.Drawing.Point(136, 135);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(94, 23);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "giris";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btncıkıs.Image = global::WindowsFormsApplication1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_close;
            this.btncıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncıkıs.Location = new System.Drawing.Point(52, 135);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(87, 23);
            this.btncıkıs.TabIndex = 3;
            this.btncıkıs.Text = "cıkıs";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.cıkıs_Click);
            // 
            // logın
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(297, 198);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkulanıcıadı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logın";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.logın_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkulanıcıadı;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btncıkıs;
    }
}

