<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Presentacion.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-2">

        </div>
        <div class="col-8">
            <asp:Label  runat="server" ID="lblError" Text=""></asp:Label>
            <asp:Button runat="server" ID="btnVolver" Text="VOLVER" CssClass="btn btn-primary" OnClick="btnVolver_Click"  />
        </div>

    </div>
</asp:Content>
