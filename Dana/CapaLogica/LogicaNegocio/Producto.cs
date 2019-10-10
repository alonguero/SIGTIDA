using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dana.CapaLogica.LogicaNegocio
{
    public class Producto
    {
        #region Atributos
        protected int id_Producto;
        protected string nombre_Producto;
        protected string categoria_Producto;
        protected string genero_Producto;
        protected string edad_Producto;
        protected double precio_Producto;
        #endregion

        #region Constructores

        public Producto(string Pnombre_Producto, string Pcategoria_Producto, string Pgenero_Producto,
                        string Pedad_Producto, double Pprecio_Producto)
        {
            id_Producto = 0;
            nombre_Producto = Pnombre_Producto;
            categoria_Producto = Pcategoria_Producto;
            genero_Producto = Pgenero_Producto;
            edad_Producto = Pedad_Producto;
            precio_Producto = Pprecio_Producto;
        }

        public Producto(int Pid_Producto, string Pnombre_Producto, string Pcategoria_Producto, string Pgenero_Producto,
                        string Pedad_Producto, double Pprecio_Producto)
        {
            id_Producto = Pid_Producto;
            nombre_Producto = Pnombre_Producto;
            categoria_Producto = Pcategoria_Producto;
            genero_Producto = Pgenero_Producto;
            edad_Producto = Pedad_Producto;
            precio_Producto = Pprecio_Producto;
        }
        #endregion

        #region Get´s y Set´s
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
        public string Nombre_Producto { get => nombre_Producto; set => nombre_Producto = value; }
        public string Categoria_Producto { get => categoria_Producto; set => categoria_Producto = value; }
        public string Genero_Producto { get => genero_Producto; set => genero_Producto = value; }
        public string Edad_Producto { get => edad_Producto; set => edad_Producto = value; }
        public double Precio_Producto { get => precio_Producto; set => precio_Producto = value; }
        #endregion
    }
}
