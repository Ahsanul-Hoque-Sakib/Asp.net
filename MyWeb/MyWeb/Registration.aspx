<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MyWeb.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Registration.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="main">
           
           
        <div class="imgcontainer">
    <img src="Properties/download.jpg" alt="Avatar" class="avatar"/>
            
  </div>

         <div>
             <div>
                 <label for="email"><b>Email</b></label>
                 <asp:TextBox ID="em" runat="server" placeholder="E-mail" type="email" required="required"></asp:TextBox>
             </div>
             <div>
                 <label for="uname"><b>UserName</b></label>
                 <asp:TextBox ID="un" runat="server" placeholder="Username"  type="text" required="required"></asp:TextBox>
             </div>
             <label for="pass"><b>Password</b></label>
             <asp:TextBox ID="pass" runat="server" placeholder="Password"  type="password" required="required" ></asp:TextBox>

             <asp:Button ID="btnregister" runat="server" Text="Register" CssClass="reg"  OnClick="btnsubmit_Click" Width="100%"></asp:Button>
         </div>


</div>
    </form>
</body>
</html>
