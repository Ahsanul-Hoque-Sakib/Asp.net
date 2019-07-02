using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace BankManagement
{
    public partial class insert : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string query = "Select *from Account";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            String text = txtaccno.Text;
            
            if (text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' Please Input Text!!!')", true);
            }
            else
            {
                try
                {

                    //SqlCommand cmd = new SqlCommand("insert into Acc(ID,AccNo,AccName,BranchName) values('"+txtid.Text+ "','" + txtaccno.Text + "','" + txtaccname.Text + "','"+selectedtext+"' )", con);
                    SqlCommand cmd = new SqlCommand("insert into Account(AccNo,Acc_Type,BranchName,AccID) values (@AccNo,@Acc_Type,@BranchName,@AccID)",con);
                    con.Open();
                    
                    cmd.Parameters.AddWithValue("@AccNo", txtaccno.Text);
                    cmd.Parameters.AddWithValue("@Acc_Type", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@BranchName", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@AccID", TextBox3.Text);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    Response.Redirect("insert.aspx");
                    GridView1.DataBind();

                    con.Close();
                }
                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert()", true);
                }

            }


        }


        protected void Grid1RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (!IsPostBack)
            {
                Label l1 = GridView1.Rows[e.RowIndex].FindControl("AccNo") as Label;
                SqlCommand cmd = new SqlCommand("Delete from Account where AccNo=@AccNo",con);
                cmd.Parameters.AddWithValue("@AccNo", l1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("insert.aspx");
                GridView1.DataBind();
            }
                
        }



        protected void deletion(object sender, EventArgs e)
        {
            con.Open();
            
            string query = "Delete from Account where AccNo='"+dltbox.Text+"' ";
            SqlCommand cmd4 = new SqlCommand(query,con);
            int x= cmd4.ExecuteNonQuery();
            if (x > 0)
            {
                msg.Text = "Record Deleted";
            }
            else
            {
                msg.Text = "Record Not Deleted";
            }
            dltbox.Text = "";
            con.Close();
            GridView1.DataBind();
        }

        protected void updateclick(object sender, EventArgs e)
        {
            con.Open();

            //string query = "Update Account set Acc_Type = '"+DropDownList2.SelectedItem.Text+"', BranchName = '"+DropDownList1.SelectedItem.Text+"', AccID = '"+DropDownList3.SelectedItem.Text+"' where AccNo = '"+txtaccno+"'";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Account set Acc_Type = '" + TextBox1.Text + "', BranchName = '" + TextBox2.Text + "', AccID = '" + TextBox3.Text + "' where AccNo = '" + txtaccno.Text + "'";
            int x=cmd.ExecuteNonQuery();
            if (x > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Updated Successfully')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Not Updated ')", true);
            }
            
            con.Close();
            GridView1.DataBind();
        }

    }
}