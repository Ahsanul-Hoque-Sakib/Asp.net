<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="BankManagement.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="UserStyleSheet.css" rel="stylesheet" />

     <script type="text/javascript">
        window.history.forward();
        function noBack() {
            window.history.forward();
        }
    </script>
</head>
<body onload="noBack();" onpageshow="if (event.persisted) noBack();" onunload="">
    <form id="form1" runat="server">
    <div>

       <div class="header">
           <asp:Button ID="Account" runat="server" Text="Account" PostBackUrl="~/insert.aspx" CssClass="ac" />
           <asp:Button ID="UserInfo" runat="server" Text="User" PostBackUrl="~/User.aspx" CssClass="ui" />
       </div>

        <asp:TextBox ID="SearchBox" runat="server" placeholder="Enter ID"></asp:TextBox>


    
        <asp:Button ID="srcbtn" runat="server" Text="Search" OnClick="srcbtn_Click" />

          

          <label >
            <p>
                Search Result:
            </p>
        </label>


         <asp:GridView ID="GridViewUser" runat="server" ShowHeaderWhenEmpty="false"   EmptyDataText  ="No Record Found">
            
        </asp:GridView>

        <label >
            <p>
                All Info Of User
            </p>
        </label>

        <asp:GridView ID="GridViewUserAll" runat ="server" ShowHeaderWhenEmpty="true" EmptyDataText="No REcord Found">

        </asp:GridView>
    
    </div>
       
  
    </form>
</body>
</html>
