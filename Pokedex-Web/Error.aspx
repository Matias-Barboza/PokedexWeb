<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Pokedex_Web.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="col-8">
                <h2>Ocurrió un error</h2>

                <asp:Label Text="" runat="server" CssClass="form-label" ID="MensajeErrorLabel"/>
            </div>
        </div>
    </div>

</asp:Content>
