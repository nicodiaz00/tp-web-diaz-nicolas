<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="Presentacion.Exito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-2">

        </div>
        <div class="col-8">
            <h3>Gracias por participar</h3>
            <asp:Button runat="server" ID="volverInicio" Text="Volver"  CssClass="btn btn-primary" OnClick="volverInicio_Click"/>
        </div>
        <div class="col-2">

        </div>
    </div>
</asp:Content>
