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
    public partial class Profile : System.Web.UI.Page
    {
        int click = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
         

            if (Session["click"] != null)
            {
                con.Open();
                String thisuntxt = uname.Text;
                uname.Text = thisuntxt;
            SqlCommand cmd = new SqlCommand();
            string query = "Select *from BloodInformation where UserName='" +thisuntxt + "'";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
                con.Close();
            }
            else
            {
                String lbltext = Request.Form["unlog"];
                con.Open();
                uname.Text = lbltext;
            SqlCommand cmd = new SqlCommand();
            string query = "Select *from BloodInformation where UserName='" + lbltext + "'";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
                con.Close();
                Session["click"] =click;
                Response.Write("session created");
            }


        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            
            try
            {
                String lbltext = Request.Form["unlog"];
               // string bgroup = select1.Value;
                string phn = countrycode.Text + phone.Text;
                con.Open();
                string query = @"INSERT INTO [dbo].[BloodInformation]
           ([Institute]
           ,[BloodGroup]
           ,[PhoneNumber]
           ,[UserName])
     VALUES('" + oname.Text + "','" +select1.Value + "','" + phn + "','" + unp.Text + "')";
               
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                
                con.Close();

                
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Successful!!')");
                //uname.Text = lbltext;
                GridView1_Show();
                Session["click"] = (int)Session["click"]+1;

            }
            catch(Exception ex)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", ex.ToString());
            }

           

            
        }

        private void Page_Load()
        {
            throw new NotImplementedException();
        }

        protected void signout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }

 

        private void GridView1_Show()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string query = "Select *from BloodInformation where UserName='" + uname.Text + "'";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Update BloodInformation Set Institute='" + uponame.Text + "',BloodGroup='" + upbg.Text + "',PhoneNumber='" + upphone.Text + "' Where ID='" +Convert.ToInt32(id.Text) + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Successful!!')",true);
                GridView1_Show();
                Session["click"] = (int)Session["click"] + 1;

            }
            catch(Exception ex)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", ex.ToString());
            }
            
        }

        protected void search_Click(object sender, EventArgs e)
        {
            string query = "select Institute,BloodGroup,PhoneNumber from BloodInformation where ID='" + id.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (!recordfound)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('NOT FOUND!!')", true);
            }
            else
            {
                uponame.Text = dr["Institute"].ToString();
                upbg.Text = dr["BloodGroup"].ToString();
                upphone.Text = dr["PhoneNumber"].ToString();
            }
            con.Close();
        }
         
        protected void delete(object sender, EventArgs e)
        {
            string query = "Delete from BloodInformation Where UserName='" + uname.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Successful!!')", true);
            con.Close();
            GridView1_Show();
        }
    }
}