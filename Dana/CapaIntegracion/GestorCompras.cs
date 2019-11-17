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
    public class GestorCompras : servicio, IDisposable
    {

        private MySqlCommand miComando;
        private string respuesta;

        public GestorCompras()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarCompra(int Id_Producto, DateTime Fecha_Compra, double precio_Compra)
        {
            Compra nuevaCompra = new Compra(Id_Producto, Fecha_Compra, precio_Compra);

            using (ServicioCompra laCom = new ServicioCompra())
                return laCom.IngresarCompra(nuevaCompra);
        }

        public DataTable ListarCompra()
        {
            using (ServicioCompra comp = new ServicioCompra())
            {

                return comp.ListarCompra();


            }

        }

        



        // public string modificarVenta(int Id_Venta, int Id_Cliente, DateTime Fecha_Venta)
        // {
        //   Venta cambiaVenta = new Venta(Id_Venta, Id_Cliente, Fecha_Venta);

        // using (ServicioVenta laVenta = new ServicioVenta())
        //      return laVenta.modificarVenta(cambiaVenta);
        //}

    }
}
