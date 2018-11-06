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
    public partial class WebForm2 : System.Web.UI.Page
    {
       
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {    int id = Convert.ToInt32(Session["KullaniciId"]);
            bool giris = Convert.ToBoolean(Session["giris"]);
            if (giris == false)

                Response.Redirect("KullaniciGiris.aspx");
            kullanici(id);


        }

        void kullanici(int id)
        {
            DBIslemleri islem = new DBIslemleri();
            DataSet ds2 = new DataSet();
            ds2 = islem.KullaniciTavsiye(id);
            //DataListKullanici.DataSource = ds2.Tables[0];
            //DataListKullanici.DataBind();
            GridView1.DataSource = ds2.Tables[0];
            GridView1.DataBind();
           
        }
    }
}