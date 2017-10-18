using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void anaform_Load(object sender, EventArgs e)
        {

        }

        private void cıkıs2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("cıkmak istediginizden eminmisiniz?", "cıkıs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            { Application.Exit(); }

        }

        private void kitapekle_Click(object sender, EventArgs e)
        {
             kitapEkle kitap = new kitapEkle();
            
            kitap.ShowDialog();
            
        }

        private void tümkitaplar_Click(object sender, EventArgs e)
        {
            TümKitaplar Tümkitaplar = new TümKitaplar();
            Tümkitaplar.ShowDialog();
        }
    }
}
