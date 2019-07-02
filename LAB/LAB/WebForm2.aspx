<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="LAB.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Idno" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Idno" HeaderText="Idno" ReadOnly="True" SortExpression="Idno" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
        <asp:BoundField DataField="Doj" HeaderText="Doj" SortExpression="Doj" />
        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
        <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
        <asp:BoundField DataField="Dtc" HeaderText="Dtc" SortExpression="Dtc" />
        <asp:BoundField DataField="Reason" HeaderText="Reason" SortExpression="Reason" />
        <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
        <asp:BoundField DataField="District" HeaderText="District" SortExpression="District" />
        <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labtestConnectionString %>" DeleteCommand="DELETE FROM [table] WHERE [Idno] = @Idno" InsertCommand="INSERT INTO [table] ([Idno], [Name], [Department], [Doj], [Gender], [Address], [Salary], [Dtc], [Reason], [Age], [Email], [Phone], [District], [State]) VALUES (@Idno, @Name, @Department, @Doj, @Gender, @Address, @Salary, @Dtc, @Reason, @Age, @Email, @Phone, @District, @State)" SelectCommand="SELECT * FROM [table]" UpdateCommand="UPDATE [table] SET [Name] = @Name, [Department] = @Department, [Doj] = @Doj, [Gender] = @Gender, [Address] = @Address, [Salary] = @Salary, [Dtc] = @Dtc, [Reason] = @Reason, [Age] = @Age, [Email] = @Email, [Phone] = @Phone, [District] = @District, [State] = @State WHERE [Idno] = @Idno">
    <DeleteParameters>
        <asp:Parameter Name="Idno" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Idno" Type="Int32" />
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Department" Type="String" />
        <asp:Parameter Name="Doj" Type="DateTime" />
        <asp:Parameter Name="Gender" Type="String" />
        <asp:Parameter Name="Address" Type="String" />
        <asp:Parameter Name="Salary" Type="Int32" />
        <asp:Parameter Name="Dtc" Type="DateTime" />
        <asp:Parameter Name="Reason" Type="String" />
        <asp:Parameter Name="Age" Type="Int32" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Phone" Type="String" />
        <asp:Parameter Name="District" Type="String" />
        <asp:Parameter Name="State" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Department" Type="String" />
        <asp:Parameter Name="Doj" Type="DateTime" />
        <asp:Parameter Name="Gender" Type="String" />
        <asp:Parameter Name="Address" Type="String" />
        <asp:Parameter Name="Salary" Type="Int32" />
        <asp:Parameter Name="Dtc" Type="DateTime" />
        <asp:Parameter Name="Reason" Type="String" />
        <asp:Parameter Name="Age" Type="Int32" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Phone" Type="String" />
        <asp:Parameter Name="District" Type="String" />
        <asp:Parameter Name="State" Type="String" />
        <asp:Parameter Name="Idno" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>




</asp:Content>
