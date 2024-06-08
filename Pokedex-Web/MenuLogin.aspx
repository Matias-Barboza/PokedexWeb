<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuLogin.aspx.cs" Inherits="Pokedex_Web.MenuLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-8">
                <h2>Estas logueado!</h2>
            </div>
            <div class="col-8">
                <asp:Button Text="Formulario mail" runat="server" CssClass="btn btn-primary" OnClick="FormularioMailButton_Click" ID="FormularioMailButton"/>
            </div>
            <%if (Pokedex_Web.LoginHelper.UsuarioEsAdmin((PokedexCapaDominio.Usuario)Session["Usuario"]))
              {%>
                <div class="col-8">
                    <asp:Button Text="Menú Admin" runat="server" CssClass="btn btn-primary" OnClick="MenuAdminButton_Click" ID="MenuAdminButton"/>
                </div>
            <%}%>
        </div>
    </div>

</asp:Content>
