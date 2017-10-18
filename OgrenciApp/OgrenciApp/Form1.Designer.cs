namespace OgrenciApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi1 = new System.Windows.Forms.TextBox();
            this.txtSoyadi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResim = new System.Windows.Forms.Button();
            this.lblResim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pbResim1 = new System.Windows.Forms.PictureBox();
            this.pbResim2 = new System.Windows.Forms.PictureBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.txtSoyadi2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdi2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // txtAdi1
            // 
            this.txtAdi1.Location = new System.Drawing.Point(61, 30);
            this.txtAdi1.Name = "txtAdi1";
            this.txtAdi1.Size = new System.Drawing.Size(188, 20);
            this.txtAdi1.TabIndex = 1;
            // 
            // txtSoyadi1
            // 
            this.txtSoyadi1.Location = new System.Drawing.Point(61, 56);
            this.txtSoyadi1.Name = "txtSoyadi1";
            this.txtSoyadi1.Size = new System.Drawing.Size(188, 20);
            this.txtSoyadi1.TabIndex = 3;
            this.txtSoyadi1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad :";
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(61, 93);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(75, 23);
            this.btnResim.TabIndex = 4;
            this.btnResim.Text = "Dosya Seç";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(142, 98);
            this.lblResim.Name = "lblResim";
            this.lblResim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResim.Size = new System.Drawing.Size(52, 13);
            this.lblResim.TabIndex = 5;
            this.lblResim.Text = "Seçilmedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resim :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(15, 134);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(234, 47);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Veritabanına Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pbResim1
            // 
            this.pbResim1.Location = new System.Drawing.Point(15, 188);
            this.pbResim1.Name = "pbResim1";
            this.pbResim1.Size = new System.Drawing.Size(234, 157);
            this.pbResim1.TabIndex = 8;
            this.pbResim1.TabStop = false;
            // 
            // pbResim2
            // 
            this.pbResim2.Location = new System.Drawing.Point(302, 188);
            this.pbResim2.Name = "pbResim2";
            this.pbResim2.Size = new System.Drawing.Size(234, 157);
            this.pbResim2.TabIndex = 17;
            this.pbResim2.TabStop = false;
            this.pbResim2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(302, 134);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(234, 47);
            this.btnSec.TabIndex = 16;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoyadi2
            // 
            this.txtSoyadi2.Location = new System.Drawing.Point(348, 56);
            this.txtSoyadi2.Name = "txtSoyadi2";
            this.txtSoyadi2.Size = new System.Drawing.Size(188, 20);
            this.txtSoyadi2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Soyad :";
            // 
            // txtAdi2
            // 
            this.txtAdi2.Location = new System.Drawing.Point(348, 30);
            this.txtAdi2.Name = "txtAdi2";
            this.txtAdi2.Size = new System.Drawing.Size(188, 20);
            this.txtAdi2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ad :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 405);
            this.Controls.Add(this.pbResim2);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.txtSoyadi2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdi2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbResim1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.txtSoyadi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi1;
        private System.Windows.Forms.TextBox txtSoyadi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.PictureBox pbResim1;
        private System.Windows.Forms.PictureBox pbResim2;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox txtSoyadi2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdi2;
        private System.Windows.Forms.Label label7;
    }
}

