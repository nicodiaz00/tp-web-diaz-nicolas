<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocumentoForm.aspx.cs" Inherits="Presentacion.DocumentoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="contenedorDocumento">
                <p>Ingresa Documento</p>
                <asp:TextBox runat="server" ID="txtDocumento" CssClass="form-control" ></asp:TextBox>
                <asp:Button  runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" Text="Ingresa"/>
            </div>
            
        </div>
    </div>
</asp:Content>
