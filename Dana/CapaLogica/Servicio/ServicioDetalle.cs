using Dana.CapaLogica.LogicaNegocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicio
{
    class ServicioDetalle
    {
        MySqlCommand miComando;

        public string ingresarDetalle(Detalle elDetalle)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("GestorCliente");

            miComando.CommandText = "IngresarCliente";

            miComando.Parameters.Add("@nombre_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@nombre_Cliente"].Value = elDetalle.Nombre_Cliente;

            miComando.Parameters.Add("@apellido:Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@apellido_Cliente"].Value = elDetalle.Nombre_Cliente;

            miComando.Parameters.Add("@telefono_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@telefono_Cliente"].Value = elDetalle.Telefono_Cliente;

            miComando.Parameters.Add("@email", MySqlDbType.VarChar);
            miComando.Parameters["@email"].Value = elDetalle.Email;

            miComando.Parameters.Add("@direccion_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@direccion_Cliente"].Value = elCliente.Direccion_Cliente;

            miComando.Parameters.Add("@estado_Cliente", MySqlDbType.VarChar);
            miComando.Parameters["@estado_Cliente"].Value = elCliente.Estado_Cliente;

            respuesta = this.ejecutarSentencia(miComando);
            if (respuesta == "")
                respuesta += "se ha realizado correctamente la transaccion";


            Console.WriteLine(respuesta);
            Console.WriteLine("Fin del gestor ingreso Cliente");

            return respuesta;
        }
    }
}
