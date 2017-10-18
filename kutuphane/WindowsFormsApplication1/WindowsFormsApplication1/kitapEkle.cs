using Kütüphane.ORM;
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
    public partial class kitapEkle : anaform
    {
        public kitapEkle()
        {
            InitializeComponent();
        }

        private void kitapEkle_Load(object sender, EventArgs e)
        {
            

            dtenginer Db = new dtenginer();
            Categorybox.DataSource = Db.Categorylist();
            writerbox.DataSource = Db.Writerlist();
            Categorybox.DisplayMember = "Name";
            Categorybox.ValueMember = "ID";
            writerbox.DisplayMember = "Name";
            writerbox.ValueMember = "ID";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            KütüphaneEntities entty = new KütüphaneEntities();
            dtenginer Db = new dtenginer();
            Books book = new Books { Bookname = txtTitle.Text.ToString(),
                WriderID = Convert.ToInt32(writerbox.SelectedValue),
                };
            CategoryBook Cb = new CategoryBook();
            Cb.Books = book;
            Cb.categories = entty.categories.Find((int)Categorybox.SelectedValue);
            Db.BookAdd(book);
            
            entty.CategoryBook.Add(Cb);
            entty.SaveChanges();
            

        }
    }
}
