<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoPokemons.aspx.cs" Inherits="Pokedex_Web.ListadoPokemons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server" />

    <div class="container">

        <div class="row">
            <div class="col-4">
                <asp:Label runat="server" CssClass="form-label">Filtro:</asp:Label>
                <asp:TextBox runat="server" CssClass="form-control" ID="FiltroTextBox" OnTextChanged="FiltroTextBox_TextChanged" AutoPostBack="true"></asp:TextBox>
            </div>
        </div>
        <div class="col-8">
            <asp:CheckBox runat="server" Text="Filtro avanzado" OnCheckedChanged="FiltroAvanzadoCheckBox_CheckedChanged" ID="FiltroAvanzadoCheckBox" AutoPostBack="true"/>
            <%if (FiltroAvanzadoCheckBox.Checked)
                {%>
                <div class="row">
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Campo" runat="server" CssClass="form-label" />
                            <asp:DropDownList runat="server" CssClass="form-select" ID="CampoDropDownList" OnSelectedIndexChanged="CampoDropDownList_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem Text="Seleccione una opción..." />
                                <asp:ListItem Text="Nombre" />
                                <asp:ListItem Text="Tipo" />
                                <asp:ListItem Text="Número" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Criterio" runat="server" CssClass="form-label" />
                            <asp:DropDownList runat="server" ID="CriterioDropDownList" CssClass="form-select">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Filtro" runat="server" CssClass="form-label" />
                            <asp:TextBox runat="server" CssClass="form-control" ID="FiltroAvanzadoTextBox"/>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="mb-3">
                            <asp:Label Text="Estado" runat="server" CssClass="form-label" />
                            <asp:DropDownList runat="server" CssClass="form-select" ID="EstadoDropDownList">
                                <asp:ListItem Text="Todos" />
                                <asp:ListItem Text="Inactivo" />
                                <asp:ListItem Text="Activo" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-3">
                            <div class="mb-3">
                                <asp:Button Text="Buscar" CssClass="btn btn-primary" runat="server" ID="BuscarButton" OnClick="BuscarButton_Click"/>
                            </div>
                        </div>
                    </div>
                </div>
            <%} %>
        </div>

        <div class="row">
            <h2>Listado de Pokemons</h2>

            <div class="col-8">
                <asp:UpdatePanel>
                    <ContentTemplate>
                        <asp:GridView ID="GridViewPokemons" runat="server" CssClass="table table-striped"
                            AutoGenerateColumns="false" DataKeyNames="Id"
                            OnSelectedIndexChanged="GridViewPokemons_SelectedIndexChanged"
                            OnPageIndexChanging="GridViewPokemons_PageIndexChanging"
                            AllowPaging="true" PageSize="5">
                            <Columns>
                                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                                <asp:BoundField HeaderText="Número" DataField="Numero" />
                                <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
                                <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
                                <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="Seleccionar" />
                            </Columns>
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <a href="FormularioPokemon.aspx" class="btn btn-primary">Agregar</a>
            </div>
        </div>
    </div>
</asp:Content>
