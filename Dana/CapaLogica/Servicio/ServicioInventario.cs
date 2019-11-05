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
    public class ServicioInventario: servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public ServicioInventario()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresarInventario(Inventario elInventario)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorInventario");

            miComando.CommandText = "IngresarInventario";

            miComando.Parameters.Add("@cantidad_Produto", MySqlDbType.Int32);
            miComando.Parameters["@cantidad_Produto"].Value = elInventario.Cantidad_Producto;

            respuesta = this.ejecutarSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizadol correctamente la transaccion";
            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingresar Inventario");

            return respuesta;
        }

    }
}
