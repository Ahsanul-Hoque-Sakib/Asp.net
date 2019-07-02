<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="MyWeb.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="LogInStyle.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
           
           
        <div class="imgcontainer">
    <img src="Properties/download.jpg" alt="Avatar" class="avatar"/>
            
  </div>


  <div class="container">
                
   <div>
                 <label for="uname"><b>UserName</b></label>
                 <asp:TextBox ID="unlog" runat="server" placeholder="Username"  type="text" required="required"></asp:TextBox>
             </div>
             <label for="pass"><b>Password</b></label>
             <asp:TextBox ID="passlog" runat="server" placeholder="Password"  type="password" required="required" ></asp:TextBox>

    
      <asp:Button ID="btnlogin" runat="server" Text="LogIn" CssClass="log"  OnClick="btnlog_Click" Width="100%" PostBackUrl="~/Profile.aspx"></asp:Button>
   
     
      <label>
      <input type="checkbox" checked="checked" name="remember" /> Remember me
    </label>
          
          
      <label onclick="window.location.href='/Registration.aspx'" >
       <b>Don't Registered Yet?</b>
      </label>    
         

  </div>

  <div class="container" style="background-color:#f1f1f1">
    <button type="button" class="cancelbtn">Cancel</button>
    <span class="psw">Forgot <a href="#">password?</a></span>
  </div>
</div>

    </form>
</body>
</html>
