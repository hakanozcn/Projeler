using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kütüphane.ORM;
namespace WindowsFormsApplication1
{
    public partial class logın : Form
    {
        public logın()
        {
            InitializeComponent();

           
            
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            dtenginer nesne = new dtenginer();
            Users User = nesne.Login(txtkulanıcıadı.Text, txtsifre.Text);
            if(User==null)
            {

                MessageBox.Show("hatalı gırıs");
            }
            else
                    {
                this.Hide();
                anaform ac = new anaform();
                ac.ShowDialog();

            }
        }

        private void logın_Load(object sender, EventArgs e)
        {

        }
    }
}
