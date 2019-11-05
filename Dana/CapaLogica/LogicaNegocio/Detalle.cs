using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dana.CapaLogica.LogicaNegocio
{
    public class Detalle
    {
        #region Atributos
        protected int id_Detalle;
        protected int id_Producto;
        protected int id_Venta;
        protected int cantidad_Producto;
        protected double precio_Detalle;
        #endregion

        #region Constructores

        public Detalle(int Pid_Producto, int Pid_Venta, int Pcantidad_Producto, double Pprecio_Detalle)
        {
            id_Detalle = 0;
            id_Producto = Pid_Producto;
            id_Venta = Pid_Venta;
            cantidad_Producto = Pcantidad_Producto;
            precio_Detalle = Pprecio_Detalle;
        }

        public Detalle(int Pid_Detalle, int Pid_Producto, int Pid_Venta, int Pcantidad_Producto, double Pprecio_Detalle)
        {
            id_Detalle = Pid_Detalle;
            id_Producto = Pid_Producto;
            id_Venta = Pid_Venta;
            cantidad_Producto = Pcantidad_Producto;
            precio_Detalle = Pprecio_Detalle;
        }

        #endregion

        #region Get´s y Set´
        public int Id_Detalle { get => id_Detalle; set => id_Detalle = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public int Id_Venta { get => id_Venta; set => id_Venta = value; }
        public int Cantidad_Producto { get => cantidad_Producto; set => cantidad_Producto = value; }
        public double Precio_Detalle { get => precio_Detalle; set => precio_Detalle = value; }
        #endregion
    }
}