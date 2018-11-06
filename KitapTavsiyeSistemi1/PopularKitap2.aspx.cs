using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{   
    
    public partial class PopularKitap2 : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select top 5 Kitaplar.KitapID, Kitaplar.KitapAdi, Yazarlar.YazarAdSoyad, (select  COUNT(Okunma2.OkunduMu) from Okunma2,Kullanici where Kitaplar.KitapID=Okunma2.KitapID and Kullanici.KullaniciId=Okunma2.KullaniciID ) as OkunmaSayisi from Kitaplar,KitapYazar, Yazarlar where Kitaplar.KitapID=KitapYazar.KitapID and Yazarlar.YazarID= KitapYazar.YazarID order by OkunmaSayisi desc", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}