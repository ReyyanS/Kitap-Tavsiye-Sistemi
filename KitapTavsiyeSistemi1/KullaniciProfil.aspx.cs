using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace KitapTavsiyeSistemi1
{
    public partial class KullaniciProfil : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(Session["KullaniciId"]);
            KullaniciBilgGetir(id);
            KullaniciKitapGetir(id);
            KullaniciPuanGetir(id);
            KullaniciIncelemeGetir(id);
            KullaniciAlintiGetir(id);
        }

        void KullaniciBilgGetir(int id)
        {
            DBIslemleri islem = new DBIslemleri();
            DataSet ds = new DataSet();
            ds = islem.KullaniciBilgileri(id);
            isimsoyisimlbl.Text = ds.Tables[0].Rows[0]["adsoyad"].ToString();
        }

        void KullaniciKitapGetir(int id)
        {
            DBIslemleri islem = new DBIslemleri();
            DataSet ds2 =new DataSet();
            ds2 = islem.KullaniciKitaplariGetir(id);
            DataListOkunanKitaplar.DataSource = ds2.Tables[0];
            DataListOkunanKitaplar.DataBind();
        }

        void KullaniciPuanGetir(int id)
        {

            DBIslemleri islem = new DBIslemleri();
            DataSet ds3 = new DataSet();
            ds3 = islem.KullaniciPuanGetir(id);
            GridView1.DataSource = ds3.Tables[0];
            GridView1.DataBind();
        }

        void KullaniciIncelemeGetir(int id)
        {
            DBIslemleri islem = new DBIslemleri();
            DataSet ds4 = new DataSet();
            ds4 = islem.KullaniciIncelemeGetir(id);
            GridViewInceleme.DataSource = ds4.Tables[0];
            GridViewInceleme.DataBind();
        }

        void KullaniciAlintiGetir(int id)
        {
            DBIslemleri islem = new DBIslemleri();
            DataSet ds5 = new DataSet();
            ds5 = islem.KullaniciAlintiGetir(id);
            GridViewAlinti.DataSource = ds5.Tables[0];
            GridViewAlinti.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}