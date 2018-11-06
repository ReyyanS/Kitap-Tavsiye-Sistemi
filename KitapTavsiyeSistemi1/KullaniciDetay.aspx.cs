using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
    public partial class KullaniciDetay : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        string kullaniciadi = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            kullaniciadi = Request.QueryString["KullaniciId"];
            SqlCommand komut = new SqlCommand("select KullaniciAdi from Kullanici where KullaniciId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciadi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKullanici.Text = dr[0].ToString();
            }

           
            SqlCommand komut2 = new SqlCommand("select Isim from Kullanici where KullaniciId=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", kullaniciadi);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Lblkullaniciad.Text = dr2[0].ToString();
            }

            SqlCommand komut3 = new SqlCommand("select Soyisim from Kullanici where KullaniciId=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", kullaniciadi);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblKullaniciSoyad.Text = dr3[0].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mesajlar.aspx");
        }
    }
}