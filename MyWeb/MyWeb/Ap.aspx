<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ap.aspx.cs" Inherits="MyWeb.Ap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

      
        <asp:DataList ID="DataList1" runat="server" CssClass="row">

            <ItemTemplate>
               
                <div class="row-list">
                    <div class="col-8">
                        <h1><%#Eval("Institute") %></h1>
                        <h3><%#Eval("BloodGroup") %></h3>
                        <h3><%#Eval("PhoneNumber") %></h3>
                        
                    </div>

                </div>
            </ItemTemplate>

        </asp:DataList>

    
    </div>
    </form>
</body>
</html>
