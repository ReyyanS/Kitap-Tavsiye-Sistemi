using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace KitapTavsiyeSistemi1
{
    public partial class Mesajlar : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {    int id = Convert.ToInt32(Session["KullaniciId"]);
            DBIslemleri bgl = new DBIslemleri();
            SqlCommand komut = new SqlCommand("insert into dbo.[Mesajlar] (GonderenId,AliciId,Baslik,Mesaj) values(@gonderen,@alici,@baslik,@mesaj)",bgl.baglanti());
            
            
   
         
            SqlCommand komut2 = new SqlCommand("select AliciId from Mesajlar where like '%'+@aliciadi+'%' ");
           komut2.Parameters.AddWithValue("@aliciadi", TextBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(komut2);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            komut.Parameters.AddWithValue("@gonderen", id);
            komut.Parameters.AddWithValue("@alici", ds);
            komut.Parameters.AddWithValue("@baslik", TextBox2.Text);
            komut.Parameters.AddWithValue("@mesaj", TextBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Write("Mesajınız Gönderildi");
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;


        }
    }
}