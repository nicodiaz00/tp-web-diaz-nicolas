<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Lista voucher</h1>
            
        </section>
        <section class="row">
            
            <div class="col-12">
                <div class="mb-4">
                    <label for="txtVoucher" class="form-label">Canjea el codigo</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtVoucher"></asp:TextBox>
                    
                </div>
                <div class="mb-4">
                    <asp:Button  runat="server" ID="btnCanjearCupon" OnClick="btnCanjearCupon_Click" Text="Canjear Cupon" CssClass="btn btn-primary"/>

                    <asp:Label runat="server" Text="" ID="lblMensaje"></asp:Label>
                    <asp:Label runat="server" Text="" ID="Label1"></asp:Label>
                    <asp:Label runat="server" Text="" ID="Label2"></asp:Label>
                    <asp:Label runat="server" Text="" ID="Label3"></asp:Label>
                    <asp:Label runat="server" Text="" ID="Label4"></asp:Label>

                    <asp:GridView runat="server" ID="dgvVoucher"></asp:GridView>
                </div>
                

            </div>
            
        </section>
    </main>

</asp:Content>
