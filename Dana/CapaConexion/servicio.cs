using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dana.CapaConexion
{
    public class servicio
    {
        private MySqlConnection conexion;

        public servicio()
        {
            conexion = new MySqlConnection("server=192.168.1.199; uid=root;" + "pwd=eduar12345.; database=sigtida");
        }

        protected void abrirConexion()
        {
            conexion.Open();
        }

        protected void cerrarConexion()
        {
            conexion.Close();
        }

        protected string ejecutarSentencia(string sentencia)
        {
            MySqlCommand comando = new MySqlCommand(sentencia, conexion);

            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }

            this.cerrarConexion();
            return "";
        }

        protected string ejecutarSentencia(MySqlCommand miComando)
        {
            miComando.Connection = conexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandTimeout = 6000;

            try
            {
                this.abrirConexion();
                miComando.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }

            this.cerrarConexion();
            return "";
        }

        protected DataSet seleccionarConexiInformacion(MySqlCommand miComando)
        {
            DataSet miDataSet = new DataSet();
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();

            miComando.CommandTimeout = 2000;
            miComando.Connection = conexion;

            miComando.CommandType = CommandType.StoredProcedure;
            miSqlDataAdapter.SelectCommand = miComando;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }

        protected DataSet seleccionarInformacion(MySqlCommand miComando)
        {
            DataSet miDataSet = new DataSet();
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();

            miComando.CommandTimeout = 2000;
            miComando.Connection = conexion;

            miComando.CommandType = CommandType.StoredProcedure;
            miSqlDataAdapter.SelectCommand = miComando;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }

        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet miDataSet = new DataSet();
            MySqlCommand miSqlCommand = conexion.CreateCommand();

            miSqlCommand.CommandText = sentencia;
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();
            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }
    }
}
