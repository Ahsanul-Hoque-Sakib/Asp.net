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
    public partial class LogIn : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlog_Click(object sender,EventArgs e)
        {
            try
            {
                con.Open();
                string checkuser = @"SELECT  COUNT(*)
      [UserName]
      
  FROM [DonateBlood].[dbo].[User] where UserName='"+unlog.Text+"'";
              //  string  = "select count(*) from User where UserName='" + unlog.Text + "'";
                SqlCommand cmd = new SqlCommand(checkuser, con);
                int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                if (temp == 1)
                {
                    con.Open();
                    string checkpass = @"SELECT 
      [Password]
  FROM [dbo].[User] where UserName='"+unlog.Text+"'";
                    //string checkpass = "select Password from User where UserName='" + unlog.Text + "'";
                    SqlCommand passcmd = new SqlCommand(checkpass, con);
                    string password = passcmd.ExecuteScalar().ToString().Replace(" ","");
                    if (password == passlog.Text)
                    {
                        
                        //Response.Write("password is correct");
                        
                        Response.Redirect("Profile.aspx");
                        
                    }
                    else
                    {
                        Response.Write("password is incorrect");
                    }
                }
                else
                {
                    Response.Write("username is incorrect");
                }

            }
            catch(Exception ex)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", ex.ToString());
            }


        }
    }
}