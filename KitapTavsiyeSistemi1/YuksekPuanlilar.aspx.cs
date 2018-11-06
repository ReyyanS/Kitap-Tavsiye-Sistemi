using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace KitapTavsiyeSistemi1
{
    public partial class YuksekPuanlilar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            YuksekPuanliKitaplar();
        }
        void YuksekPuanliKitaplar()
        {
            DBIslemleri islem = new DBIslemleri();
            DataSet data = islem.YuksekPuanlilar();
            DataList1.DataSource = data;
            DataList1.DataBind();
        }
    }
}