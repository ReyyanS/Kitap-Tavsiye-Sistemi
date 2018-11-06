using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
    public class DBIslemleri
    { 

        public static bool Kontrol (string yoneticiAdi, string sifre)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            string sql = "select * from Yonetici where YoneticiAdi=@pyoneticiAdi and YoneticiSifre=@psifre";
            SqlCommand komut = new SqlCommand(sql, conn);
            conn.Open();
            bool sonuc = false;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            komut.Parameters.AddWithValue("@pyoneticiAdi", yoneticiAdi);
            komut.Parameters.AddWithValue("@psifre", sifre);

            DataSet sonuclar = new DataSet();
            adaptor.Fill(sonuclar);
            conn.Close();
            if (sonuclar.Tables[0].Rows.Count > 0)
                sonuc = true;
            return sonuc;

        }

        public static bool KullaniciKontrol (string kullaniciAdi, string sifre)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            string sql = "select * from Kullanici where KullaniciAdi=@pkullaniciAdi and Sifre=@psifre ";
            SqlCommand komut = new SqlCommand(sql, conn);
            conn.Open();
            bool sonuc = false;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            komut.Parameters.AddWithValue("@pkullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@psifre", sifre);
            DataSet sonuclar = new DataSet();
            adaptor.Fill(sonuclar);
            conn.Close();
            if (sonuclar.Tables[0].Rows.Count > 0)
                sonuc = true;
            return sonuc;
        }
        public int IdAl(string kullaniciadi)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            string sql = "select KullaniciId from Kullanici where KullaniciAdi=@pkullaniciAdi"; 
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pkullaniciAdi",kullaniciadi);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["KullaniciId"]);
            return id;
        }

        public SqlConnection baglanti()
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection baglan = new SqlConnection(by);
            baglan.Open();
            return baglan;
        }

     

       /* public DataSet KitapAra()
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();

        }*/
        public DataSet popkitap()
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select Kitaplar.KitapID,Kitaplar.KitapAdi, Yazarlar.YazarAdSoyad, (select COUNT(Okunma2.OkunduMu) from Okunma2,Kullanici where Kitaplar.KitapID=Okunma2.KitapID and Kullanici.KullaniciId=Okunma2.KullaniciID) as okunmasayisi from Kitaplar,KitapYazar, Yazarlar where Kitaplar.KitapID=KitapYazar.KitapID and Yazarlar.YazarID= KitapYazar.YazarID ";
            SqlCommand komut = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        public DataSet popyazar()
        {

            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select  Yazarlar.YazarAdSoyad, (select COUNT(Okunma2.OkunduMu) from Okunma2,Kullanici where Kitaplar.KitapID=Okunma2.KitapID and Kullanici.KullaniciId=Okunma2.KullaniciID) as OkunmaSayisi from Kitaplar,KitapYazar, Yazarlar where Kitaplar.KitapID=KitapYazar.KitapID and Yazarlar.YazarID= KitapYazar.YazarID";
            SqlCommand komut = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        public DataSet YazarArama(string Text)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select * from Yazarlar where YazarAdSoyad like '%'+@ptext+'%' ";
            
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@ptext",Text);
            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataSet ds = new DataSet();
            adap.Fill(ds, "Yazarlar");
            return ds;
        }
        public DataSet KitapArama(string Text2)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select * from Kitaplar where KitapAdi like '%'+@ptext1+'%' ";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@ptext1", Text2);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds,"Kitaplar");
            return ds;
        }

        public DataSet KullaniciArama(string Text3)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select * from Kullanici where KullaniciAdi like '%'+@ptext2+'%' ";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@ptext2", Text3);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Kullanici");
            return ds;
        }
        public DataSet KullaniciBilgileri(int id)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select (Kullanici.Isim+ ' ' + Kullanici.Soyisim) as adsoyad from Kullanici where Kullanici.KullaniciId = @pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pid", id);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }
       public DataSet KullaniciKitaplariGetir(int id)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select distinct  (select Kitaplar.KitapAdi from Kitaplar where Okunma2.KitapID=Kitaplar.KitapID) as KitapAdi from Okunma2 where  Okunma2.KullaniciID=@pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pid", id);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;

        }
        public DataSet KullaniciPuanGetir(int id)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select distinct Puan.Puan,(select Kitaplar.KitapAdi from Kitaplar where Puan.KitapId=Kitaplar.KitapID) as KitapAdi from Puan where  Puan.KullaniciId=@pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pid", id);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }
        public DataSet KullaniciIncelemeGetir(int id)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select distinct Incelemeler.Incelemeler, (select Kitaplar.KitapAdi from Kitaplar where Incelemeler.KitapId=Kitaplar.KitapID) as KitapAdi from Incelemeler where Incelemeler.KullaniciId=@pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pid", id);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }
        public DataSet KullaniciAlintiGetir(int id)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select distinct Alinti.Cumle,Alinti.SayfaNo, (select Kitaplar.KitapAdi from Kitaplar where Alinti.KitapId=Kitaplar.KitapID) as KitapAdi from Alinti where Alinti.KullaniciId=@pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pid", id);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }
        public DataSet KullaniciTavsiye(int id)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select distinct u2.KullaniciAdi from Kullanici u join Okunma2 bu on u.KullaniciId = bu.KullaniciID join Okunma2 bu2 on bu.KitapID = bu2.KitapID and bu.KitapID <> bu2.KullaniciID join Kullanici u2 on bu2.KullaniciID = u2.KullaniciId where u.KullaniciId =@pid";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@pid", id);
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }

        public DataSet YuksekPuanlilar()
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql = "select top(3) Kitaplar.KitapID,Kitaplar.KitapAdi,Yazarlar.YazarAdSoyad,(select AVG(cast(Puan.Puan as float)) from Puan,Kullanici where Kitaplar.KitapID=Puan.KitapId and Kullanici.KullaniciId=Puan.KullaniciId) as PuanOrtalama from Kitaplar, KitapYazar, Yazarlar where Kitaplar.KitapID = KitapYazar.KitapID and Yazarlar.YazarID = KitapYazar.YazarID order by PuanOrtalama desc";
            SqlCommand komut = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;

        }

        public void IncelemeEkle(int kitapid, string inceleme, int kullaniciId)
        {
            string by = ConfigurationManager.ConnectionStrings["DByolu"].ToString();
            SqlConnection conn = new SqlConnection(by);
            conn.Open();
            string sql= "insert into dbo.[Incelemeler] (KullaniciId,KitapId,Incelemeler) values (@kullaniciId,@kitapid,@inceleme";
            SqlCommand komut = new SqlCommand(sql, conn);
            komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
            komut.Parameters.AddWithValue("@kitapid", kitapid);
            komut.Parameters.AddWithValue("@inceleme", inceleme);
            komut.ExecuteNonQuery();
            conn.Close();
        }

    }
       
}