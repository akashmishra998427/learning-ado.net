using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class learning_sql_connections : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cs = "data source=.;database=Ducat_sql_practic; integrated security=SSPI ";
            //SqlConnection con = new SqlConnection(cs);
            //try
            //{

            //    SqlCommand cmd = new SqlCommand("select*from customer", con);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    GridView1.DataSource = rdr;
            //    GridView1.DataBind();
            //}
            //catch
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}

            //another way to do this

            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select*from customer", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }

        }
    }
}