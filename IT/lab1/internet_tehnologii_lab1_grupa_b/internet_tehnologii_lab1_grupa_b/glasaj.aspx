<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="glasaj.aspx.cs" Inherits="internet_tehnologii_lab1_grupa_b.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="m-4"><h1>Stranica za glasanje</h1></div>

    <div class="m-4">
        Professor: <asp:Label ID="wantedProfessor" runat="server" Text=""></asp:Label>
    </div>

    <div class="m-4">
        <asp:ListBox ID="lbSubjects" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbSubjects_SelectedIndexChanged" ></asp:ListBox>
        <asp:ListBox ID="lbCredits" runat="server"></asp:ListBox> <br />
        Subject: <asp:TextBox ID="Subject" runat="server"></asp:TextBox> <br />
        Credits: <asp:TextBox ID="Credit" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
    </div>

    <div>
        <asp:Button ID="Button3" runat="server" Text="Glasaj" OnClick="Button3_Click" /></div>
</asp:Content>
