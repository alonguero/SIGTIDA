using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dana.CapaLogica.LogicaNegocio
{
    public class Compra
    {
        #region Atributos
        protected int id_Compra;
        protected int id_Producto;
        protected DateTime fecha_Compra;
        protected double precio_Compra;


        #endregion

        #region Constructores

        public Compra(int Pid_Producto, DateTime Pfecha_Compra, double Pprecio_Compra)
        {
            id_Compra = 0;
            id_Producto = Pid_Producto;
            fecha_Compra = Pfecha_Compra;
            precio_Compra = Pprecio_Compra;
        }

        public Compra(int Pid_Compra, int Pid_Producto, DateTime Pfecha_Compra, double Pprecio_Compra)
        {
            id_Compra = Pid_Compra;
            id_Producto = Pid_Producto;
            fecha_Compra = Pfecha_Compra;
            precio_Compra = Pprecio_Compra;
        }
        #endregion

        #region Get´s y Set´s
        public int Id_Compra { get => id_Compra; set => id_Compra = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public DateTime Fecha_Compra { get => fecha_Compra; set => fecha_Compra = value; }
        public double Precio_Compra { get => precio_Compra; set => precio_Compra = value; }
        #endregion
    }
}
