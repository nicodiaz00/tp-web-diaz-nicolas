<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Presentacion.Articulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="row">
            <asp:Repeater runat="server" ID="repetidorArticulos">
                <ItemTemplate>

                    <div class="contenedorArticulo">
                        <div class="contenedorImg">
                            <img src="<%#Eval("Imagenes[0].UrlImagen") %>" class="imgArticulo" />
                        </div>
                        <div class="informacionArticulo">
                            <h5><%#Eval("Nombre") %></h5>
                            <p><%# Eval("Id") %></p>
                            <p><%# Eval("CodigoArticulo") %></p>
                            <p><%#Eval("DescripcionArticulo") %></p>
                            <p><%#Eval("Marca.DescripcionMarca") %></p>
                            <p><%#Eval("Categoria.DescripcionCategoria") %></p>
                        </div>
                        <div class="btnElegirArticulo">
                            <asp:Button Text="Seleccionar" CssClass="btn btn-primary mt-3 align-self-start" 
                            runat="server" ID="Button1" OnClick="btnSeleccionar_Click" 
                            CommandArgument='<%#Eval("Id") %>' CommandName="articuloID" />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    



</asp:Content>

