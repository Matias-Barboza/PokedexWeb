<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginTrainee.aspx.cs" Inherits="Pokedex_Web.LoginTrainee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <h2>Loguearse</h2>
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
                    <asp:Button Text="Ingresar" runat="server" CssClass="btn btn-primary" OnClick="IngresarButton_Click" ID="IngresarButton" />
                    <a href="Default.aspx">Cancelar</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
