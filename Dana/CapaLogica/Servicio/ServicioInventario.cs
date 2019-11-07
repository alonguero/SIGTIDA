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
    class ServicioInventario : servicio, IDisposable
    {
        MySqlCommand miComando;
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

            miComando.CommandText = "IngresarDetalle";

            miComando.Parameters.Add("@idP", MySqlDbType.Int32);
            miComando.Parameters["@idP"].Value = elInventario.Id_Producto;

            miComando.Parameters.Add("@cant", MySqlDbType.VarChar);
            miComando.Parameters["@cant"].Value = elInventario.Cantidad_Producto;




            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Cliente");

            return respuesta;
        }

    }
}
