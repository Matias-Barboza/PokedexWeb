<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoPokemons.aspx.cs" Inherits="Pokedex_Web.ListadoPokemons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="row">
            <h2>Listado de Pokemons</h2>

            <div class="col-8">
                <asp:GridView ID="GridViewPokemons" runat="server" CssClass="table table-striped" 
                    AutoGenerateColumns="false" DataKeyNames="Id"
                    OnSelectedIndexChanged="GridViewPokemons_SelectedIndexChanged"
                    OnPageIndexChanging="GridViewPokemons_PageIndexChanging"
                    AllowPaging="true" PageSize="5">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                        <asp:BoundField HeaderText="Número" DataField="Numero" />
                        <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
                        <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="Seleccionar" />
                    </Columns>
                </asp:GridView>

                <a href="FormularioPokemon.aspx" class="btn btn-primary">Agregar</a>
            </div>
        </div>
    </div>
</asp:Content>
