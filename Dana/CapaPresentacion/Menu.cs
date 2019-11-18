using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMenuCompras_Click(object sender, EventArgs e)
        {
            Compras laCompra = new Compras();
            laCompra.Show();
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            Ventas laVenta = new Ventas();
            laVenta.Show();
        }

        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            Productos elProducto = new Productos();
            elProducto.Show();
        }

        private void btnMenuInventario_Click(object sender, EventArgs e)
        {
            Inventario elInventario = new Inventario();
            elInventario.Show();
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            Clientes elCliente = new Clientes();
            elCliente.Show();
        }
    }
}
