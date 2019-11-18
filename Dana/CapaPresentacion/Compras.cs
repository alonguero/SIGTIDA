using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dana.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            cargarGridCompra();
        }

        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargarGridCompra()
        {
            using (GestorCompras laCompra = new GestorCompras())
            {
                dgvCompra.DataSource = laCompra.ListarCompra();

                dgvCompra.Columns["fecha_Compra"].HeaderText = "Fecha";
            }
        }
    }
}
