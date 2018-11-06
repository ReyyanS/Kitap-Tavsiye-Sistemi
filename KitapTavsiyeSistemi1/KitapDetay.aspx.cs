using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
    public partial class KitapDetay : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        string kitapid = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            kitapid = Request.QueryString["KitapID"];
            SqlCommand komut = new SqlCommand("select KitapAdi from Kitaplar where KitapID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Label2.Text = dr[0].ToString();
            }
         

            SqlCommand komut2 = new SqlCommand("select KitapYazari from Kitaplar where KitapID=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                LabelYazar.Text = dr2[0].ToString();

            }
            SqlCommand komut3 = new SqlCommand("select KitapYayinevi from Kitaplar where KitapID=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LabelYayinevi.Text = dr3[0].ToString();

            }
            kitapid = Request.QueryString["KitapID"];
            SqlCommand komut4 = new SqlCommand("select KitapTanitimi from Kitaplar where KitapID=@p1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LabelTanitim.Text = dr4[0].ToString();

            }

            SqlCommand komut5 = new SqlCommand("select distinct Incelemeler from Incelemeler where KitapID=@p1", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr5 = komut5.ExecuteReader();
            DataList1.DataSource = dr5;
            DataList1.DataBind();

            SqlCommand komut6 = new SqlCommand("select distinct SayfaNo,Cumle from Alinti where KitapId=@p1", bgl.baglanti());
            komut6.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr6 = komut6.ExecuteReader();
            GridView1.DataSource = dr6;
            GridView1.DataBind();

            SqlCommand komut7 = new SqlCommand("select AVG(cast(Puan.Puan as float)) as Puan from Puan where Puan.KitapId =@p1", bgl.baglanti());
            komut7.Parameters.AddWithValue("@p1", kitapid);
            SqlDataReader dr7 = komut7.ExecuteReader();
            DataList2.DataSource = dr7;
            DataList2.DataBind();
         

            /* SqlCommand komut6 = new SqlCommand("select Kullanicilar.KullaniciAdi from Incelemeler,Kullanicilar where KitapID=@p1 and Kullanicilar.KullaniciId=Incelemeler.KullaniciId");
             komut6.Parameters.AddWithValue("@p1", kitapid);
             SqlDataReader dr6 = komut6.ExecuteReader();
             DataList1.DataSource = dr6;
             DataList1.DataBind();*/

            bgl.baglanti().Close();
        }

        protected void ButtonInceleme_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["KullaniciId"]);
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut8 = new SqlCommand("insert into dbo.[Incelemeler] (KullaniciId,KitapId,Incelemeler) values (@kullaniciId,@kitapid,@inceleme)",bgl.baglanti());
            komut8.Parameters.AddWithValue("@kullaniciId", id);
            komut8.Parameters.AddWithValue("@kitapid", Convert.ToInt32(kitapid));
            komut8.Parameters.AddWithValue("@inceleme", TextBoxInceleme.Text);
            komut8.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("İncelemeniz Alındı");
            TextBoxInceleme.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["KullaniciId"]);
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut9 = new SqlCommand("insert into dbo.[Alinti] (KullaniciId,KitapId,SayfaNo,Cumle) values (@kulad,@kitid,@sayfa,@cumle)", bgl.baglanti());
            komut9.Parameters.AddWithValue("@kulad", id);
            komut9.Parameters.AddWithValue("@kitid", Convert.ToInt32(kitapid));
            komut9.Parameters.AddWithValue("@sayfa", TextBoxSayfa.Text);
            komut9.Parameters.AddWithValue("@cumle", TextBoxCumle.Text);
            komut9.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("Alıntınız Alındı");
            TextBoxInceleme.Text = string.Empty;


        }

        protected void ButtonPuan_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["KullaniciId"]);
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut10 = new SqlCommand("insert into dbo.[Puan] (KullaniciId,KitapId,Puan) values (@kulad,@kitid,@puan)", bgl.baglanti());
            komut10.Parameters.AddWithValue("@kulad", id);
            komut10.Parameters.AddWithValue("@kitid", Convert.ToInt32(kitapid));
            komut10.Parameters.AddWithValue("@puan", Int32.Parse(DropDownList1.SelectedValue.ToString()));
            komut10.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("Puanınız Alındı");



        }
    }
}  
           