<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LAB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


  


    <asp:TextBox ID="idno" runat="server" placeholder="ID-No"></asp:TextBox>
        <asp:TextBox ID="Name" runat="server" placeholder="Name"></asp:TextBox>
        <asp:TextBox ID="Department" runat="server" placeholder="Department"></asp:TextBox>
        <asp:TextBox ID="Phn" runat="server" placeholder="Phone"></asp:TextBox>
        <asp:TextBox ID="gender" runat="server" placeholder="Gender"></asp:TextBox>
    <asp:TextBox ID="Age" runat="server" placeholder="Age"></asp:TextBox>

      <div>
<label>Date of Join:</label>

          <asp:TextBox ID="doj" runat="server" placeholder="Date Of Join"></asp:TextBox>

          <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

    </div>

    <div>
        <label>Date of Confirm:</label>
        <asp:TextBox ID="doc" runat ="server" placeholder="Date Of Confirm"></asp:TextBox>
        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
    </div>
    <div>

        <asp:TextBox ID="salary" runat="server" placeholder="Salary"></asp:TextBox>
        
    </div>
    <div>
        <label>Address</label>
        <asp:TextBox ID="address" runat="server" placeholder="Address"></asp:TextBox>

        <label>Reason</label>
        <asp:TextBox ID="reason" runat="server" placeholder="Reason"></asp:TextBox>
    </div>
    <asp:TextBox ID="email" runat="server" placeholder="Email"></asp:TextBox>
    <asp:TextBox ID="district" runat="server" placeholder="District"></asp:TextBox>
    <asp:TextBox ID="state" runat="server" placeholder="State"></asp:TextBox>

    <div>
        <asp:Button ID="save" runat="server" Text="Save" OnClick="save_Click" />
        <asp:Button ID="modify" runat="server" Text="Modify" PostBackUrl="~/WebForm2.aspx" />
        <asp:Button ID="back" runat="server" Text="Back" />
    </div>
  




</asp:Content>
