using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Kütüphane.ORM;
namespace WindowsFormsApplication1
{
  public  class dtenginer
    {
        KütüphaneEntities Db = new KütüphaneEntities();
        public Users Login(string kullanıcı,string sifre)
        {
            
            return Db.Users.First(x => (x.Username == kullanıcı && x.password == sifre));
        }

        public IList<Books> Booklist()
        {


            return Db.Books.ToList();
        }
        public IList<Books> Booklist(categories id)
        {

            return Db.Books.Where(x => (x.CategoryBook == id.CategoryBook)).ToList();
        }
        public IList<Books> Booklist(Users id)
        {


            return Db.Books.Where(x => (x.Userbook == id.Userbook)).ToList();
        }
        public bool BookAdd(Books book)
        {
            if (book == null)
                return false;
            else
            {
                Db.Books.Add(book);
                
                return true;
            }
          
            
        }
        public void BookDelete(Books book)
        {
            Db.CategoryBook.RemoveRange(Db.CategoryBook.Where(x => (x.BookID ==book.ID)));
            Db.Userbook.RemoveRange(Db.Userbook.Where(x => (x.BookID == book.ID)));

            Db.Books.Remove(book);
            Db.SaveChanges();
        }

        public bool UserAdd(Users user)
        {
            if (user == null)
                return false;
            else
                Db.Users.Add(user);
            Db.SaveChanges();
            return true;


        }
        public IList<categories> Categorylist()
        {


            return Db.categories.ToList();
        }
        public IList<Writer> Writerlist()
        {

            return Db.Writer.ToList();
        }
    }
}
