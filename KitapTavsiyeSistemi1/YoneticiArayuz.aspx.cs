using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
   
    public partial class YoneticiArayuz : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut2 = new SqlCommand("Select * From Kitaplar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "KitapAdi";
            DropDownList1.DataValueField = "KitapID";

            DropDownList1.DataSource = dr2;
            DropDownList1.DataBind();

            bool giris = Convert.ToBoolean(Session["giris"]);
            if (giris == false)
                Response.Redirect("YoneticiGiris.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kitaplar (KitapAdi,KitapYazari,KitapYayinevi,KitapTanitimi,KitapResim) values (@t1,@t2,@t3,@t4,@t5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@t1",TxTKitapAd.Text);
            komut.Parameters.AddWithValue("@t2", TxtYazar.Text);
            komut.Parameters.AddWithValue("@t3", TxtYayinevi.Text);
            komut.Parameters.AddWithValue("@t4", TxtTanitim.Text);
            komut.Parameters.AddWithValue("@t5", UploadResim.FileName);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("Kitap Eklendi");
            TxTKitapAd.Text = string.Empty;
            TxtYazar.Text = string.Empty;
            TxtYayinevi.Text = string.Empty;
            TxtTanitim.Text = string.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut = new SqlCommand("delete from Kitaplar where KitapAdi="+TextBoxSil.Text, bgl.baglanti());
            komut.ExecuteNonQuery();


        }
    }
}