<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioPokemon.aspx.cs" Inherits="Pokedex_Web.FormularioPokemon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="container">
        <div class="col-8">
            <h2>Agregar Pokemon</h2>
        </div>
        <div class="row">
            <div class="col-4">
                <div class="mb-3">
                    <asp:Label for="" CssClass="form-label" runat="server">ID</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="IdTextBox"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label for="" CssClass="form-label" runat="server">Nombre</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="NombreTextBox"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label for="" CssClass="form-label" runat="server">Número</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="NumeroTextBox"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label for="" CssClass="form-label" runat="server">Tipo</asp:Label>
                    <asp:DropDownList ID="TipoDropDownList" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <asp:Label for="" CssClass="form-label" runat="server">Debilidad</asp:Label>
                    <asp:DropDownList ID="DebilidadDropDownList" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
            </div>

            <div class="col-4">
                <div class="mb-3">
                    <asp:Label for="" CssClass="form-label" runat="server">Descripcion</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="DescripcionTextBox"></asp:TextBox>
                </div>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div class="mb-3">
                            <asp:Label for="" CssClass="form-label" runat="server">URL imagen</asp:Label>
                            <asp:TextBox ID="UrlImagenTextBox" runat="server" CssClass="form-control" OnTextChanged="UrlImagenTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <asp:Image Width="70%" ID="ImagePokemon" ImageUrl="https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-4.png" runat="server"/>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <div class="col-8">
            <asp:Button ID="AgregarButton" runat="server" Text="Aceptar" CssClass="btn btn-primary" OnClick="AgregarButton_Click"/>
            <a href="ListadoPokemons.aspx">Cancelar</a>
        </div>
    </div>
</asp:Content>
