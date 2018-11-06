using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
    public partial class PopularYazar : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select distinct top 5   Yazarlar.YazarID,Yazarlar.YazarAdSoyad, (select  COUNT(Okunma2.OkunduMu) from Okunma2,Kullanici where Yazarlar.YazarID=Okunma2.YazarID and Kullanici.KullaniciId=Okunma2.KullaniciID ) as OkunmaSayisi from Kitaplar,KitapYazar, Yazarlar where Kitaplar.KitapID=KitapYazar.KitapID and Yazarlar.YazarID= KitapYazar.YazarID order by OkunmaSayisi desc", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();


        }
    }
}