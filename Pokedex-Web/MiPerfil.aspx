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
                    <asp:RequiredFieldValidator ErrorMessage="El nombre es requerido." ControlToValidate="NombreTextBox" runat="server" CssClass="form-text"/>
                </div>
                <div class="col-8 mb-3">
                    <asp:Label Text="Apellido" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="ApellidoTextBox" />
                    <asp:RequiredFieldValidator ErrorMessage="El apellido es requerido." ControlToValidate="ApellidoTextBox" runat="server" CssClass="form-text"/>
                    <%-- Este validador como su tipo lo indica es para un integer, pero si trabaja con un Regex puede ser mas potente --%>
                    <%--<asp:RangeValidator ErrorMessage="Fuera de rango..." ControlToValidate="ApellidoTextBox" runat="server" CssClass="form-text"
                                        Type="Integer" MinimumValue="1" MaximumValue="256"/>--%>
                    <%--<asp:RegularExpressionValidator ErrorMessage="El campo solo puede contener números." ControlToValidate="ApellidoTextBox" runat="server" CssClass="form-text"
                                                    ValidationExpression="^[0-9]+$"/>--%>
                    <%--<asp:RegularExpressionValidator ErrorMessage="El campo debe tener formato de correo electronico." ControlToValidate="ApellidoTextBox"
                                                    runat="server" CssClass="form-text"
                                                    ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"/>--%>
                </div>
                <div class="col-8 mb-3">
                    <asp:Label Text="Fecha de nacimiento" runat="server" CssClass="form-label" />
                    <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="FechaNacimientoTextBox" />
                    <asp:RangeValidator ErrorMessage="La fecha debe estar entre 01/01/1900-Hoy" ControlToValidate="FechaNacimientoTextBox" runat="server"
                                        MinimumValue="1900/01/01" MaximumValue="2024/01/01" CssClass="form-text"/>
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
