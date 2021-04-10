using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


namespace gráfico_dinámico
{
    class graficar
    {

        int x;

        public void p_x_set(int valor)
        {
            x = valor;

        }
        public void grafica(Chart ejemplo)
        {

            ejemplo.ChartAreas[0].Area3DStyle.Enable3D = true;
            

            if (ejemplo.Series[0].Points.Count > 11)
            {
                ejemplo.Series[0].Points.RemoveAt(0);
                ejemplo.Update();
              


            }
            ejemplo.Series[0].Points.AddXY(200, new Random().NextDouble());
            



        }

    }
}
