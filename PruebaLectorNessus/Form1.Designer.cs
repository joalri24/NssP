namespace PruebaLectorNessus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerFondo = new System.Windows.Forms.SplitContainer();
            this.splitContainerOpciones = new System.Windows.Forms.SplitContainer();
            this.groupBoxArchivo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.checkBoxSeveridad0 = new System.Windows.Forms.CheckBox();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.groupBoxColumnas = new System.Windows.Forms.GroupBox();
            this.checkBoxInfoAdicional = new System.Windows.Forms.CheckBox();
            this.checkBoxSolucion = new System.Windows.Forms.CheckBox();
            this.checkBoxOS = new System.Windows.Forms.CheckBox();
            this.checkBoxCvss = new System.Windows.Forms.CheckBox();
            this.checkBoxIP = new System.Windows.Forms.CheckBox();
            this.checkBoxCve = new System.Windows.Forms.CheckBox();
            this.checkBoxSeveridad = new System.Windows.Forms.CheckBox();
            this.checkBoxNetBios = new System.Windows.Forms.CheckBox();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.checkBoxMac = new System.Windows.Forms.CheckBox();
            this.checkBoxPlugin = new System.Windows.Forms.CheckBox();
            this.checkBoxXref = new System.Windows.Forms.CheckBox();
            this.checkBoxBid = new System.Windows.Forms.CheckBox();
            this.checkBoxExploit = new System.Windows.Forms.CheckBox();
            this.checkBoxProtocolo = new System.Windows.Forms.CheckBox();
            this.checkBoxPuerto = new System.Windows.Forms.CheckBox();
            this.checkBoxSinopsis = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelMensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFondo)).BeginInit();
            this.splitContainerFondo.Panel1.SuspendLayout();
            this.splitContainerFondo.Panel2.SuspendLayout();
            this.splitContainerFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOpciones)).BeginInit();
            this.splitContainerOpciones.Panel1.SuspendLayout();
            this.splitContainerOpciones.Panel2.SuspendLayout();
            this.splitContainerOpciones.SuspendLayout();
            this.groupBoxArchivo.SuspendLayout();
            this.groupBoxColumnas.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Nessus Files (*.nessus)|*.nessus|All files (*.*)|*.*";
            // 
            // splitContainerFondo
            // 
            this.splitContainerFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFondo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFondo.Name = "splitContainerFondo";
            this.splitContainerFondo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFondo.Panel1
            // 
            this.splitContainerFondo.Panel1.Controls.Add(this.splitContainerOpciones);
            // 
            // splitContainerFondo.Panel2
            // 
            this.splitContainerFondo.Panel2.Controls.Add(this.LabelMensaje);
            this.splitContainerFondo.Size = new System.Drawing.Size(721, 342);
            this.splitContainerFondo.SplitterDistance = 294;
            this.splitContainerFondo.TabIndex = 0;
            // 
            // splitContainerOpciones
            // 
            this.splitContainerOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOpciones.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOpciones.Name = "splitContainerOpciones";
            // 
            // splitContainerOpciones.Panel1
            // 
            this.splitContainerOpciones.Panel1.Controls.Add(this.groupBoxArchivo);
            // 
            // splitContainerOpciones.Panel2
            // 
            this.splitContainerOpciones.Panel2.Controls.Add(this.groupBoxColumnas);
            this.splitContainerOpciones.Size = new System.Drawing.Size(721, 294);
            this.splitContainerOpciones.SplitterDistance = 446;
            this.splitContainerOpciones.TabIndex = 0;
            // 
            // groupBoxArchivo
            // 
            this.groupBoxArchivo.Controls.Add(this.label4);
            this.groupBoxArchivo.Controls.Add(this.label3);
            this.groupBoxArchivo.Controls.Add(this.textBoxSalida);
            this.groupBoxArchivo.Controls.Add(this.label2);
            this.groupBoxArchivo.Controls.Add(this.buttonEjecutar);
            this.groupBoxArchivo.Controls.Add(this.checkBoxSeveridad0);
            this.groupBoxArchivo.Controls.Add(this.buttonExaminar);
            this.groupBoxArchivo.Controls.Add(this.textBoxRutaArchivo);
            this.groupBoxArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxArchivo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxArchivo.Name = "groupBoxArchivo";
            this.groupBoxArchivo.Size = new System.Drawing.Size(446, 294);
            this.groupBoxArchivo.TabIndex = 0;
            this.groupBoxArchivo.TabStop = false;
            this.groupBoxArchivo.Text = "Archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre archivo de salida: ";
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(145, 117);
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(208, 20);
            this.textBoxSalida.TabIndex = 5;
            this.textBoxSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Archivo de entrada:";
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Enabled = false;
            this.buttonEjecutar.Location = new System.Drawing.Point(365, 265);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 3;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // checkBoxSeveridad0
            // 
            this.checkBoxSeveridad0.AutoSize = true;
            this.checkBoxSeveridad0.Location = new System.Drawing.Point(6, 222);
            this.checkBoxSeveridad0.Name = "checkBoxSeveridad0";
            this.checkBoxSeveridad0.Size = new System.Drawing.Size(163, 17);
            this.checkBoxSeveridad0.TabIndex = 2;
            this.checkBoxSeveridad0.Text = "Incluir items con severidad 0.";
            this.checkBoxSeveridad0.UseVisualStyleBackColor = true;
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point(359, 82);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 1;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.SeleccionarArchivo);
            // 
            // textBoxRutaArchivo
            // 
            this.textBoxRutaArchivo.Location = new System.Drawing.Point(115, 84);
            this.textBoxRutaArchivo.Name = "textBoxRutaArchivo";
            this.textBoxRutaArchivo.ReadOnly = true;
            this.textBoxRutaArchivo.Size = new System.Drawing.Size(238, 20);
            this.textBoxRutaArchivo.TabIndex = 0;
            // 
            // groupBoxColumnas
            // 
            this.groupBoxColumnas.Controls.Add(this.checkBoxInfoAdicional);
            this.groupBoxColumnas.Controls.Add(this.checkBoxSolucion);
            this.groupBoxColumnas.Controls.Add(this.checkBoxOS);
            this.groupBoxColumnas.Controls.Add(this.checkBoxCvss);
            this.groupBoxColumnas.Controls.Add(this.checkBoxIP);
            this.groupBoxColumnas.Controls.Add(this.checkBoxCve);
            this.groupBoxColumnas.Controls.Add(this.checkBoxSeveridad);
            this.groupBoxColumnas.Controls.Add(this.checkBoxNetBios);
            this.groupBoxColumnas.Controls.Add(this.checkBoxDescripcion);
            this.groupBoxColumnas.Controls.Add(this.checkBoxMac);
            this.groupBoxColumnas.Controls.Add(this.checkBoxPlugin);
            this.groupBoxColumnas.Controls.Add(this.checkBoxXref);
            this.groupBoxColumnas.Controls.Add(this.checkBoxBid);
            this.groupBoxColumnas.Controls.Add(this.checkBoxExploit);
            this.groupBoxColumnas.Controls.Add(this.checkBoxProtocolo);
            this.groupBoxColumnas.Controls.Add(this.checkBoxPuerto);
            this.groupBoxColumnas.Controls.Add(this.checkBoxSinopsis);
            this.groupBoxColumnas.Controls.Add(this.label1);
            this.groupBoxColumnas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxColumnas.Location = new System.Drawing.Point(0, 0);
            this.groupBoxColumnas.Name = "groupBoxColumnas";
            this.groupBoxColumnas.Size = new System.Drawing.Size(271, 294);
            this.groupBoxColumnas.TabIndex = 0;
            this.groupBoxColumnas.TabStop = false;
            this.groupBoxColumnas.Text = "Campos";
            // 
            // checkBoxInfoAdicional
            // 
            this.checkBoxInfoAdicional.AutoSize = true;
            this.checkBoxInfoAdicional.Location = new System.Drawing.Point(132, 199);
            this.checkBoxInfoAdicional.Name = "checkBoxInfoAdicional";
            this.checkBoxInfoAdicional.Size = new System.Drawing.Size(126, 17);
            this.checkBoxInfoAdicional.TabIndex = 23;
            this.checkBoxInfoAdicional.Text = "Información adicional";
            this.checkBoxInfoAdicional.UseVisualStyleBackColor = true;
            // 
            // checkBoxSolucion
            // 
            this.checkBoxSolucion.AutoSize = true;
            this.checkBoxSolucion.Checked = true;
            this.checkBoxSolucion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSolucion.Location = new System.Drawing.Point(15, 107);
            this.checkBoxSolucion.Name = "checkBoxSolucion";
            this.checkBoxSolucion.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSolucion.TabIndex = 10;
            this.checkBoxSolucion.Text = "Solución";
            this.checkBoxSolucion.UseVisualStyleBackColor = true;
            // 
            // checkBoxOS
            // 
            this.checkBoxOS.AutoSize = true;
            this.checkBoxOS.Location = new System.Drawing.Point(132, 222);
            this.checkBoxOS.Name = "checkBoxOS";
            this.checkBoxOS.Size = new System.Drawing.Size(112, 17);
            this.checkBoxOS.TabIndex = 22;
            this.checkBoxOS.Text = "Sistema Operativo";
            this.checkBoxOS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCvss
            // 
            this.checkBoxCvss.AutoSize = true;
            this.checkBoxCvss.Location = new System.Drawing.Point(132, 176);
            this.checkBoxCvss.Name = "checkBoxCvss";
            this.checkBoxCvss.Size = new System.Drawing.Size(87, 17);
            this.checkBoxCvss.TabIndex = 21;
            this.checkBoxCvss.Text = "Puntaje cvss";
            this.checkBoxCvss.UseVisualStyleBackColor = true;
            // 
            // checkBoxIP
            // 
            this.checkBoxIP.AutoSize = true;
            this.checkBoxIP.Checked = true;
            this.checkBoxIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIP.Enabled = false;
            this.checkBoxIP.Location = new System.Drawing.Point(132, 63);
            this.checkBoxIP.Name = "checkBoxIP";
            this.checkBoxIP.Size = new System.Drawing.Size(84, 17);
            this.checkBoxIP.TabIndex = 20;
            this.checkBoxIP.Text = "Dirección IP";
            this.checkBoxIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxCve
            // 
            this.checkBoxCve.AutoSize = true;
            this.checkBoxCve.Checked = true;
            this.checkBoxCve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCve.Location = new System.Drawing.Point(132, 153);
            this.checkBoxCve.Name = "checkBoxCve";
            this.checkBoxCve.Size = new System.Drawing.Size(44, 17);
            this.checkBoxCve.TabIndex = 19;
            this.checkBoxCve.Text = "cve";
            this.checkBoxCve.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeveridad
            // 
            this.checkBoxSeveridad.AutoSize = true;
            this.checkBoxSeveridad.Checked = true;
            this.checkBoxSeveridad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSeveridad.Location = new System.Drawing.Point(132, 130);
            this.checkBoxSeveridad.Name = "checkBoxSeveridad";
            this.checkBoxSeveridad.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSeveridad.TabIndex = 18;
            this.checkBoxSeveridad.Text = "Severidad";
            this.checkBoxSeveridad.UseVisualStyleBackColor = true;
            // 
            // checkBoxNetBios
            // 
            this.checkBoxNetBios.AutoSize = true;
            this.checkBoxNetBios.Checked = true;
            this.checkBoxNetBios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNetBios.Location = new System.Drawing.Point(132, 107);
            this.checkBoxNetBios.Name = "checkBoxNetBios";
            this.checkBoxNetBios.Size = new System.Drawing.Size(94, 17);
            this.checkBoxNetBios.TabIndex = 17;
            this.checkBoxNetBios.Text = "Net-bios name";
            this.checkBoxNetBios.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Checked = true;
            this.checkBoxDescripcion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(132, 86);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDescripcion.TabIndex = 16;
            this.checkBoxDescripcion.Text = "Descripción";
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            // 
            // checkBoxMac
            // 
            this.checkBoxMac.AutoSize = true;
            this.checkBoxMac.Location = new System.Drawing.Point(15, 247);
            this.checkBoxMac.Name = "checkBoxMac";
            this.checkBoxMac.Size = new System.Drawing.Size(94, 17);
            this.checkBoxMac.TabIndex = 15;
            this.checkBoxMac.Text = "Dirección mac";
            this.checkBoxMac.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlugin
            // 
            this.checkBoxPlugin.AutoSize = true;
            this.checkBoxPlugin.Location = new System.Drawing.Point(15, 201);
            this.checkBoxPlugin.Name = "checkBoxPlugin";
            this.checkBoxPlugin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxPlugin.TabIndex = 13;
            this.checkBoxPlugin.Text = "Plug-in name";
            this.checkBoxPlugin.UseVisualStyleBackColor = true;
            // 
            // checkBoxXref
            // 
            this.checkBoxXref.AutoSize = true;
            this.checkBoxXref.Location = new System.Drawing.Point(15, 224);
            this.checkBoxXref.Name = "checkBoxXref";
            this.checkBoxXref.Size = new System.Drawing.Size(43, 17);
            this.checkBoxXref.TabIndex = 12;
            this.checkBoxXref.Text = "xref";
            this.checkBoxXref.UseVisualStyleBackColor = true;
            // 
            // checkBoxBid
            // 
            this.checkBoxBid.AutoSize = true;
            this.checkBoxBid.Location = new System.Drawing.Point(15, 178);
            this.checkBoxBid.Name = "checkBoxBid";
            this.checkBoxBid.Size = new System.Drawing.Size(40, 17);
            this.checkBoxBid.TabIndex = 11;
            this.checkBoxBid.Text = "bid";
            this.checkBoxBid.UseVisualStyleBackColor = true;
            // 
            // checkBoxExploit
            // 
            this.checkBoxExploit.AutoSize = true;
            this.checkBoxExploit.Checked = true;
            this.checkBoxExploit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExploit.Location = new System.Drawing.Point(15, 155);
            this.checkBoxExploit.Name = "checkBoxExploit";
            this.checkBoxExploit.Size = new System.Drawing.Size(107, 17);
            this.checkBoxExploit.TabIndex = 4;
            this.checkBoxExploit.Text = "Exploit disponible";
            this.checkBoxExploit.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtocolo
            // 
            this.checkBoxProtocolo.AutoSize = true;
            this.checkBoxProtocolo.Checked = true;
            this.checkBoxProtocolo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProtocolo.Location = new System.Drawing.Point(15, 132);
            this.checkBoxProtocolo.Name = "checkBoxProtocolo";
            this.checkBoxProtocolo.Size = new System.Drawing.Size(71, 17);
            this.checkBoxProtocolo.TabIndex = 3;
            this.checkBoxProtocolo.Text = "Protocolo";
            this.checkBoxProtocolo.UseVisualStyleBackColor = true;
            // 
            // checkBoxPuerto
            // 
            this.checkBoxPuerto.AutoSize = true;
            this.checkBoxPuerto.Checked = true;
            this.checkBoxPuerto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPuerto.Enabled = false;
            this.checkBoxPuerto.Location = new System.Drawing.Point(15, 86);
            this.checkBoxPuerto.Name = "checkBoxPuerto";
            this.checkBoxPuerto.Size = new System.Drawing.Size(57, 17);
            this.checkBoxPuerto.TabIndex = 2;
            this.checkBoxPuerto.Text = "Puerto";
            this.checkBoxPuerto.UseVisualStyleBackColor = true;
            // 
            // checkBoxSinopsis
            // 
            this.checkBoxSinopsis.AutoSize = true;
            this.checkBoxSinopsis.Checked = true;
            this.checkBoxSinopsis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSinopsis.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxSinopsis.Enabled = false;
            this.checkBoxSinopsis.Location = new System.Drawing.Point(15, 63);
            this.checkBoxSinopsis.Name = "checkBoxSinopsis";
            this.checkBoxSinopsis.Size = new System.Drawing.Size(65, 17);
            this.checkBoxSinopsis.TabIndex = 1;
            this.checkBoxSinopsis.Text = "Sinopsis";
            this.checkBoxSinopsis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar los campos de las vulnerabilidades que se van a imprimir en el archiv" +
    "o de salida.";
            // 
            // LabelMensaje
            // 
            this.LabelMensaje.AutoSize = true;
            this.LabelMensaje.Location = new System.Drawing.Point(12, 10);
            this.LabelMensaje.Name = "LabelMensaje";
            this.LabelMensaje.Size = new System.Drawing.Size(365, 13);
            this.LabelMensaje.TabIndex = 0;
            this.LabelMensaje.Text = "Seleccionar un archivo nessus y oprimir el botón \"Ejecutar\" para procesarlo.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ".cvs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 342);
            this.Controls.Add(this.splitContainerFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Parser Nessus";
            this.splitContainerFondo.Panel1.ResumeLayout(false);
            this.splitContainerFondo.Panel2.ResumeLayout(false);
            this.splitContainerFondo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFondo)).EndInit();
            this.splitContainerFondo.ResumeLayout(false);
            this.splitContainerOpciones.Panel1.ResumeLayout(false);
            this.splitContainerOpciones.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOpciones)).EndInit();
            this.splitContainerOpciones.ResumeLayout(false);
            this.groupBoxArchivo.ResumeLayout(false);
            this.groupBoxArchivo.PerformLayout();
            this.groupBoxColumnas.ResumeLayout(false);
            this.groupBoxColumnas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainerFondo;
        private System.Windows.Forms.SplitContainer splitContainerOpciones;
        private System.Windows.Forms.GroupBox groupBoxArchivo;
        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.Windows.Forms.GroupBox groupBoxColumnas;
        private System.Windows.Forms.Label LabelMensaje;
        private System.Windows.Forms.CheckBox checkBoxSeveridad0;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSolucion;
        private System.Windows.Forms.CheckBox checkBoxExploit;
        private System.Windows.Forms.CheckBox checkBoxProtocolo;
        private System.Windows.Forms.CheckBox checkBoxPuerto;
        private System.Windows.Forms.CheckBox checkBoxSinopsis;
        private System.Windows.Forms.CheckBox checkBoxInfoAdicional;
        private System.Windows.Forms.CheckBox checkBoxOS;
        private System.Windows.Forms.CheckBox checkBoxCvss;
        private System.Windows.Forms.CheckBox checkBoxIP;
        private System.Windows.Forms.CheckBox checkBoxCve;
        private System.Windows.Forms.CheckBox checkBoxSeveridad;
        private System.Windows.Forms.CheckBox checkBoxNetBios;
        private System.Windows.Forms.CheckBox checkBoxDescripcion;
        private System.Windows.Forms.CheckBox checkBoxMac;
        private System.Windows.Forms.CheckBox checkBoxPlugin;
        private System.Windows.Forms.CheckBox checkBoxXref;
        private System.Windows.Forms.CheckBox checkBoxBid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

