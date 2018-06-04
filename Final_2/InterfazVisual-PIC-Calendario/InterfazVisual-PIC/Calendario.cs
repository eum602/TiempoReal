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
    public partial class Calendario : Form
    {  
        #region DECLARACION DE VARIABLES
        int estado_conexion = 0;
        int[] DuracionProceso = { 1, 2, 1, 2, 3 };
        int[] PeriodoMuestreo = { 20, 20, 20, 15, 15 };
        int NumProcesos = 0;
        int[] ListaProcesos = { 4, 5, 6, 7, 8 };
        int Proceso,Duracion, Periodo;
        int[,] Procesos = new int[5, 4];
        int tmpProceso, tmpDuracion, tmpPeriodo;
        int MCM;
        int tam_calendario;
        int[] calendario = new int[20000];
        private string data = "";
        string data1 = "0";
        string data2 = "0";
        int flag_cmd;
        string msg;
        string TxMCM;
        string cmd, Txtmp;
        int flag_envio, cmd_num, pos_envio, proceso_envio;
        int j;
        int valor=0;
        #endregion
        public Calendario()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
        }


        private void Calendario_Load(object sender, EventArgs e)
        {
            Deshabilitar_TxBx_Duraciones();
            Deshabilitar_TxBx_Periodos();
            DefinirDuracionPedeterminada();
            DefinirPeriodoPredeterminado();
            NumProcesos = 0;
            Timer.Enabled = true;
            RTBx_Terminal.Text = "INICIO";
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
                    // btn_enviar.Enabled = true;
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
                    //btn_conexion.Enabled = false;

                }
            }
        }

        private void btn_limpiar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RTBx_Terminal.Text = "";
        }
        private void AddProceso(Int32 Proceso)
        {
            this.RTBx_Terminal.AppendText("Seleccionado Proceso " + Proceso + "\n");
            Procesos[NumProcesos, 0] = Proceso;
            Procesos[NumProcesos, 1] = Duracion;
            Procesos[NumProcesos, 2] = Periodo;
            Procesos[NumProcesos, 3] = 1;
        }
        private void Actualizar_CheckButton()
        {


            if (ChBx_1.Checked)
            {
                Proceso = ListaProcesos[0];
                if (TxBx_D1.Text != "" && TxBx_T1.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D1.Text);
                    Periodo = Int32.Parse(TxBx_T1.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }

            }
            if (ChBx_2.Checked)
            {
                Proceso = ListaProcesos[1];
                if (TxBx_D2.Text != "" && TxBx_T2.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D2.Text);
                    Periodo = Int32.Parse(TxBx_T2.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
            if (ChBx_3.Checked)
            {
                Proceso = ListaProcesos[2];
                if (TxBx_D3.Text != "" && TxBx_T3.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D3.Text);
                    Periodo = Int32.Parse(TxBx_T3.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
            if (ChBx_4.Checked)
            {
                Proceso = ListaProcesos[3];
                if (TxBx_D4.Text != "" && TxBx_T4.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D4.Text);
                    Periodo = Int32.Parse(TxBx_T4.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
            if (ChBx_5.Checked)
            {
                Proceso = ListaProcesos[4];
                if (TxBx_D5.Text != "" && TxBx_T5.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D5.Text);
                    Periodo = Int32.Parse(TxBx_T5.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
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
        #region HABILITAR DESABILITAR
        private void Deshabilitar_TxBx_Duraciones()
        {
            TxBx_D1.Enabled = false;
            TxBx_D2.Enabled = false;
            TxBx_D3.Enabled = false;
            TxBx_D4.Enabled = false;
            TxBx_D5.Enabled = false;
        }
      
        private void Habilitar_TxBx_Duraciones()
        {
            TxBx_D1.Enabled = true;
            TxBx_D2.Enabled = true;
            TxBx_D3.Enabled = true;
            TxBx_D4.Enabled = true;
            TxBx_D5.Enabled = true;
        }

        private void Deshabilitar_TxBx_Periodos()
        {
            TxBx_T1.Enabled = false;
            TxBx_T2.Enabled = false;
            TxBx_T3.Enabled = false;
            TxBx_T4.Enabled = false;
            TxBx_T5.Enabled = false;
        }

        private void Habilitar_TxBx_Periodos()
        {
            TxBx_T1.Enabled = true;
            TxBx_T2.Enabled = true;
            TxBx_T3.Enabled = true;
            TxBx_T4.Enabled = true;
            TxBx_T5.Enabled = true;
        }

        #endregion
        #region VALORES PREDETERMINADOS
        private void DefinirDuracionPedeterminada()
        {
            TxBx_D1.Text = Convert.ToString(DuracionProceso[0]);
            TxBx_D2.Text = Convert.ToString(DuracionProceso[1]);
            TxBx_D3.Text = Convert.ToString(DuracionProceso[2]);
            TxBx_D4.Text = Convert.ToString(DuracionProceso[3]);
            TxBx_D5.Text = Convert.ToString(DuracionProceso[4]);
        }
        private void DefinirPeriodoPredeterminado()
        {
            TxBx_T1.Text = Convert.ToString(PeriodoMuestreo[0]);
            TxBx_T2.Text = Convert.ToString(PeriodoMuestreo[1]);
            TxBx_T3.Text = Convert.ToString(PeriodoMuestreo[2]);
            TxBx_T4.Text = Convert.ToString(PeriodoMuestreo[3]);
            TxBx_T5.Text = Convert.ToString(PeriodoMuestreo[4]);
        }
        #endregion
        #region MENSAJES DE ERROR
        private void ErrorCasilleroVacioProceso(int Proceso)
        {
            MessageBox.Show(this, "Error 101 / Casillero Vacio del Proceso " + Proceso + "\n No se calendarizara el Proceso", "AVISO", MessageBoxButtons.OK);
        }
        private void ErrorProcesoNoCalendarizable(int Proceso)
        {
            MessageBox.Show(this, "Error 102 / El proceso" + Proceso + " no puede calendarizarse\n No se calendarizara el Proceso", "AVISO", MessageBoxButtons.OK);
        }
        #endregion
        #region FUNCIONES PARA LA CALENDARIZACION
        private void OrdenandoMatrizProcesos()
        {   // Ordenando por el Periodo de muestreo
            for (int i = 0; i < NumProcesos; i++)
            {
                for (int j = i + 1; j < NumProcesos; j++)
                {
                    if (Procesos[i, 2] < Procesos[j, 2])
                    {
                        tmpProceso = Procesos[i, 0];
                        tmpDuracion = Procesos[i, 1];
                        tmpPeriodo = Procesos[i, 2];
                        Procesos[i, 0] = Procesos[j, 0];
                        Procesos[i, 1] = Procesos[j, 1];
                        Procesos[i, 2] = Procesos[j, 2];
                        Procesos[j, 0] = tmpProceso;
                        Procesos[j, 1] = tmpDuracion;
                        Procesos[j, 2] = tmpPeriodo;
                    }
                }
            }
        }
        private int MCMMatrizProcesos()
        {
            int[] N = new int[5];
            int mcm = 1;
            int cont = 2;

            for (int i = 0; i < NumProcesos; i++)
            {
                N[i] = Procesos[i, 2];
            }

            for (int i = NumProcesos; i < 5; i++)
            {
                N[i] = 1;
            }
            while (N[0] != 1 || N[1] != 1 || N[2] != 1 || N[3] != 1 || N[4] != 1)
            {
                while (N[0] % cont == 0 || N[1] % cont == 0 || N[2] % cont == 0 || N[3] % cont == 0 || N[4] % cont == 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (N[i] % cont == 0)
                            N[i] = N[i] / cont;
                    }
                    mcm = mcm * cont;
                }
                cont++;
            }
            return mcm;
        }
        private void CrearCalendario()
        {
            int rep;
            int tam, per;
            int inicio = 0;
            int pos = 0, ultm_pos = 0;
            tam_calendario = 0;

            for (int i = 0; i < MCM; i++)
            {
                calendario[i] = 0;
            }

            for (int i = 0; i < NumProcesos; i++)
            {
                rep = MCM / Procesos[i, 2];
                per = Procesos[i, 2];
                tam = Procesos[i, 1];
                for (int j = 0; j < rep; j++)
                {
                    for (int k = 0; k < tam; k++)
                    {
                        pos = inicio + j * per + k;
                        if (pos > ultm_pos)
                        {
                            ultm_pos = pos;
                        }

                        if (calendario[pos] == 0)
                        {
                            calendario[pos] = Procesos[i, 0];
                        }
                        else
                        {
                            Procesos[i, 3] = 0;
                        }
                    }
                }

                if (Procesos[i, 3] == 0)
                {
                    ErrorProcesoNoCalendarizable(Procesos[i, 0]);
                    QuitarProcesoCalendario(ultm_pos, Procesos[i, 0]);
                }
                else
                {
                    inicio = inicio + tam;
                }
            }
            tam_calendario = ultm_pos + 1;
        }
        private void MostrarCalendario()
        {
            for (int i = 0; i < MCM; i++)
            {
                if (calendario[i] != 0)
                {
                    this.RTBx_Terminal.AppendText("P" + calendario[i] + " ");
                }
                else
                {
                    this.RTBx_Terminal.AppendText("00 ");
                }
            }
        }
        private void CrearCalendarioPIC()
        {
            int temp;

            temp = calendario[0];
            for (int i = 1; i < MCM; i++)
            {
                if (temp == calendario[i])
                {
                    calendario[i] = 0;
                }
                else
                {
                    temp = calendario[i];
                }
            }
        }
        private void QuitarProcesoCalendario(int ultm_pos, int Proceso)
        {
            for (int i = 0; i <= ultm_pos; i++)
            {
                if (calendario[i] == Proceso)
                {
                    calendario[i] = 0;
                }
            }
        }
        #endregion

        private void BtnCalendarizar_MouseClick(object sender, MouseEventArgs e)
        {
            NumProcesos = 0;
            RTBx_Terminal.Text = "Iniciando Calendarizacion\nProcesos Selecionados\n";
            Actualizar_CheckButton();
            OrdenandoMatrizProcesos();
            MCM = MCMMatrizProcesos();
            this.RTBx_Terminal.AppendText("El MCM es: " + MCM + "\n");
            this.RTBx_Terminal.AppendText("\nCreando el Calendario \n");
            CrearCalendario();
            MostrarCalendario();
            this.RTBx_Terminal.AppendText("\n\nPreparando Calendario Para el PIC \n");
            CrearCalendarioPIC();
            MostrarCalendario();
        }

        private void BtnCargar_MouseDoubleClick(object sender, MouseEventArgs e)//se le va a enviar el mcm o tamanio del calendario
        {
            msg = "1";//indica envio de MCM
            TxMCM = Convert.ToString(MCM);
            while (TxMCM.Length < 5)
            {
                TxMCM = "0" + TxMCM;//convirtiendo al MCM en un formato de 5 cifras
            }
            msg = msg + TxMCM;//el mensaje tiene 6 cifras
            msg = msg + "*";
            this.RTBx_Terminal.AppendText("\nCargando Calendario ...\nPor favor espere.\n");
            EnviarComando(msg);
        }

        private void BtnEjecutar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            msg = "300000*";
            this.RTBx_Terminal.AppendText("Ejecutando Calendario\n");
            EnviarComando(msg);
            btn_conexion.Enabled = false;
        }

        private void BtnDetener_DoubleClick(object sender, EventArgs e)
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
            char[] delimitadores = { '+' };
            string[] palabras = data.Split(delimitadores);
            j = 0;
            foreach (string s1 in palabras)
            {
                switch (j)
                {
                    case 0:
                        cmd = s1;
                        break;
                    case 1:
                        cmd_num = Convert.ToInt16(s1);
                        break;
                    case 2://Aun no se usa
                        valor = Convert.ToInt16(s1);
                        break;
                }
                j = j + 1;
            }

            data = "";
            flag_cmd = 1;
            

        }
        private void ChBx_Duracion_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBx_Duracion.Checked)
            {
                Habilitar_TxBx_Duraciones();
            }
            else
            {
                Deshabilitar_TxBx_Duraciones();
            }
        }

        private void ChBx_PeriodoMuestreo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBx_PeriodoMuestreo.Checked)
            {
                Habilitar_TxBx_Periodos();
            }
            else
            {
                Deshabilitar_TxBx_Periodos();
            }
        }

            private void Timer_Tick_1(object sender, EventArgs e)
        {
            if (flag_cmd == 1)
            {

                switch (cmd)
                {
                    case "M":
                        if (cmd_num == 3)//el pic confirmo que está listo para recibir la informacion del vector calendario(M3)
                        {
                            this.RTBx_Terminal.AppendText("Listo para recibir :M" + Convert.ToString(cmd_num) + "\n");
                            flag_envio = 1;
                            pos_envio = 0;
                            proceso_envio = 0;
                        }
                        if (cmd_num == 0)
                        {
                            flag_envio = 0;
                            this.RTBx_Terminal.AppendText("Calendario Cargado\n");
                        }
                        break;
                    case "P":
                        if (cmd_num != proceso_envio)
                        {
                            // aun no se hace nada
                        }
                        break;
                }

                if (flag_envio == 1)
                {

                    if (pos_envio >= MCM)
                    {
                        msg = "100000*";
                        EnviarComando(msg);
                    }
                    else
                    {
                        msg = "";
                        msg = msg + "2";//es el case 2 del pic
                        proceso_envio = calendario[pos_envio];//numero de una cifra que indica el proceso que es.
                        msg = msg + Convert.ToString(proceso_envio);
                        Txtmp = Convert.ToString(pos_envio);
                        while (Txtmp.Length < 4)//se le da formato de 4 numeros-------------------
                        {
                            Txtmp = "0" + Txtmp;
                        }
                        //this.RTBx_Terminal.AppendText("\ncase(2)+proceso+posicion:" + Txtmp);
                        msg = msg + Txtmp;
                        msg = msg + "*";
                        this.RTBx_Terminal.AppendText("\ncase(2)+proceso+posicion:" + Txtmp);
                        EnviarComando(msg);
                    }
                    do
                    {
                        pos_envio++;
                    } while(calendario[pos_envio] == 0 && pos_envio <= MCM);

                }

                flag_cmd = 0;
            }
        }

            private void BtnLecturaADC_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                ADC form6 = new ADC();
                form6.Show();
            }

       

    }
}
