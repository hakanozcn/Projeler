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
    public partial class TümKitaplar :anaform
    {
        public TümKitaplar()
        {
            InitializeComponent();
        }

        private void TümKitaplar_Load(object sender, EventArgs e)
        {
            dtenginer dt = new dtenginer();
            DataKitapView.DataSource = dt.Booklist();
        }
    }
}
