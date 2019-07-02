<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetData.aspx.cs" Inherits="gridview.GetData" %>

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
<body  onload="noBack();" 
	onpageshow="if (event.persisted) noBack();" onunload="">
    <form id="form1" runat="server">
    <div class="header">
           <asp:Button ID="Account" runat="server" Text="Account" PostBackUrl="~/GetData.aspx" CssClass="ac" />
           <asp:Button ID="UserInfo" runat="server" Text="User" PostBackUrl="~/User.aspx" CssClass="ui" />
         <asp:Button ID="CreateAccount" runat="server" Text="CreateAccount" PostBackUrl="~/insert.aspx" CssClass="in" />
           
       </div>


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AccNo" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="AccNo" HeaderText="AccNo" ReadOnly="True" SortExpression="AccNo" />
                <asp:BoundField DataField="Acc_Type" HeaderText="Acc_Type" SortExpression="Acc_Type" />
                <asp:BoundField DataField="BranchName" HeaderText="BranchName" SortExpression="BranchName" />
                <asp:BoundField DataField="AccID" HeaderText="AccID" SortExpression="AccID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BankManagementConnectionString %>" DeleteCommand="DELETE FROM [Account] WHERE [AccNo] = @AccNo" InsertCommand="INSERT INTO [Account] ([AccNo], [Acc_Type], [BranchName], [AccID]) VALUES (@AccNo, @Acc_Type, @BranchName, @AccID)" SelectCommand="SELECT * FROM [Account]" UpdateCommand="UPDATE [Account] SET [Acc_Type] = @Acc_Type, [BranchName] = @BranchName, [AccID] = @AccID WHERE [AccNo] = @AccNo">
            <DeleteParameters>
                <asp:Parameter Name="AccNo" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="AccNo" Type="String" />
                <asp:Parameter Name="Acc_Type" Type="String" />
                <asp:Parameter Name="BranchName" Type="String" />
                <asp:Parameter Name="AccID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Acc_Type" Type="String" />
                <asp:Parameter Name="BranchName" Type="String" />
                <asp:Parameter Name="AccID" Type="Int32" />
                <asp:Parameter Name="AccNo" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
