using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace MyWeb
{
    public partial class Ap : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Convert.ToString(Session["transfer"]);
            con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select *from BloodInformation",con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //ListView1.DataSource = dt;
            //ListView1.DataBind();
            
            SqlCommand cmd = new SqlCommand("Select *from BloodInformation where BloodGroup='" + id + "'", con);
            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();
            con.Close();
        }
    }
}