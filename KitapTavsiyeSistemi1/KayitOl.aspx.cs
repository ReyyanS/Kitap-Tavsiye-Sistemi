using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
    public partial class KayıtOl : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {    DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut2 = new SqlCommand("Select * From Yillar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            DropDownList3.DataTextField = "Yillar";
            DropDownList3.DataValueField = "Yilarid";

            DropDownList3.DataSource = dr2;
            DropDownList3.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut = new SqlCommand("insert into Kullanici (Isim,Soyisim,Cinsiyet,DogumTarihi,KullaniciAdi,Sifre,KullaniciResim) values (@t1,@t2,@t3,@t4,@t5,@t6,@t7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@t1", TxtIsım.Text);
            komut.Parameters.AddWithValue("@t2", TxtSoyisim.Text);
            komut.Parameters.AddWithValue("@t3", Cinsiyet.Text);
            // komut.Parameters.AddWithValue("@t4", Gun.SelectedValue);
            //komut.Parameters.AddWithValue("@t4", Ay.SelectedValue);
            komut.Parameters.AddWithValue("@t4", DropDownList3.DataValueField);
            komut.Parameters.AddWithValue("@t5", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@t6", TxtSifre.Text);
            komut.Parameters.AddWithValue("@t7", FileUpload1.FileName);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("Kayıt Oluştu");
            Response.Redirect("KullaniciGiris.aspx");
            TxtIsım.Text = string.Empty;
            TxtSoyisim.Text = string.Empty;
            Cinsiyet.Text = string.Empty;
            TxtKullaniciAdi.Text = string.Empty;
            TxtSifre.Text = string.Empty;

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}