<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="gridview.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="design.css" rel="stylesheet" />
    <script type="text/javascript">
	window.history.forward();
	function noBack() { window.history.forward(); }
</script>
</head>
<body onload="noBack();" 
	onpageshow="if (event.persisted) noBack();" onunload="">
    <form id="form1" runat="server">
   

         <div class="header">
           <asp:Button ID="Account" runat="server" Text="Account" PostBackUrl="~/GetData.aspx" CssClass="ac" />
           <asp:Button ID="UserInfo" runat="server" Text="User" PostBackUrl="~/User.aspx" CssClass="ui" />
              <asp:Button ID="CreateAccount" runat="server" Text="CreateAccount" PostBackUrl="~/insert.aspx" CssClass="in" />
       </div>

    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="srcbtn" runat ="server" Text="Search" OnClick="srcbtn_Click" />
        
    </div>
        <div>
            <asp:Label ID="text" runat="server" Text="Search Result"></asp:Label>
        </div>

        <div>
            <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        </div>

          <div>
            <asp:Label ID="Label1" runat="server" Text="All User Details"></asp:Label>
        </div>

                <div>
            <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        </div>
        
    </form>
</body>
</html>
