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
    public class GestorVentas: servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public GestorVentas()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarVenta(int Id_Cliente, DateTime Fecha_Venta)
        {
            Venta nuevaVenta = new Venta(Id_Cliente, Fecha_Venta);

            using (ServicioVenta laVenta = new ServicioVenta())
                return laVenta.ingresarVenta(nuevaVenta);
        }

    }
}
