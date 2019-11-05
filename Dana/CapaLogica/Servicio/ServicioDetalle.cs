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
   public class ServicioDetalle: servicio , IDisposable
    {
        MySqlCommand miComando;
        private string respuesta;

       

        public ServicioDetalle()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        public void Dispose()
        {

        }

        public string ingresarDetalle(Detalle elDetalle)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorDetalle");

            miComando.CommandText = "IngresarDetalle";

            miComando.Parameters.Add("@idP", MySqlDbType.Int32);
            miComando.Parameters["@idP"].Value = elDetalle.Id_Producto;

            miComando.Parameters.Add("@idV", MySqlDbType.VarChar);
            miComando.Parameters["@idV"].Value = elDetalle.Id_Venta;

            miComando.Parameters.Add("@cant", MySqlDbType.VarChar);
            miComando.Parameters["@cant"].Value = elDetalle.Cantidad_Producto;



            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Cliente");

            return respuesta;
        }

        public DataSet CargarDetalle(int id_Venta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorDetalle");

            miComando.CommandText = "cargarDetalleFactura";

            miComando.Parameters.Add("@id_Ve", MySqlDbType.Int32);
            miComando.Parameters["@id_Ve"].Value = id_Venta;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }


    }
}
