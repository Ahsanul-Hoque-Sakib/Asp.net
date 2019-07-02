<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="MyWeb.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="ProfileStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="header">
            <asp:Button ID="signout" runat="server" Text="SignOut" CssClass="signout" OnClick="signout_Click" />
            <asp:Label ID="uname" runat="server" CssClass="uname"></asp:Label>
        </div>

    <div class="header1">
            <div class="column1" style="width:60%;float:left">
                <h1>list</h1>
                <div>
                    <asp:Button ID="deleteall" runat ="server" Text="Delete All" OnClick="delete"/>
                </div>
                <div class="grid">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="597px">
                   <Columns>
                       <asp:BoundField DataField="ID" HeaderText="ID" />
                       <asp:BoundField DataField="Institute" HeaderText="Institute" />
                       <asp:BoundField DataField="BloodGroup" HeaderText="BloodGroup" />
                       <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" />
                       <asp:BoundField DataField="UserName" HeaderText="UserName" />
                   </Columns>

                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />

                </asp:GridView>
                </div>
                
                
                
                
            </div>

            <div class="column2" style="width:39.5%;float:right">
                <div>
                                    <div class="hh">
                    
                    <label>Create Your Information</label>
                </div>
                
     <div class="container">
                          
    <label for="oname"><b>Name</b></label>
         <asp:TextBox ID="oname" runat="server" placeholder="Enter Organization/Person Name"></asp:TextBox>      
   
    <label for="bgroup"><b>BloodGroup</b></label>

         <div id="mainselection">
  <select id="select1" runat="server">
    <option>Select an Option</option>
    <option>A+</option>
    <option>A-</option>
      <option>O+</option>
      <option>O-</option>
      <option>B+</option>
      <option>B-</option>
      <option>AB+</option>
      <option>AB-</option>
  </select>
</div>

<div class="two-col">
    <div class="col1">
        <label for="countrycode"><b>Code</b></label>
        <asp:TextBox ID="countrycode" name="countrycode" runat="server" Text="+880"></asp:TextBox>
    </div>

    <div class="col2">
        <label for="phone"><b>Phone Number</b></label>
        <asp:TextBox ID="phone" name="phone" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:TextBox ID="unp" runat="server" placeholder="Enter Your UserName"></asp:TextBox>
    </div>
</div>
        
    
         <asp:Button ID="btnsub" runat="server" Text="Submit" CssClass="button" OnClick="btnsub_Click" />

  </div>
                </div>

                <div class="uu">
                    <asp:Label runat="server">Update Information</asp:Label>
                    <div>
                         <asp:TextBox ID="id" runat="server" placeholder="Enter Id From GridView"></asp:TextBox>
                        <asp:Button ID="search" runat="server" Text="Search" CssClass="srcbutton" OnClick="search_Click" />
                    </div>
                   <div class="container1">
                       <asp:TextBox ID="uponame" runat="server" ></asp:TextBox>
                    <asp:TextBox ID="upbg" runat="server"></asp:TextBox>
                    <asp:TextBox ID="upphone" runat="server"></asp:TextBox>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="upbutton" OnClick="btnUpdate_Click"/>
                   </div>
                    


                    
                </div>


        </div>

    
    </div>
    </form>
</body>
</html>
