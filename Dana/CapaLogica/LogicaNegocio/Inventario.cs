using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dana.CapaLogica.LogicaNegocio
{
    public class Inventario
    {
        #region Atributos
        protected int id_Producto;
        protected int cantidad_Producto;
        #endregion

        #region Constructores

        public Inventario(int Pcantidad_Producto)
        {
            id_Producto = 0;
            cantidad_Producto = Pcantidad_Producto;
        }

        public Inventario(int Pid_Producto, int Pcantidad_Producto)
        {
            id_Producto = Pid_Producto;
            cantidad_Producto = Pcantidad_Producto;
        }
        #endregion

        #region Get´s y Set´s
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Cantidad_Producto { get => cantidad_Producto; set => cantidad_Producto = value; }
        #endregion
    }
}
