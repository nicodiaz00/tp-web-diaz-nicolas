using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulo()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos accesoDatosArticulo = new AccesoDatos();
            List<Imagen> listaDeImagenes = new List<Imagenes>();
            ImagenNegocio ImagenNegocio = new ImagenNegocio();
            try
            {
                accesoDatosArticulo.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, C.descripcion as Categoria, M.descripcion as Marca, A.Precio  from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                accesoDatosArticulo.ejecutarLectura();
                while (accesoDatosArticulo.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatosArticulo.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatosArticulo.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatosArticulo.Lector["Nombre"];
                    articulo.DescripcionArticulo = (string)accesoDatosArticulo.Lector["Descripcion"];
                    articulo.Precio = Math.Round((decimal)accesoDatosArticulo.Lector["Precio"], 0);

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatosArticulo.Lector["IdMarca"];
                    articulo.Marca.DescripcionMarca = (string)accesoDatosArticulo.Lector["Marca"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatosArticulo.Lector["IdCategoria"];
                    articulo.Categoria.DescripcionCategoria = (string)accesoDatosArticulo.Lector["Categoria"];

                    articulo.Imagenes = ImagenNegocio.listarImagenesId(articulo.Id);

                    listaArticulos.Add(articulo);

                }
                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatosArticulo.cerrarConexion();
            }
        }
    }
}
