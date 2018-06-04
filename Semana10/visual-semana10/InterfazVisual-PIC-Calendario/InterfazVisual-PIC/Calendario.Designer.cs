namespace InterfazVisual_PIC
{
    partial class Calendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.L_conexion = new System.Windows.Forms.Label();
            this.RTBx_Terminal = new System.Windows.Forms.RichTextBox();
            this.TxBx_D1 = new System.Windows.Forms.TextBox();
            this.TxBx_D2 = new System.Windows.Forms.TextBox();
            this.TxBx_D3 = new System.Windows.Forms.TextBox();
            this.TxBx_D4 = new System.Windows.Forms.TextBox();
            this.TxBx_D5 = new System.Windows.Forms.TextBox();
            this.TxBx_T1 = new System.Windows.Forms.TextBox();
            this.TxBx_T2 = new System.Windows.Forms.TextBox();
            this.TxBx_T3 = new System.Windows.Forms.TextBox();
            this.TxBx_T4 = new System.Windows.Forms.TextBox();
            this.TxBx_T5 = new System.Windows.Forms.TextBox();
            this.ChBx_1 = new System.Windows.Forms.CheckBox();
            this.ChBx_2 = new System.Windows.Forms.CheckBox();
            this.ChBx_3 = new System.Windows.Forms.CheckBox();
            this.ChBx_4 = new System.Windows.Forms.CheckBox();
            this.ChBx_5 = new System.Windows.Forms.CheckBox();
            this.ChBx_Duracion = new System.Windows.Forms.CheckBox();
            this.ChBx_PeriodoMuestreo = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLecturaADC = new System.Windows.Forms.PictureBox();
            this.BtnDetener = new System.Windows.Forms.PictureBox();
            this.BtnEjecutar = new System.Windows.Forms.PictureBox();
            this.BtnCargar = new System.Windows.Forms.PictureBox();
            this.BtnCalendarizar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.PictureBox();
            this.btn_conexion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLecturaADC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).BeginInit();
            this.SuspendLayout();
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(31, 93);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(121, 21);
            this.PuertoList.TabIndex = 0;
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // L_conexion
            // 
            this.L_conexion.AutoSize = true;
            this.L_conexion.Location = new System.Drawing.Point(28, 9);
            this.L_conexion.Name = "L_conexion";
            this.L_conexion.Size = new System.Drawing.Size(50, 13);
            this.L_conexion.TabIndex = 17;
            this.L_conexion.Text = "Conectar";
            // 
            // RTBx_Terminal
            // 
            this.RTBx_Terminal.Location = new System.Drawing.Point(341, 93);
            this.RTBx_Terminal.Name = "RTBx_Terminal";
            this.RTBx_Terminal.Size = new System.Drawing.Size(436, 319);
            this.RTBx_Terminal.TabIndex = 20;
            this.RTBx_Terminal.Text = "";
            // 
            // TxBx_D1
            // 
            this.TxBx_D1.Location = new System.Drawing.Point(88, 144);
            this.TxBx_D1.Name = "TxBx_D1";
            this.TxBx_D1.Size = new System.Drawing.Size(100, 20);
            this.TxBx_D1.TabIndex = 21;
            // 
            // TxBx_D2
            // 
            this.TxBx_D2.Location = new System.Drawing.Point(88, 171);
            this.TxBx_D2.Name = "TxBx_D2";
            this.TxBx_D2.Size = new System.Drawing.Size(100, 20);
            this.TxBx_D2.TabIndex = 22;
            // 
            // TxBx_D3
            // 
            this.TxBx_D3.Location = new System.Drawing.Point(88, 198);
            this.TxBx_D3.Name = "TxBx_D3";
            this.TxBx_D3.Size = new System.Drawing.Size(100, 20);
            this.TxBx_D3.TabIndex = 23;
            // 
            // TxBx_D4
            // 
            this.TxBx_D4.Location = new System.Drawing.Point(88, 238);
            this.TxBx_D4.Name = "TxBx_D4";
            this.TxBx_D4.Size = new System.Drawing.Size(100, 20);
            this.TxBx_D4.TabIndex = 24;
            // 
            // TxBx_D5
            // 
            this.TxBx_D5.Location = new System.Drawing.Point(88, 265);
            this.TxBx_D5.Name = "TxBx_D5";
            this.TxBx_D5.Size = new System.Drawing.Size(100, 20);
            this.TxBx_D5.TabIndex = 25;
            // 
            // TxBx_T1
            // 
            this.TxBx_T1.Location = new System.Drawing.Point(211, 144);
            this.TxBx_T1.Name = "TxBx_T1";
            this.TxBx_T1.Size = new System.Drawing.Size(100, 20);
            this.TxBx_T1.TabIndex = 26;
            // 
            // TxBx_T2
            // 
            this.TxBx_T2.Location = new System.Drawing.Point(211, 170);
            this.TxBx_T2.Name = "TxBx_T2";
            this.TxBx_T2.Size = new System.Drawing.Size(100, 20);
            this.TxBx_T2.TabIndex = 27;
            // 
            // TxBx_T3
            // 
            this.TxBx_T3.Location = new System.Drawing.Point(211, 197);
            this.TxBx_T3.Name = "TxBx_T3";
            this.TxBx_T3.Size = new System.Drawing.Size(100, 20);
            this.TxBx_T3.TabIndex = 28;
            // 
            // TxBx_T4
            // 
            this.TxBx_T4.Location = new System.Drawing.Point(211, 237);
            this.TxBx_T4.Name = "TxBx_T4";
            this.TxBx_T4.Size = new System.Drawing.Size(100, 20);
            this.TxBx_T4.TabIndex = 29;
            // 
            // TxBx_T5
            // 
            this.TxBx_T5.Location = new System.Drawing.Point(211, 264);
            this.TxBx_T5.Name = "TxBx_T5";
            this.TxBx_T5.Size = new System.Drawing.Size(100, 20);
            this.TxBx_T5.TabIndex = 30;
            // 
            // ChBx_1
            // 
            this.ChBx_1.AutoSize = true;
            this.ChBx_1.Location = new System.Drawing.Point(16, 144);
            this.ChBx_1.Name = "ChBx_1";
            this.ChBx_1.Size = new System.Drawing.Size(71, 17);
            this.ChBx_1.TabIndex = 32;
            this.ChBx_1.Text = "Proceso4";
            this.ChBx_1.UseVisualStyleBackColor = true;
            // 
            // ChBx_2
            // 
            this.ChBx_2.AutoSize = true;
            this.ChBx_2.Location = new System.Drawing.Point(16, 174);
            this.ChBx_2.Name = "ChBx_2";
            this.ChBx_2.Size = new System.Drawing.Size(71, 17);
            this.ChBx_2.TabIndex = 33;
            this.ChBx_2.Text = "Proceso5";
            this.ChBx_2.UseVisualStyleBackColor = true;
            // 
            // ChBx_3
            // 
            this.ChBx_3.AutoSize = true;
            this.ChBx_3.Location = new System.Drawing.Point(16, 201);
            this.ChBx_3.Name = "ChBx_3";
            this.ChBx_3.Size = new System.Drawing.Size(71, 17);
            this.ChBx_3.TabIndex = 34;
            this.ChBx_3.Text = "Proceso6";
            this.ChBx_3.UseVisualStyleBackColor = true;
            // 
            // ChBx_4
            // 
            this.ChBx_4.AutoSize = true;
            this.ChBx_4.Location = new System.Drawing.Point(16, 240);
            this.ChBx_4.Name = "ChBx_4";
            this.ChBx_4.Size = new System.Drawing.Size(71, 17);
            this.ChBx_4.TabIndex = 35;
            this.ChBx_4.Text = "Proceso7";
            this.ChBx_4.UseVisualStyleBackColor = true;
            // 
            // ChBx_5
            // 
            this.ChBx_5.AutoSize = true;
            this.ChBx_5.Location = new System.Drawing.Point(16, 267);
            this.ChBx_5.Name = "ChBx_5";
            this.ChBx_5.Size = new System.Drawing.Size(71, 17);
            this.ChBx_5.TabIndex = 36;
            this.ChBx_5.Text = "Proceso8";
            this.ChBx_5.UseVisualStyleBackColor = true;
            // 
            // ChBx_Duracion
            // 
            this.ChBx_Duracion.AutoSize = true;
            this.ChBx_Duracion.Location = new System.Drawing.Point(88, 120);
            this.ChBx_Duracion.Name = "ChBx_Duracion";
            this.ChBx_Duracion.Size = new System.Drawing.Size(69, 17);
            this.ChBx_Duracion.TabIndex = 40;
            this.ChBx_Duracion.Text = "Duracion";
            this.ChBx_Duracion.UseVisualStyleBackColor = true;
            this.ChBx_Duracion.CheckedChanged += new System.EventHandler(this.ChBx_Duracion_CheckedChanged);
            // 
            // ChBx_PeriodoMuestreo
            // 
            this.ChBx_PeriodoMuestreo.AutoSize = true;
            this.ChBx_PeriodoMuestreo.Location = new System.Drawing.Point(211, 121);
            this.ChBx_PeriodoMuestreo.Name = "ChBx_PeriodoMuestreo";
            this.ChBx_PeriodoMuestreo.Size = new System.Drawing.Size(124, 17);
            this.ChBx_PeriodoMuestreo.TabIndex = 41;
            this.ChBx_PeriodoMuestreo.Text = "Periodo de Muestreo";
            this.ChBx_PeriodoMuestreo.UseVisualStyleBackColor = true;
            this.ChBx_PeriodoMuestreo.CheckedChanged += new System.EventHandler(this.ChBx_PeriodoMuestreo_CheckedChanged);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lectura ADC  y Control PID";
            // 
            // BtnLecturaADC
            // 
            this.BtnLecturaADC.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.conversion01;
            this.BtnLecturaADC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLecturaADC.Location = new System.Drawing.Point(116, 328);
            this.BtnLecturaADC.Name = "BtnLecturaADC";
            this.BtnLecturaADC.Size = new System.Drawing.Size(100, 50);
            this.BtnLecturaADC.TabIndex = 42;
            this.BtnLecturaADC.TabStop = false;
            this.BtnLecturaADC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnLecturaADC_MouseDoubleClick);
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.detenerCalendario;
            this.BtnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDetener.Location = new System.Drawing.Point(630, 37);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(93, 35);
            this.BtnDetener.TabIndex = 39;
            this.BtnDetener.TabStop = false;
            this.BtnDetener.DoubleClick += new System.EventHandler(this.BtnDetener_DoubleClick);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.ejecutarProceso;
            this.BtnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEjecutar.Location = new System.Drawing.Point(513, 37);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(100, 35);
            this.BtnEjecutar.TabIndex = 38;
            this.BtnEjecutar.TabStop = false;
            this.BtnEjecutar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnEjecutar_MouseDoubleClick);
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.cargar;
            this.BtnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargar.Location = new System.Drawing.Point(385, 37);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(100, 35);
            this.BtnCargar.TabIndex = 37;
            this.BtnCargar.TabStop = false;
            this.BtnCargar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnCargar_MouseDoubleClick);
            // 
            // BtnCalendarizar
            // 
            this.BtnCalendarizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalendarizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalendarizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalendarizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalendarizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCalendarizar.Image = global::InterfazVisual_PIC.Properties.Resources.calendarizar;
            this.BtnCalendarizar.Location = new System.Drawing.Point(261, 37);
            this.BtnCalendarizar.Name = "BtnCalendarizar";
            this.BtnCalendarizar.Size = new System.Drawing.Size(99, 35);
            this.BtnCalendarizar.TabIndex = 31;
            this.BtnCalendarizar.Text = "Calendarizar";
            this.BtnCalendarizar.UseVisualStyleBackColor = false;
            this.BtnCalendarizar.UseWaitCursor = true;
            this.BtnCalendarizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnCalendarizar_MouseClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.BackgroundImage")));
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_limpiar.Location = new System.Drawing.Point(156, 37);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(77, 50);
            this.btn_limpiar.TabIndex = 19;
            this.btn_limpiar.TabStop = false;
            this.btn_limpiar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_limpiar_MouseDoubleClick);
            // 
            // btn_conexion
            // 
            this.btn_conexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conexion.BackgroundImage")));
            this.btn_conexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conexion.Location = new System.Drawing.Point(31, 37);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(100, 50);
            this.btn_conexion.TabIndex = 18;
            this.btn_conexion.TabStop = false;
            this.btn_conexion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_MouseDoubleClick);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLecturaADC);
            this.Controls.Add(this.ChBx_PeriodoMuestreo);
            this.Controls.Add(this.ChBx_Duracion);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.ChBx_5);
            this.Controls.Add(this.ChBx_4);
            this.Controls.Add(this.ChBx_3);
            this.Controls.Add(this.ChBx_2);
            this.Controls.Add(this.ChBx_1);
            this.Controls.Add(this.BtnCalendarizar);
            this.Controls.Add(this.TxBx_T5);
            this.Controls.Add(this.TxBx_T4);
            this.Controls.Add(this.TxBx_T3);
            this.Controls.Add(this.TxBx_T2);
            this.Controls.Add(this.TxBx_T1);
            this.Controls.Add(this.TxBx_D5);
            this.Controls.Add(this.TxBx_D4);
            this.Controls.Add(this.TxBx_D3);
            this.Controls.Add(this.TxBx_D2);
            this.Controls.Add(this.TxBx_D1);
            this.Controls.Add(this.RTBx_Terminal);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_conexion);
            this.Controls.Add(this.L_conexion);
            this.Controls.Add(this.PuertoList);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLecturaADC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PuertoList;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.Label L_conexion;
        private System.Windows.Forms.PictureBox btn_conexion;
        private System.Windows.Forms.PictureBox btn_limpiar;
        private System.Windows.Forms.RichTextBox RTBx_Terminal;
        private System.Windows.Forms.TextBox TxBx_D1;
        private System.Windows.Forms.TextBox TxBx_D2;
        private System.Windows.Forms.TextBox TxBx_D3;
        private System.Windows.Forms.TextBox TxBx_D4;
        private System.Windows.Forms.TextBox TxBx_D5;
        private System.Windows.Forms.TextBox TxBx_T1;
        private System.Windows.Forms.TextBox TxBx_T2;
        private System.Windows.Forms.TextBox TxBx_T3;
        private System.Windows.Forms.TextBox TxBx_T4;
        private System.Windows.Forms.TextBox TxBx_T5;
        private System.Windows.Forms.Button BtnCalendarizar;
        private System.Windows.Forms.CheckBox ChBx_1;
        private System.Windows.Forms.CheckBox ChBx_2;
        private System.Windows.Forms.CheckBox ChBx_3;
        private System.Windows.Forms.CheckBox ChBx_4;
        private System.Windows.Forms.CheckBox ChBx_5;
        private System.Windows.Forms.PictureBox BtnCargar;
        private System.Windows.Forms.PictureBox BtnEjecutar;
        private System.Windows.Forms.PictureBox BtnDetener;
        private System.Windows.Forms.CheckBox ChBx_Duracion;
        private System.Windows.Forms.CheckBox ChBx_PeriodoMuestreo;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox BtnLecturaADC;
        private System.Windows.Forms.Label label1;
    }
}