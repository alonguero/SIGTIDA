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
        }

    }
}
