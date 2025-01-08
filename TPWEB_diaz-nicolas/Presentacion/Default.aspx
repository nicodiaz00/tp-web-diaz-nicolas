<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Lista voucher</h1>
            
        </section>
        <section class="row">
            <div class="col-2">

            </div>
            
            <div class="col-8">
                <div class="mb-4">
                    <h2>Bienvenido a PROMO WEB</h2>
                    <p>Ingresa el codigo y participa</p>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtVoucher"></asp:TextBox>
                    
                </div>
                <div class="mb-4">
                    <asp:Button  runat="server" ID="btnCanjearCupon" OnClick="btnCanjearCupon_Click" Text="Canjear Cupon" CssClass="btn btn-primary"/>

                </div>
                

            </div>
            <div class="col-2">

            </div>
            
        </section>
    </main>

</asp:Content>
