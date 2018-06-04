namespace InterfazVisual_PIC
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.L_conexion = new System.Windows.Forms.Label();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.btn_conexion_Click = new System.Windows.Forms.PictureBox();
            this.Txb_admin = new System.Windows.Forms.RichTextBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.actualizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion_Click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // L_conexion
            // 
            this.L_conexion.AutoSize = true;
            this.L_conexion.Location = new System.Drawing.Point(33, 25);
            this.L_conexion.Name = "L_conexion";
            this.L_conexion.Size = new System.Drawing.Size(50, 13);
            this.L_conexion.TabIndex = 16;
            this.L_conexion.Text = "Conectar";
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(27, 110);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(121, 21);
            this.PuertoList.TabIndex = 14;
            // 
            // btn_conexion_Click
            // 
            this.btn_conexion_Click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conexion_Click.BackgroundImage")));
            this.btn_conexion_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conexion_Click.Location = new System.Drawing.Point(27, 54);
            this.btn_conexion_Click.Name = "btn_conexion_Click";
            this.btn_conexion_Click.Size = new System.Drawing.Size(100, 50);
            this.btn_conexion_Click.TabIndex = 15;
            this.btn_conexion_Click.TabStop = false;
            this.btn_conexion_Click.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_conexion_Click_MouseDoubleClick);
            // 
            // Txb_admin
            // 
            this.Txb_admin.Location = new System.Drawing.Point(154, 27);
            this.Txb_admin.Name = "Txb_admin";
            this.Txb_admin.Size = new System.Drawing.Size(372, 238);
            this.Txb_admin.TabIndex = 13;
            this.Txb_admin.Text = "";
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // actualizar
            // 
            this.actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizar.BackgroundImage")));
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizar.Location = new System.Drawing.Point(36, 158);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(79, 50);
            this.actualizar.TabIndex = 17;
            this.actualizar.TabStop = false;
            this.actualizar.DoubleClick += new System.EventHandler(this.actualizar_DoubleClick);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 305);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.L_conexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.btn_conexion_Click);
            this.Controls.Add(this.Txb_admin);
            this.Name = "Administrador";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.btn_conexion_Click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_conexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.Windows.Forms.PictureBox btn_conexion_Click;
        private System.Windows.Forms.RichTextBox Txb_admin;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.PictureBox actualizar;
    }
}