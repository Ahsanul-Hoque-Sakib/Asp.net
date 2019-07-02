using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace gridview
{

    public partial class insert : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BankManagementConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void submit_Click1(object sender, EventArgs e)
        {

            String text = TextBox1.Text;

            if (text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Input Text!!')", true);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Account(AccNo,Acc_Type,BranchName,AccID) values (@AccNo,@Acc_Type,@BranchName,@AccID)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@AccNo", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Acc_Type", DropDownList1.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@BranchName", DropDownList2.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@AccID", DropDownList3.SelectedItem.Text);
                    cmd.ExecuteNonQuery();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    con.Close();
                }
                catch (Exception b)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", b.ToString(), true);
                }
            }
        }


    }
}