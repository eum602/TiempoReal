using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sending_data_Serial
{
    public partial class Form3 : Form
    {
        public Form3(string[] data)
        {
            InitializeComponent();
            chart1.Legends.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            int i;
            for (i = 0; i < 100; i++)
            {

                chart1.Series[0].Points.AddY(data[i]);
            }
        }
        

    }
}
