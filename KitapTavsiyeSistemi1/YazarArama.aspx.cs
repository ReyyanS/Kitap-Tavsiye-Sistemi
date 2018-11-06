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
    public partial class YazarArama : System.Web.UI.Page
    {
        DBIslemleri bgl = new DBIslemleri();

        protected void Page_Load(object sender, EventArgs e)
        {
  
           
     }

        protected void Ara_Click(object sender, EventArgs e)
        {
            string kelime = TxtAra.Text;
            DataList1.DataSource = bgl.YazarArama(kelime);
            DataList1.DataBind();
        }
    }
}