using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapTavsiyeSistemi1
{
    public partial class YoneticiGiris : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool giris = false;

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool sonuc = DBIslemleri.Kontrol(TextBox1.Text, TextBox2.Text);
            if (sonuc == false)
Response.Write("Yanlış Yönetici Adı, Şifre");
            else
                Session["giris"] = true;
            Session["YoneticiAdi"] = TextBox1.Text;
            Response.Redirect("YoneticiArayuz.aspx?giris=true");
            giris = true;
        }
    }
}