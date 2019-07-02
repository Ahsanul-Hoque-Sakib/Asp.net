using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace LAB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["labtestConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            
            try
            {
                //string query= "INSERT INTO table  VALUES('"+idno.Text+"','"+Name.Text+"','"+Department.Text+"','"+doj.Text+"','"+gender.Text+"','"+address.Text+"','"+salary.Text+"','"+doc.Text+"','"+reason.Text+"','"+Age.Text+"','"+email.Text+"','"+Phn.Text+"','"+district.Text+"','"+state.Text+"')";

                string query = @"INSERT INTO [dbo].[table]
           ([Idno]
           ,[Name]
           ,[Department]
           ,[Doj]
           ,[Gender]
           ,[Address]
           ,[Salary]
           ,[Dtc]
           ,[Reason]
           ,[Age]
           ,[Email]
           ,[Phone]
           ,[District]
           ,[State])
     VALUES
               ('"+idno.Text+"','"+Name.Text+"','"+Department.Text+"','"+doj.Text+"','"+gender.Text+"','"+address.Text+"','"+salary.Text+"','"+doc.Text+"','"+reason.Text+"','"+Age.Text+"','"+email.Text+"','"+Phn.Text+"','"+district.Text+"','"+state.Text+"')";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Inserted Successfully!!!')", true);
                
                con.Close();


            }
            catch(Exception a){

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",a.ToString(), true);
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            doj.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            doc.Text = Calendar2.SelectedDate.ToShortDateString();
        }
    }
}