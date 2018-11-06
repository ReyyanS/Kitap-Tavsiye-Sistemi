using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace KitapTavsiyeSistemi1
{
    public partial class Kullaniciara : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string kelime = TextBox1.Text;
            DataList1.DataSource = bgl.KullaniciArama(kelime);
            DataList1.DataBind();
        }
    }
}