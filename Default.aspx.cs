using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Musteri.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SatislarEntities ef = new SatislarEntities();

            GridView1.DataSource = ef.Musteri.ToList();
            GridView1.DataBind();
        }
    }
}