using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;

namespace OgrenciApp
{
    public class Ogrenci
    {
        public Ogrenci()
        {

        }

        public Ogrenci(string name, string lastname, Image pic)
        {
            Adi = name;
            Soyadi = lastname;
            Resim = pic;
        }

        public int Id = 0;

        public string Adi = "";

        public string Soyadi = "";

        public Image Resim = null;

        public string Ekle()
        {
            Adi = Adi.Trim();
            Soyadi = Soyadi.Trim();
            if (Adi != "" && Soyadi != "" && Resim != null)
            {
                Veritabani vt = new Veritabani();
                int res = vt.OgrenciEkle(Adi, Soyadi, Resim);
                if (res > 0)
                {
                    return "Öğrenci Eklendi";
                }
                else
                {
                    return "Öğrenci Eklenemedi";
                }
            }
            else
            {
                return "Tüm Alanları Eksiksiz Doldurunuz";
            }
        }

        public static Ogrenci Bul(string name, string lastname)
        {
            name = name.Trim();
            lastname = lastname.Trim();
            if (name == "" || lastname == "")
            {
                return new Ogrenci();
            }
            Veritabani vt = new Veritabani();
            ögrenciler dt = vt.OgrenciSec(name, lastname);
            if (dt==null)
            {
                return new Ogrenci();
            }
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = dt.Adi.ToString();
            ogr.Soyadi = dt.Soyadi.ToString();
            ogr.Resim = Image.FromFile(Environment.CurrentDirectory + "/images/" + dt.resim.ToString() + ".jpg");
            return ogr;
        }
    }
   
    public class Veritabani
    {
       /* public readonly string ConnectionString = " C:/Users/hakan/Desktop/calısmalar/OgrenciApp/OgrenciApp/bin/Debug/App_DataOgrenciDB.accdb";

        private readonly OleDbConnection Connection = null;*/

        public Veritabani()
        {
            ögrenciEntities enity = new ögrenciEntities();
        }

        public ögrenciler OgrenciSec(string name, string lastname)
        {
            ögrenciEntities connention = new ögrenciEntities();

          IList<ögrenciler> ögrenciler=  connention.ögrenciler.ToList();
           
           
            ögrenciler ögrenci = connention.ögrenciler.First(x => (x.Adi == name.ToString() || x.Soyadi == lastname));
           
            
            return ögrenci;
        }

        public int OgrenciEkle(string name, string lastname, Image pic)
        {
            ögrenciEntities Entity = new ögrenciEntities();
            int res = 0;
            string radi = DateTime.Now.Ticks.ToString() + "_" + new Random().Next(0, 1000);
            /*OleDbCommand cmd = new OleDbCommand("INSERT INTO ogrenciler (Adi, Soyadi, Resim) VALUES (@Adi, @Soyadi, @Resim)", Connection);*/
            ögrenciler x = new ögrenciler { Adi = name,
                Soyadi = lastname,
                resim = radi };

          x=   Entity.ögrenciler.Add(x);
            Entity.SaveChanges();
            if (x !=null)
            {
                if (!Directory.Exists(Environment.CurrentDirectory + "/images")) 
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "/images");
                }
                Size sz = new Size(234, 157);
                Bitmap bmp = new Bitmap(pic, sz);
                bmp.Save(Environment.CurrentDirectory + "/images/" + radi + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                res = 1;
            }
            return res;
        }
    }
}
