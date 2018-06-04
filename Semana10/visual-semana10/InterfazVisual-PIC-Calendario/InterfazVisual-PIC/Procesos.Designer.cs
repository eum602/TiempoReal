namespace InterfazVisual_PIC
{
    partial class Procesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procesos));
            this.btn_limpiar = new System.Windows.Forms.PictureBox();
            this.L_conexion = new System.Windows.Forms.Label();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.btn_conexion = new System.Windows.Forms.PictureBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.Txb_proc = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cargar1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cargar2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cargar4 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cargar3 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cargar6 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cargar7 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cargar8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar6)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar7)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargar8)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.BackgroundImage")));
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_limpiar.Location = new System.Drawing.Point(171, 34);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(77, 50);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.TabStop = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // L_conexion
            // 
            this.L_conexion.AutoSize = true;
            this.L_conexion.Location = new System.Drawing.Point(51, 6);
            this.L_conexion.Name = "L_conexion";
            this.L_conexion.Size = new System.Drawing.Size(50, 13);
            this.L_conexion.TabIndex = 16;
            this.L_conexion.Text = "Conectar";
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(44, 91);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(121, 21);
            this.PuertoList.TabIndex = 14;
            // 
            // btn_conexion
            // 
            this.btn_conexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conexion.BackgroundImage")));
            this.btn_conexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conexion.Location = new System.Drawing.Point(44, 35);
            this.btn_conexion.Name = "btn_conexion";
            this.btn_conexion.Size = new System.Drawing.Size(100, 50);
            this.btn_conexion.TabIndex = 15;
            this.btn_conexion.TabStop = false;
            this.btn_conexion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_MouseDoubleClick);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // Txb_proc
            // 
            this.Txb_proc.Location = new System.Drawing.Point(308, 34);
            this.Txb_proc.Name = "Txb_proc";
            this.Txb_proc.Size = new System.Drawing.Size(161, 78);
            this.Txb_proc.TabIndex = 18;
            this.Txb_proc.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cargar1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(45, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 115);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso1-Prender Led 1";
            // 
            // cargar1
            // 
            this.cargar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar1.BackgroundImage")));
            this.cargar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar1.Location = new System.Drawing.Point(31, 34);
            this.cargar1.Name = "cargar1";
            this.cargar1.Size = new System.Drawing.Size(115, 66);
            this.cargar1.TabIndex = 0;
            this.cargar1.TabStop = false;
            this.cargar1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar1_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.cargar2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(297, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 116);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso2-Prender Led 2";
            // 
            // cargar2
            // 
            this.cargar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar2.BackgroundImage")));
            this.cargar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar2.Location = new System.Drawing.Point(31, 34);
            this.cargar2.Name = "cargar2";
            this.cargar2.Size = new System.Drawing.Size(115, 66);
            this.cargar2.TabIndex = 0;
            this.cargar2.TabStop = false;
            this.cargar2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar2_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.cargar4);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(44, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 112);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proceso4-Prender Led 4-FINITO";
            // 
            // cargar4
            // 
            this.cargar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar4.BackgroundImage")));
            this.cargar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar4.Location = new System.Drawing.Point(31, 34);
            this.cargar4.Name = "cargar4";
            this.cargar4.Size = new System.Drawing.Size(115, 66);
            this.cargar4.TabIndex = 0;
            this.cargar4.TabStop = false;
            this.cargar4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar4_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Controls.Add(this.cargar3);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(516, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 116);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proceso3-Prender Led 3";
            // 
            // cargar3
            // 
            this.cargar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar3.BackgroundImage")));
            this.cargar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar3.Location = new System.Drawing.Point(31, 34);
            this.cargar3.Name = "cargar3";
            this.cargar3.Size = new System.Drawing.Size(115, 66);
            this.cargar3.TabIndex = 0;
            this.cargar3.TabStop = false;
            this.cargar3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar3_MouseDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(282, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 115);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Proceso5-Prender Led 5-FINITO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(31, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox6.BackgroundImage")));
            this.groupBox6.Controls.Add(this.cargar6);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(512, 350);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(173, 115);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Proceso6-Prender Led 0-FINITO";
            // 
            // cargar6
            // 
            this.cargar6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar6.BackgroundImage")));
            this.cargar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar6.Location = new System.Drawing.Point(31, 34);
            this.cargar6.Name = "cargar6";
            this.cargar6.Size = new System.Drawing.Size(115, 66);
            this.cargar6.TabIndex = 0;
            this.cargar6.TabStop = false;
            this.cargar6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar6_MouseDoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox7.BackgroundImage")));
            this.groupBox7.Controls.Add(this.cargar7);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(171, 502);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(173, 115);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Proceso7-Prender Led 1-FINITO";
            // 
            // cargar7
            // 
            this.cargar7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar7.BackgroundImage")));
            this.cargar7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar7.Location = new System.Drawing.Point(31, 34);
            this.cargar7.Name = "cargar7";
            this.cargar7.Size = new System.Drawing.Size(115, 66);
            this.cargar7.TabIndex = 0;
            this.cargar7.TabStop = false;
            this.cargar7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar7_MouseDoubleClick);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox8.BackgroundImage")));
            this.groupBox8.Controls.Add(this.cargar8);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Location = new System.Drawing.Point(410, 502);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(173, 115);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Proceso8-Prender Led 2-FINITO";
            // 
            // cargar8
            // 
            this.cargar8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargar8.BackgroundImage")));
            this.cargar8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cargar8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cargar8.Location = new System.Drawing.Point(31, 34);
            this.cargar8.Name = "cargar8";
            this.cargar8.Size = new System.Drawing.Size(115, 66);
            this.cargar8.TabIndex = 0;
            this.cargar8.TabStop = false;
            this.cargar8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cargar8_MouseDoubleClick);
            // 
            // Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 629);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txb_proc);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.L_conexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.btn_conexion);
            this.Name = "Procesos";
            this.Text = "Procesos";
            ((System.ComponentModel.ISupportInitialize)(this.btn_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar6)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar7)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargar8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_limpiar;
        private System.Windows.Forms.Label L_conexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.Windows.Forms.PictureBox btn_conexion;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.RichTextBox Txb_proc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox cargar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox cargar2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox cargar4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox cargar3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox cargar6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox cargar7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox cargar8;
    }
}