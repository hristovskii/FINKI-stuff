<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="najava.aspx.cs" Inherits="internet_tehnologii_lab1_grupa_b.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="m-4">
        <h1>Najava</h1>
    </div>

    <div class="m-4">
        Name: <asp:TextBox ID="Name" runat="server"></asp:TextBox><asp:Label ID="errName" runat="server" Text=""></asp:Label> <br />
        Password: <asp:TextBox ID="Password" runat="server"></asp:TextBox><asp:Label ID="errPassword" runat="server" Text=""></asp:Label> <br />
        Email: <asp:TextBox ID="Email" runat="server"></asp:TextBox><asp:Label ID="errEmail" runat="server" Text=""></asp:Label>
    </div>

    <div class="m-4">
        <asp:Button ID="Button" runat="server" Text="Najavi se" OnClick="Button1_Click" />
    </div>
</asp:Content>
