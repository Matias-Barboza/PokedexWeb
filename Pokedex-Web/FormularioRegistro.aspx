<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioRegistro.aspx.cs" Inherits="Pokedex_Web.FormularioRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <h2>Creá tu perfil Trainee</h2>
            <div class="col-8">
                <div class="col-8 mb-3">
                    <asp:Label Text="Email" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="EmailTextBox" />
                </div>
                <div class="col-8 mb-3">
                    <asp:Label Text="Contraseña" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PassTextBox" />
                </div>
                <div class="col-8 mb-3 justify-content-center">
                    <asp:Button Text="Registrarse" runat="server" CssClass="btn btn-primary" ID="RegistrarseButton" OnClick="RegistrarseButton_Click"/>
                    <a href="Default.aspx">Cancelar</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
