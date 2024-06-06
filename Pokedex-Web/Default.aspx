<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pokedex_Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="col-2"></div>
        <div class="col-8">
            <div class="row">

                <asp:Repeater ID="RepeaterCards" runat="server">
                    <ItemTemplate>
                        <div class="card" style="width: 18rem;">
                            <img src="<%#Eval("UrlImagen")%>" class="card-img-top" alt="">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre")%></h5>
                                <p class="card-text"><%#Eval("Descripcion") %></p>
                                <span class="btn btn-info"><%#Eval("Tipo.Descripcion")%></span>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>
