using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class graficoVentas : Form
    {
        public graficoVentas()
        {
            InitializeComponent();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {
            string [] series = {"enero", "Martes", "Miercoles" };
            int[] ventas = {100,27,50 };

            chart1.Titles.Add("Prueba");
            for (int i=0; i<series.Length;i++ )
            {
                //Titulos
                Series serie = chart1.Series.Add(series[i]);
                //Cantidades
                serie.Label = ventas[i].ToString();
                serie.Points.Add(ventas[i]);
            }

            

        }
    }
}
