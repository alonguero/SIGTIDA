using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dana.CapaConexion;
using Dana.CapaLogica.LogicaNegocio;
using MySql.Data.MySqlClient;

namespace Dana.CapaLogica.Servicio
{
    public class ServicioProducto: servicio, IDisposable
    {
        private MySqlCommand miComando;
        private string respuesta;

        public ServicioProducto()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresarProducto(Producto elProducto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorProducto");

            miComando.Parameters.Add("@nombre_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@nombre_Producto"].Value = elProducto.Nombre_Producto;

            miComando.Parameters.Add("@categoria_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@categoria_Producto"].Value = elProducto.Categoria_Producto;

            miComando.Parameters.Add("@genero_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@genero_Producto"].Value = elProducto.Genero_Producto;

            miComando.Parameters.Add("@edad_producto", MySqlDbType.VarChar);
            miComando.Parameters["@edad_Producto"].Value = elProducto.Edad_Producto;

            miComando.Parameters.Add("@precio_Producto", MySqlDbType.Double);
            miComando.Parameters["@precio_Producto"].Value = elProducto.Precio_Producto;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Producto");

            return respuesta;
        }

        public string modificarProducto(Producto elProducto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorProducto");

            miComando.Parameters.Add("@id_Producto", MySqlDbType.Int32);
            miComando.Parameters["@id_Producto"].Value = elProducto.Id_Producto;

            miComando.Parameters.Add("@nombre_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@nombre_Producto"].Value = elProducto.Nombre_Producto;

            miComando.Parameters.Add("@categoria_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@categoria_Producto"].Value = elProducto.Categoria_Producto;

            miComando.Parameters.Add("@genero_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@genero_Producto"].Value = elProducto.Genero_Producto;

            miComando.Parameters.Add("@edad_producto", MySqlDbType.VarChar);
            miComando.Parameters["@edad_Producto"].Value = elProducto.Edad_Producto;

            miComando.Parameters.Add("@precio_Producto", MySqlDbType.Double);
            miComando.Parameters["@precio_Producto"].Value = elProducto.Precio_Producto;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor modificar Producto");

            return respuesta;
        }

    }
}
