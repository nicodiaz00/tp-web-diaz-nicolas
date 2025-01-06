<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Presentacion.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">

            <asp:Repeater runat="server" ID="repetidorArticulos">

                <ItemTemplate>
                    
                        <div class="card" style="width: 18rem;">
                            <img src="<%#Eval("Imagenes[0].UrlImagen") %>" class="card-img-top" alt="Imagenes de articulos">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                <p><%# Eval("Id") %></p>
                                <p><%# Eval("CodigoArticulo") %></p>
                                <p><%#Eval("DescripcionArticulo") %></p>
                                <p><%#Eval("Marca.DescripcionMarca") %></p>
                                <p><%#Eval("Categoria.DescripcionCategoria") %></p>
                                <asp:Button  Text="Seleccionar" CssClass="btn btn-primary" runat="server" ID="btnSeleccionar" OnClick="btnSeleccionar_Click" CommandArgument='<%#Eval("Id") %>' CommandName="articuloID"/>
                            </div>
                        </div>
                    
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>



</asp:Content>

