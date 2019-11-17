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
    public class ServicioCompra: servicio,  IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public ServicioCompra()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string IngresarCompra(Compra laCompra)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCompra");

            miComando.CommandText = "IngresarCompra";

            miComando.Parameters.Add("@id_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@id_Producto"].Value = laCompra.Id_Compra;

            miComando.Parameters.Add("@fecha_Compra", MySqlDbType.Date);
            miComando.Parameters["@fecha_Compra"].Value = laCompra.Fecha_Compra;

            miComando.Parameters.Add("@precio_Compra", MySqlDbType.Double);
            miComando.Parameters["@precio_Compra"].Value = laCompra.Precio_Compra;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Compra");

            return respuesta;
        }

        public string ModificarCompra(Compra laCompra)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCompra");

            miComando.CommandText = "ModificarCompra";

            miComando.Parameters.Add("@id_Compra", MySqlDbType.VarChar);
            miComando.Parameters["@id_Compra"].Value = laCompra.Id_Compra;

            miComando.Parameters.Add("@id_Producto", MySqlDbType.VarChar);
            miComando.Parameters["@id_Producto"].Value = laCompra.Id_Producto;

            miComando.Parameters.Add("@fecha_Compra", MySqlDbType.Date);
            miComando.Parameters["@fecha_Compra"].Value = laCompra.Fecha_Compra;

            miComando.Parameters.Add("@precio_Compra", MySqlDbType.Double);
            miComando.Parameters["@precio_Compra"].Value = laCompra.Precio_Compra;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor modificar Compra");

            return respuesta;
        }


        public DataSet ConsultarCompra(int id_Compra)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCompra");

            miComando.CommandText = "ConsultarCompra";

            miComando.Parameters.Add("@id_Compra", MySqlDbType.VarChar);
            miComando.Parameters["@id_Compra"].Value = id_Compra;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
    }
}
