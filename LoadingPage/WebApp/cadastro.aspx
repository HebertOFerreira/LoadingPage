<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/SiteMaster.Master" CodeBehind="cadastro.aspx.cs" Inherits="LoadingPage.Cadastro" %>

<asp:Content ID="content" runat="server" ContentPlaceHolderID="pchConteudo">
    <form id="form1" runat="server">
        <asp:Label ID="lbl1" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbl2" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbl3" runat="server" Text="Senha: "></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:ImageButton ID="confirmar" ImageUrl="~/imagem/adicionar.png" runat="server" OnClick="confirmar_Click"/>
    </form>
    <!--End form --> 
</asp:Content>
