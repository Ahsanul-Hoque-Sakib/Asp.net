<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="gridview.insert" %>

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
    <asp:TextBox ID="TextBox1" runat="server" placeholder="AccNo"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Acc_Type" DataValueField="Acc_Type">

        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BankManagementConnectionString %>" SelectCommand="SELECT [Acc_Type] FROM [AccountType]"></asp:SqlDataSource>

        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="BranchName" DataValueField="BranchName">

        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BankManagementConnectionString %>" SelectCommand="SELECT [BranchName] FROM [Branch]"></asp:SqlDataSource>

        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="AccID" DataValueField="AccID">

        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BankManagementConnectionString %>" SelectCommand="SELECT [AccID] FROM [UserInfo]"></asp:SqlDataSource>

        <asp:Button ID="submit" runat ="server" Text="Submit" OnClick="submit_Click1" />
    </div>
    </form>
</body>
</html>
