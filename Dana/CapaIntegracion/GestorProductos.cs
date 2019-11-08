using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dana.CapaConexion;
using Dana.CapaLogica.LogicaNegocio;
using Dana.CapaLogica.Servicio;
using MySql.Data.MySqlClient;

namespace Dana.CapaIntegracion
{
    public class GestorProductos : servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public GestorProductos()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarProducto(string nombre_Producto, string categoria_Producto, string genero_Producto,
                                       string edad_Producto, double precio_Producto)
        {
            Producto nuevoProducto = new Producto(nombre_Producto, categoria_Producto, genero_Producto, edad_Producto, precio_Producto);

            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ingresarProducto(nuevoProducto);
        }

        public string ModificarProducto(int Id_Producto, string nombre_Producto, string categoria_Producto, string genero_Producto,
                                       string edad_Producto, double precio_Producto)
        {
            Producto cambiaProducto = new Producto(Id_Producto, nombre_Producto, categoria_Producto, genero_Producto, edad_Producto, precio_Producto);

            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.modificarProducto(cambiaProducto);
        }

    }
}
