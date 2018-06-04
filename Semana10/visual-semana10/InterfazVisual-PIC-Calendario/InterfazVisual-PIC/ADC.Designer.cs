namespace InterfazVisual_PIC
{
    partial class ADC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADC));
            this.L_conexion = new System.Windows.Forms.Label();
            this.btn_conexion = new System.Windows.Forms.PictureBox();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.PictureBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.RTBx_Terminal = new System.Windows.Forms.RichTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PBx_Monitor = new System.Windows.Forms.PictureBox();
            this.BtnDetener = new System.Windows.Forms.PictureBox();
            this.BtnVerGraficas = new System.Windows.Forms.PictureBox();
            this.BtnEjecutar = new System.Windows.Forms.PictureBox();
            this.textRPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_RPM = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).BeginInit();
            this.SuspendLayout();
            // 
            // L_conexion
            // 
            this.L_conexion.AutoSize = true;
            this.L_conexion.Location = new System.Drawing.Point(12, 9);
            this.L_conexion.Name = "L_conexion";
            this.L_conexion.Size = new System.Drawing.Size(50, 13);
            this.L_conexion.TabIndex = 18;
            this.L_conexion.Text = "Conectar";
            // 
            // btn_conexion
            // 
            this.btn_conexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conexion.BackgroundImage")));
            this.btn_conexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conexion.Location = new System.Drawing.Point(15, 25);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(100, 50);
            this.btn_conexion.TabIndex = 19;
            this.btn_conexion.TabStop = false;
            this.btn_conexion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_MouseDoubleClick);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(15, 81);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(100, 21);
            this.PuertoList.TabIndex = 20;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.BackgroundImage")));
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_limpiar.Location = new System.Drawing.Point(121, 25);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(77, 50);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.TabStop = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_DoubleClick);
            this.btn_limpiar.DoubleClick += new System.EventHandler(this.btn_limpiar_DoubleClick);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // RTBx_Terminal
            // 
            this.RTBx_Terminal.Location = new System.Drawing.Point(15, 108);
            this.RTBx_Terminal.Name = "RTBx_Terminal";
            this.RTBx_Terminal.Size = new System.Drawing.Size(503, 124);
            this.RTBx_Terminal.TabIndex = 22;
            this.RTBx_Terminal.Text = "";
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PBx_Monitor
            // 
            this.PBx_Monitor.Location = new System.Drawing.Point(15, 238);
            this.PBx_Monitor.Name = "PBx_Monitor";
            this.PBx_Monitor.Size = new System.Drawing.Size(503, 213);
            this.PBx_Monitor.TabIndex = 23;
            this.PBx_Monitor.TabStop = false;
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.detenerCalendario;
            this.BtnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDetener.Location = new System.Drawing.Point(544, 25);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(93, 35);
            this.BtnDetener.TabIndex = 40;
            this.BtnDetener.TabStop = false;
            this.BtnDetener.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnDetener_MouseDoubleClick);
            // 
            // BtnVerGraficas
            // 
            this.BtnVerGraficas.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.art04_f10;
            this.BtnVerGraficas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerGraficas.Location = new System.Drawing.Point(529, 238);
            this.BtnVerGraficas.Name = "BtnVerGraficas";
            this.BtnVerGraficas.Size = new System.Drawing.Size(129, 57);
            this.BtnVerGraficas.TabIndex = 41;
            this.BtnVerGraficas.TabStop = false;
            this.BtnVerGraficas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnVerGraficas_MouseDoubleClick);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.ejecutarProceso;
            this.BtnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEjecutar.Location = new System.Drawing.Point(418, 25);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(100, 35);
            this.BtnEjecutar.TabIndex = 42;
            this.BtnEjecutar.TabStop = false;
            this.BtnEjecutar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BtnEjecutar_MouseDoubleClick_1);
            // 
            // textRPM
            // 
            this.textRPM.Location = new System.Drawing.Point(544, 108);
            this.textRPM.Name = "textRPM";
            this.textRPM.Size = new System.Drawing.Size(100, 20);
            this.textRPM.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Rpm máxima";
            // 
            // button_RPM
            // 
            this.button_RPM.Location = new System.Drawing.Point(562, 134);
            this.button_RPM.Name = "button_RPM";
            this.button_RPM.Size = new System.Drawing.Size(75, 23);
            this.button_RPM.TabIndex = 46;
            this.button_RPM.Text = "Cargar RPM";
            this.button_RPM.UseVisualStyleBackColor = true;
            this.button_RPM.Click += new System.EventHandler(this.button_RPM_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 47;
            // 
            // ADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_RPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRPM);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnVerGraficas);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.PBx_Monitor);
            this.Controls.Add(this.RTBx_Terminal);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.btn_conexion);
            this.Controls.Add(this.L_conexion);
            this.Name = "ADC";
            this.Text = "ADC";
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_conexion;
        private System.Windows.Forms.PictureBox btn_conexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.Windows.Forms.PictureBox btn_limpiar;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.RichTextBox RTBx_Terminal;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox PBx_Monitor;
        private System.Windows.Forms.PictureBox BtnDetener;
        private System.Windows.Forms.PictureBox BtnVerGraficas;
        private System.Windows.Forms.PictureBox BtnEjecutar;
        private System.Windows.Forms.TextBox textRPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_RPM;
        private System.Windows.Forms.TextBox textBox1;

    }
}