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
            string [] series = {"Lunes", "Martes", "Miercoles" };
            int[] puntos = {1,2,3 };

            chart1.Titles.Add("Prueba");
            for (int i=0; i<series.Length;i++ )
            {
                //Titulos
                Series serie = chart1.Series.Add(series[i]);
                //Cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

        }
    }
}
