using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OgrenciApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = Ogrenci.Bul(txtAdi2.Text.Trim(), txtSoyadi2.Text.Trim());
            if (ogr.Adi == "")
            {
                MessageBox.Show("Öğrenci Bulunamadı", "Öğrenci Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbResim2.Image = null;
            }
            else
            {
                pbResim2.Image = ogr.Resim;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (opf.FileName==null) 
                {
                    MessageBox.Show("Lütfen Resim Seçin", "Resim Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (opf.FileName.Trim() == "")
                {
                    MessageBox.Show("Lütfen Resim Seçin", "Resim Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Ogrenci ogr = new Ogrenci();
                ogr.Adi = txtAdi1.Text.Trim();
                ogr.Soyadi = txtSoyadi1.Text.Trim();
                ogr.Resim = Image.FromFile(opf.FileName);
                MessageBox.Show(ogr.Ekle(), "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbResim1.Image = new Bitmap(ogr.Resim, new Size(234, 157));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Sırasında Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbResim1.Image = null;
            }
        }

        OpenFileDialog opf = new OpenFileDialog();

        private void btnResim_Click(object sender, EventArgs e)
        {
            DialogResult dlr = opf.ShowDialog();
            if (dlr == DialogResult.OK)
            {
                lblResim.Text = opf.FileName;
            }
            else
            {
                lblResim.Text = "Seçilmedi";
                opf = new OpenFileDialog();
            }
        }
    }
}
