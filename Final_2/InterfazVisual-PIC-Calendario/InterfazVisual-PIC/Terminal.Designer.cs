namespace InterfazVisual_PIC
{
    partial class Terminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.L_conexion = new System.Windows.Forms.Label();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.btn_conexion = new System.Windows.Forms.PictureBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_enviar = new System.Windows.Forms.PictureBox();
            this.TxBxComando = new System.Windows.Forms.TextBox();
            this.RTbx_terminal = new System.Windows.Forms.RichTextBox();
            this.btn_limpiar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CalendarioClick = new System.Windows.Forms.PictureBox();
            this.Calendarizar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarioClick)).BeginInit();
            this.SuspendLayout();
            // 
            // L_conexion
            // 
            this.L_conexion.AutoSize = true;
            this.L_conexion.Location = new System.Drawing.Point(28, 10);
            this.L_conexion.Name = "L_conexion";
            this.L_conexion.Size = new System.Drawing.Size(50, 13);
            this.L_conexion.TabIndex = 10;
            this.L_conexion.Text = "Conectar";
            this.L_conexion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_Click_MouseDoubleClick);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(21, 95);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(121, 21);
            this.PuertoList.TabIndex = 8;
            this.PuertoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_Click_MouseDoubleClick);
            // 
            // btn_conexion
            // 
            this.btn_conexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conexion.BackgroundImage")));
            this.btn_conexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conexion.Location = new System.Drawing.Point(21, 39);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(100, 50);
            this.btn_conexion.TabIndex = 9;
            this.btn_conexion.TabStop = false;
            this.btn_conexion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_Click_MouseDoubleClick);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btn_enviar);
            this.groupBox1.Controls.Add(this.TxBxComando);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envio";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enviar.BackgroundImage")));
            this.btn_enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enviar.Location = new System.Drawing.Point(29, 45);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(98, 28);
            this.btn_enviar.TabIndex = 14;
            this.btn_enviar.TabStop = false;
            this.btn_enviar.DoubleClick += new System.EventHandler(this.btn_enviar_DoubleClick);
            // 
            // TxBxComando
            // 
            this.TxBxComando.Location = new System.Drawing.Point(14, 19);
            this.TxBxComando.Name = "TxBxComando";
            this.TxBxComando.Size = new System.Drawing.Size(121, 20);
            this.TxBxComando.TabIndex = 7;
            // 
            // RTbx_terminal
            // 
            this.RTbx_terminal.BackColor = System.Drawing.SystemColors.Menu;
            this.RTbx_terminal.Location = new System.Drawing.Point(231, 12);
            this.RTbx_terminal.Name = "RTbx_terminal";
            this.RTbx_terminal.Size = new System.Drawing.Size(209, 76);
            this.RTbx_terminal.TabIndex = 12;
            this.RTbx_terminal.Text = "";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.BackgroundImage")));
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_limpiar.Location = new System.Drawing.Point(137, 39);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(77, 50);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.TabStop = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 105);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Location = new System.Drawing.Point(9, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 61);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(251, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 105);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Admin- Procesos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(26, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 65);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // CalendarioClick
            // 
            this.CalendarioClick.BackgroundImage = global::InterfazVisual_PIC.Properties.Resources.calendario;
            this.CalendarioClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CalendarioClick.Location = new System.Drawing.Point(277, 278);
            this.CalendarioClick.Name = "CalendarioClick";
            this.CalendarioClick.Size = new System.Drawing.Size(100, 50);
            this.CalendarioClick.TabIndex = 16;
            this.CalendarioClick.TabStop = false;
            this.CalendarioClick.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CalendarioClick_MouseDoubleClick);
            // 
            // Calendarizar
            // 
            this.Calendarizar.BackColor = System.Drawing.SystemColors.Control;
            this.Calendarizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Calendarizar.Location = new System.Drawing.Point(250, 250);
            this.Calendarizar.Name = "Calendarizar";
            this.Calendarizar.Size = new System.Drawing.Size(200, 100);
            this.Calendarizar.TabIndex = 17;
            this.Calendarizar.TabStop = false;
            this.Calendarizar.Text = "Calendario";
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 392);
            this.Controls.Add(this.CalendarioClick);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.RTbx_terminal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_conexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.btn_conexion);
            this.Controls.Add(this.Calendarizar);
            this.Name = "Terminal";
            this.Text = "Terminal";
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarioClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_conexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.Windows.Forms.PictureBox btn_conexion;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxBxComando;
        private System.Windows.Forms.RichTextBox RTbx_terminal;
        private System.Windows.Forms.PictureBox btn_limpiar;
        private System.Windows.Forms.PictureBox btn_enviar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox CalendarioClick;
        private System.Windows.Forms.GroupBox Calendarizar;
    }
}