using Dana.CapaIntegracion;
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
    public partial class prueba : Form
    {
        GestorCompras GC = new GestorCompras();

        public prueba()
        {
            InitializeComponent();
            cargarGridCompra();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
