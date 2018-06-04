using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace InterfazVisual_PIC
{
    public partial class ADC : Form
    {

        #region CREACION DE VARIABLES
        private Graphics g;
        private int[,] Linea = new int[3000, 2];
        private int[] contPunto = new int[2];
        private int nPuntos = 50;
        private int ancho, alto;
        private int[] activo = new int[2];
        string msg;

        private string data = "";
        string data1 = "0";
        string data2 = "0";
        private int j = 0;
        private string cmd;
        int cmd_num;
        int flag_cmd = 0;
        int flag_punto = 0;
        int estado_conexion = 0;
        int valor = 0;
        string Txtmp="";

        #endregion
     public ADC()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
            Timer.Enabled = true;
            g = PBx_Monitor.CreateGraphics();
            contPunto[0] = 0;
            contPunto[1] = 0;
            activo[0] = 1;
            activo[1] = 1;
            ancho = PBx_Monitor.Width;
            alto = PBx_Monitor.Height;
            PBx_Monitor.Image = null;


            BtnEjecutar.Enabled = false;
            BtnDetener.Enabled = false;

        }

        private void btn_conexion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (estado_conexion == 0)
            {

                if (!PuertoSerial.IsOpen)
                {
                    PuertoSerial.PortName = PuertoList.Text;
                }
                PuertoSerial.Close();
                PuertoSerial.Open();


                if (!PuertoSerial.IsOpen)
                {
                    MessageBox.Show("No hay un puerto abierto.", "Error de conexion.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PuertoSerial.Write("#");//prende led D6
                    MessageBox.Show("Puerto" + PuertoList.Text + "Conectado con exito", "Exito en la conexion.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado_conexion = 1;
                    L_conexion.Text = "Desconectar";
                    BtnEjecutar.Enabled = true;
                    BtnDetener.Enabled = true;
                    // btn_enviar.Enabled = true;
                }
            }
            else
            {
                //PuertoSerial.Close();
                PuertoSerial.Write("#");//desconexion
                PuertoSerial.Close();
                if (PuertoSerial.IsOpen)
                {
                    MessageBox.Show("No se ha podido desconectar.", "Error en desconexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    MessageBox.Show("Puerto " + PuertoList.Text + " desconectado con exito.", "Exito en la desconexión.",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado_conexion = 0;
                    L_conexion.Text = "Conectar";
                    BtnEjecutar.Enabled = false;
                    BtnDetener.Enabled = false;
                    //btn_conexion.Enabled = false;

                }
            }
        }

        private void btn_limpiar_DoubleClick(object sender, EventArgs e)
        {
            RTBx_Terminal.Text = "";
        }

         
        private void EnviarComando(string Enviardato)
        {
            int tam_s = 0;
            string temp_char;
            tam_s = Enviardato.Length;
            if (tam_s != 0)
            {
                this.RTBx_Terminal.AppendText("->");
                for (int i = 1; i < tam_s; i++)
                {
                    while (data2 != "@")
                    { 
                        // Thread.Sleep(5);
                    }
                    //El envio se da de izquierda a derecha
                    if (data2 == "@")
                    {
                        data2 = "noconfirmapic";
                        temp_char = Enviardato.Remove(i);
                        temp_char = temp_char.Remove(0, i - 1);
                        PuertoSerial.Write(temp_char);
                        this.RTBx_Terminal.AppendText(temp_char);
                        //Thread.Sleep(150);

                    }

                }
                while (data2 != "@")
                {
                    // Thread.Sleep(5);
                }
                if (data2 == "@")
                {
                    temp_char = Enviardato.Remove(0, tam_s - 1);
                    PuertoSerial.Write(temp_char);
                    this.RTBx_Terminal.AppendText(temp_char);
                    this.RTBx_Terminal.AppendText("\n");
                }
            }
        }

        private void BtnDetener_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //msg = "400000*";
            this.RTBx_Terminal.AppendText("Deteniendo Calendario\n");
            //EnviarComando(msg);
            PuertoSerial.Write("X");//se hace una parada forzada que no usa el protocolo normal
            btn_conexion.Enabled = true;
        }

        private void PuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data1 = PuertoSerial.ReadExisting();
            if (data1 == "@")
            {
                data2 = data1;
            }
            else
            {
                data += data1;

            }


            if (data.EndsWith("*"))
            {
                data = data.Remove(data.Length - 1);
                this.Invoke(new EventHandler(ProcesarComando));

            }
        }
        private void ProcesarComando(object s, EventArgs e)
        {
            this.RTBx_Terminal.AppendText("<- " + data + "\n");
            //////////////////////////////////
            //char[] delimitadores = { '+' };
            // string[] palabras = data.Split(delimitadores);
            // j = 0;
            //  foreach (string s1 in palabras)
            //  {
            //      switch (j)
            //      {
            //         case 0:
            //             cmd = s1;
            //             break;
            //         case 1:
            //             cmd_num = Convert.ToInt16(s1);
            ///              break;
            //         case 2://Aun no se usa
            //             valor = Convert.ToInt16(s1);
            //            this.RTBx_Terminal.AppendText("<- valor analogico es: " + valor+"\n");
            //           this.RTBx_Terminal.AppendText("<- RPM: " + (((float)valor*5.0/255) * 963.28) + "\n");
            //           
            //            break;
            //    }
            //    j = j + 1;
            //}
            /////////////////////////////////////

            data = "";
            flag_cmd = 1;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (flag_cmd == 1)
            {

                switch (cmd)
                {
                    case "A":
                        AgregarPunto(valor, cmd_num);
                        flag_punto = 1;
                        break;
                    case "D":

                        break;
                }
                flag_cmd = 0;
            }
            if (flag_punto == 1)
            {
                ActualizarGrafica();
                flag_punto = 0;
            }
        }

        private void AgregarPunto(int valor, int linea)
        {
            if (contPunto[linea] == nPuntos)
            {
                for (int i = 0; i < nPuntos - 1; i++)
                {
                    Linea[i, linea] = Linea[i + 1, linea];
                }
                Linea[nPuntos - 1, linea] = valor;
            }
            else
            {
                Linea[contPunto[linea], linea] = valor;
                contPunto[linea]++;
            }
        }
        private void ActualizarGrafica()
        {
            g.Clear(PBx_Monitor.BackColor);     // Limpia la pantalla PBxMonitor

            if (activo[0] == 1)
            {
                GraficarPuntos(0);
            }
            if (activo[1] == 1)
            {
                GraficarPuntos(1);
            }
        }

        private void GraficarPuntos(int linea)
        {
            int incremento = ancho / nPuntos;
            if (contPunto[linea] > 1)
            {
                for (int i = 0; i < contPunto[linea] - 1; i++)
                {
                    g.DrawLine(Pens.Blue, (i * incremento), ((alto -50) - Linea[i, linea]/5), ((i + 1) * incremento), (alto -50) - Linea[i + 1, linea]/5);
                }
            }
        }

        private void BtnVerGraficas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contPunto[0] = 0;
            contPunto[1] = 0;
            ActualizarGrafica();
        }

        private void BtnEjecutar_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            msg = "300000*";
            this.RTBx_Terminal.AppendText("Ejecutando Calendario\n");
            EnviarComando(msg);
            btn_conexion.Enabled = false;
        }

        private void button_RPM_Click(object sender, EventArgs e)
        {
            msg = "";
            msg = msg + "5";
            Txtmp = Convert.ToString(textRPM.Text);
            while (Txtmp.Length < 5)//se le da formato de 4 numeros-------------------
            {
                Txtmp = "0" + Txtmp;
            }
            //this.RTBx_Terminal.AppendText("\ncase(2)+proceso+posicion:" + Txtmp);
            msg = msg + Txtmp;
            msg = msg + "*";
            textBox1.Text = msg;
            EnviarComando(msg);
            
        }
    }
}
