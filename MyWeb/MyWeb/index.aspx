<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MyWeb.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:TextBox ID="tbx1" runat="server"></asp:TextBox>
        <asp:TextBox ID="tbx2" runat="server"></asp:TextBox>
         <asp:Button ID="send" runat="server" Text="Send" OnClick="Send_Click" />
        <asp:Button ID="Submit" runat="server" Text="Submit"  PostBackUrl="~/Second.aspx"/>
        
    </div>
    </form>
</body>
</html>
