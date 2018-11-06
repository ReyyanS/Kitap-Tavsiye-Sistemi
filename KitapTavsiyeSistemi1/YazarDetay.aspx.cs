using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace KitapTavsiyeSistemi1
{
    public partial class YazarDetay : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        string yazarid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            yazarid = Request.QueryString["YazarID"];
            SqlCommand komut = new SqlCommand("select YazarAdSoyad from Yazarlar where YazarID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", yazarid);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LabelYazarAd.Text = dr[0].ToString();
            }

            SqlCommand komut2 = new SqlCommand("select DogumTarihi from Yazarlar where YazarID=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", yazarid);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LabelDogumTarih.Text = dr2[0].ToString();
            }

            SqlCommand komut3 = new SqlCommand("select DogumYeri from Yazarlar where YazarID=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", yazarid);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LabelDogumYer.Text = dr3[0].ToString();
            }
            SqlCommand komut4 = new SqlCommand("select OlumTarihi from Yazarlar where YazarID=@p1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", yazarid);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LabelOlum.Text = dr4[0].ToString();
            }

          SqlCommand komut5 = new SqlCommand("select KitapAdi from Kitaplar where YazarID=@p1", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", yazarid);
            SqlDataReader dr5 = komut5.ExecuteReader();
            DataList2.DataSource = dr5;
            DataList2.DataBind();
            bgl.baglanti().Close();


        }
    }
}