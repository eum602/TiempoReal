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
    public partial class Terminal : Form
    {
        #region DeclaracionDeVariables
        int estado_conexion = 0;
        private string data = "";
        int flag_cmd;
        string msg;
        string data1 = "0";//
        string data2 = "0";//

        //int flag2_conexion=0;
        #endregion
        public Terminal()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
            btn_enviar.Enabled = false;
        }

        private void btn_conexion_Click_MouseDoubleClick(object sender, MouseEventArgs e)
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
                    btn_enviar.Enabled = true;
                }
            }
            else
            {
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
                    btn_conexion.Enabled = false;

                }
            }
        }

        private void btn_enviar_DoubleClick(object sender, EventArgs e)
        {
            msg = Convert.ToString(TxBxComando.Text);
            msg = msg + "*";
            EnviarComando(msg);  
        }
        private void EnviarComando(string Enviardato) {
            int tam_s = 0;
            string temp_char;
            tam_s = Enviardato.Length;
            if (tam_s != 0)
            {
                this.RTbx_terminal.AppendText("->");
                for (int i = 1; i < tam_s; i++)
                {
                    while (data2 != "@")
                    {
                    }
                    if (data2 == "@")
                    {
                        data2 = "noconfirmapic";
                        temp_char = Enviardato.Remove(i);
                        temp_char = temp_char.Remove(0, i - 1);
                        PuertoSerial.Write(temp_char);
                        this.RTbx_terminal.AppendText(temp_char);
                        //Thread.Sleep(150);

                    }
                    while (data2 != "@")
                    {
                    }


                }
                if (data2 == "@") // el programa dificilmente entra en esta parte debido a que el SO no le envia
                //el mensaje @ que es la confirmacion, por lo que al no entrar no salta de linea por ende el siguiente
                //dato aparece al costado del dato anterior y no debajo como se ha programado en esta parte del codigo.
                //ESTO SE SOLUCIONO AGREGANDO UN THREAD.SLEEP EN LA LINEA DE ENVIO DE COMANDO
                //OTRA SOLUCION PODRIA SER CREAR UN WHILE DE ESPERA MIENTRAS LLEGA EL SIGUEINTE DATO.
                {
                    temp_char = Enviardato.Remove(0, tam_s - 1);
                    PuertoSerial.Write(temp_char);
                    this.RTbx_terminal.AppendText(temp_char);
                    this.RTbx_terminal.AppendText("\n");
                }
            }
        }

        private void PuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)        {
            data1 = PuertoSerial.ReadExisting();
            if (data1 == "@")
            {
                data2 = data1;
            }
            else
            {
                data += data1;

            }

            //data = data.ToString();
            if (data.EndsWith("*"))
            {
                data = data.Remove(data.Length - 1);
                this.Invoke(new EventHandler(ProcesarComando));
            }
        }
        private void ProcesarComando(object s, EventArgs e)
        {
            this.RTbx_terminal.AppendText("<-" + data + "\n");
            data = "";
            flag_cmd = 1;

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Procesos form3 = new Procesos();
            form3.Show();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Administrador form4 = new Administrador();
            form4.Show();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            TxBxComando.Text = "";
            RTbx_terminal.Text = "";
        }

        private void CalendarioClick_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Calendario form5 = new Calendario();
            form5.Show();
        }
    }
}
