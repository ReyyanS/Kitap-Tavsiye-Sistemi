using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapTavsiyeSistemi1
{
    public partial class KullaniciGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool giris = false;

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool sonuc = DBIslemleri.KullaniciKontrol(TextBox1.Text, TextBox2.Text);
            if (sonuc == true)
            {
                Session["giris"] = true;
                
                DBIslemleri islem = new DBIslemleri();
                int id = islem.IdAl(TextBox1.Text);
                Session["KullaniciId"] = id;
                Response.Redirect("KullanicilarArayuz.aspx?giris=true");
                giris = true;
            }
               
            else
            {
                Response.Write("Yanlış Kullanıcı Adı, Şifre");
            }
        }
    }
}