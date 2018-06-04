using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace sending_data_Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Legends.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
           
            
        }
        int count;
        string[] data= new string [100];
        private void button1_Click(object sender, EventArgs e)
        {
           textBox4.Text = "";
           textBox7.Text = "";
           int i = 0;
            //serialPort1.Write(Convert.ToString(0x02));//here we used the same method to convert to string to be sended using serial port
            //textBox3.Text=(Convert.ToString(0x02));
            //serialPort1.Write(textBox5.Text);
            char[] buffer_char = new char[textBox5.TextLength];
            byte [] buffer = new byte [textBox5.TextLength];
            //descomposicion del string en textbox5
            buffer_char = textBox5.Text.ToCharArray();

            /*for (i = 0; i < textBox5.TextLength; i++) {
                buffer[i] = (byte)buffer_char[i];
            }*/

                for (i = 0; i < textBox5.TextLength; i++)
                {

                    serialPort1.Write(buffer_char, i, 1);
                    Thread.Sleep(5);
                                       
                }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = textBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(textBox2.Text);

        }
        string rs;
        int j;
       
       
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            
            try
            {
             
                rs = serialPort1.ReadExisting();  
                this.Invoke(new EventHandler(type));

            }
            catch (System.TimeoutException) { }
        }
        void type(object s,EventArgs e)
        {
            
            
            textBox4.Text += rs.ToString();// the method should view that is being receive by the serial port
            textBox7.Text = Convert.ToString(textBox4.TextLength/2);
            chart1.Series[0].Points.AddY(rs);
            count++;
            if (count == 10)
            {
                for (j = 0; j < 100; j++)
                {
                    data[j] = Convert.ToString(j);
                }
                Form3 frm3 = new Form3(data);
                frm3.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            //start timer to count
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

      
     

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox5.TextLength.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //string[] datos = new string[100];
            //int i;
            //for (i = 0; i < 100; i++)
            //{
            //    datos[i] =Convert.ToString(i);
            //}
            //Form3 frm3 = new Form3(rs);
            //frm3.Show();
            
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
