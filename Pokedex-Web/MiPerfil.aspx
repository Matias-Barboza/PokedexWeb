<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="Pokedex_Web.MiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <h2>Mi perfil</h2>
            <div class="col-5">
                <div class="col-8 mb-3">
                    <asp:Label Text="Email" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="EmailTextBox" Enabled="false"/>
                </div>
                <div class="col-8 mb-3">
                    <asp:Label Text="Nombre" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="NombreTextBox" />
                </div>
                <div class="col-8 mb-3">
                    <asp:Label Text="Apellido" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="ApellidoTextBox" />
                </div>
                <div class="col-8 mb-3">
                    <asp:Label Text="Fecha de nacimiento" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="FechaNacimientoTextBox" />
                </div>
            </div>
            <div class="col-5">
                <div class="col-8 mb-3">
                    <asp:Label Text="Imagen" runat="server" CssClass="form-label" />
                    <input type="file" id="ImagenTxt" runat="server" class="form-control" accept=".jpg, .png"/>
                </div>
                <div class="col-8 mb-3">
                    <asp:Image ImageUrl="https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-4.png" runat="server" CssClass="img-fluid" ID="ImagenPerfilNuevo"/>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-5">
                <asp:Button Text="Guardar" runat="server" CssClass="btn btn-primary" ID="GuardarButton" OnClick="GuardarButton_Click"/>
                <a href="Default.aspx">Regresar al inicio</a>
            </div>
        </div>
    </div>

</asp:Content>
