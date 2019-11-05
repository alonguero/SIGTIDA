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
    public class ServicioVenta: servicio , IDisposable
    {
        private MySqlCommand miComando;
        private string respuesta;

        public ServicioVenta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresarVenta(Venta laVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorVenta");

            miComando.CommandText = "IngresarVenta";

            miComando.Parameters.Add("@id_Cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_Cliente"].Value = laVenta.Id_Cliente;

            miComando.Parameters.Add("@fecha_Venta", MySqlDbType.Date);
            miComando.Parameters["@fecha_Venta"].Value = laVenta.Fecha_Venta;

            respuesta = this.ejecutarSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizadol correctamente la transaccion";
            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingresar Venta");

            return respuesta;
        }

        public string modificarVenta(Venta laVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorVenta");

            miComando.CommandText = "ModificarVenta";

            miComando.Parameters.Add("@id_Venta", MySqlDbType.Int32);
            miComando.Parameters["@id_Venta"].Value = laVenta.Id_Venta;

            miComando.Parameters.Add("@id_Cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_Cliente"].Value = laVenta.Id_Cliente;

            miComando.Parameters.Add("@fecha_Venta", MySqlDbType.Date);
            miComando.Parameters["@fecha_Venta"].Value = laVenta.Fecha_Venta;

            respuesta = this.ejecutarSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizadol correctamente la transaccion";
            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor modificar Venta");

            return respuesta;
        }

    }
}
