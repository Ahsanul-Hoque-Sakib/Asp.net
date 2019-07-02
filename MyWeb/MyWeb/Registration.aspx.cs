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
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO [dbo].[User]
           ([Email]
           ,[UserName]
           ,[Password])
     VALUES('"+em.Text+"','"+un.Text+"','"+pass.Text+"')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");
                con.Close();

                em.Text = "";
                un.Text = "";
                pass.Text = "";
                Response.Redirect("LogIn.aspx");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", ex.ToString());
            }
        }

    }
}