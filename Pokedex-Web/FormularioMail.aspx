<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioMail.aspx.cs" Inherits="Pokedex_Web.FormularioMail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-8">
                <div class="mb-3">
                    <asp:Label Text="Destinatario" runat="server" CssClass="form-label"/>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DestinatarioTextBox"/>
                </div>
                <div class="mb-3">
                    <asp:Label Text="Asunto" runat="server" CssClass="form-label"/>
                    <asp:TextBox runat="server" CssClass="form-control" ID="AsuntoTextBox"/>
                </div>
                <div class="mb-3">
                    <asp:Label Text="Mensaje" runat="server" CssClass="form-label"/>
                    <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="MensajeTextBox"/>
                </div>
                <div>
                    <asp:Button Text="Enviar" runat="server" ID="EnviarMailButton" CssClass="btn btn-primary" OnClick="EnviarMailButton_Click"/>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
