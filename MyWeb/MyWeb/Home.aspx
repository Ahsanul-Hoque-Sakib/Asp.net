<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MyWeb.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="HomeStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
    <div>

        <div class="header">
            <asp:Button ID="LogIn" runat="server" Text="LogIn" CssClass="login" PostBackUrl="~/LogIn.aspx" />
            <asp:Button ID="Registration" runat="server" Text="Registration" CssClass="register" PostBackUrl="~/Registration.aspx" />

        </div>

        <div class ="header1">

            <div class ="row">
                            <div class="column1">
                <asp:Label ID="Label1" runat="server" Text="Donate" CssClass="donate"></asp:Label>
            </div>

                 <div class="column2">
                     <img src="Properties/download.jpg" class="ava" />
            </div>

                 <div class="column3">
                       <asp:Label ID="Label2" runat="server" Text="Blood" CssClass="blood"></asp:Label>
            </div>
            </div>
               
        </div>

        <div class="text">
            <p>Blood Groups:</p>
        </div>

        <div class ="header2">
            <div class="row">
            <asp:Button ID="AP" runat="server" Text="A+" CssClass="ap" OnClick="on_Click" />
            <asp:Button ID="AN" runat="server" Text="A-" CssClass="an" OnClick="on_Click" />
            <asp:Button ID="OP" runat="server" Text="O+" CssClass="op" OnClick="on_Click" />
            <asp:Button ID="ON" runat="server" Text="O-" CssClass="on" OnClick="on_Click" />
            </div>

            <div class="row">
            <asp:Button ID="BP" runat="server" Text="B+" CssClass="bp" OnClick="on_Click" />
            <asp:Button ID="BN" runat="server" Text="B-" CssClass="bn" OnClick="on_Click" />
            <asp:Button ID="ABP" runat="server" Text="AB+" CssClass="abp" OnClick="on_Click" />
            <asp:Button ID="ABN" runat="server" Text="AB-" CssClass="abn" OnClick="on_Click" />
            </div>

        </div>
        
    
    </div>
    </form>
</body>
</html>
