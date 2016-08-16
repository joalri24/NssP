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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerFondo = new System.Windows.Forms.SplitContainer();
            this.splitContainerOpciones = new System.Windows.Forms.SplitContainer();
            this.groupBoxArchivo = new System.Windows.Forms.GroupBox();
            this.groupBoxColumnas = new System.Windows.Forms.GroupBox();
            this.Mensaje = new System.Windows.Forms.Label();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFondo)).BeginInit();
            this.splitContainerFondo.Panel1.SuspendLayout();
            this.splitContainerFondo.Panel2.SuspendLayout();
            this.splitContainerFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOpciones)).BeginInit();
            this.splitContainerOpciones.Panel1.SuspendLayout();
            this.splitContainerOpciones.Panel2.SuspendLayout();
            this.splitContainerOpciones.SuspendLayout();
            this.groupBoxArchivo.SuspendLayout();
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
            this.splitContainerFondo.Panel2.Controls.Add(this.Mensaje);
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
            this.groupBoxArchivo.Controls.Add(this.buttonEjecutar);
            this.groupBoxArchivo.Controls.Add(this.checkBox1);
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
            // groupBoxColumnas
            // 
            this.groupBoxColumnas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxColumnas.Location = new System.Drawing.Point(0, 0);
            this.groupBoxColumnas.Name = "groupBoxColumnas";
            this.groupBoxColumnas.Size = new System.Drawing.Size(271, 294);
            this.groupBoxColumnas.TabIndex = 0;
            this.groupBoxColumnas.TabStop = false;
            this.groupBoxColumnas.Text = "Campos";
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(12, 10);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(365, 13);
            this.Mensaje.TabIndex = 0;
            this.Mensaje.Text = "Seleccionar un archivo nessus y oprimir el botón \"Ejecutar\" para procesarlo.";
            // 
            // textBoxRutaArchivo
            // 
            this.textBoxRutaArchivo.Location = new System.Drawing.Point(12, 29);
            this.textBoxRutaArchivo.Name = "textBoxRutaArchivo";
            this.textBoxRutaArchivo.ReadOnly = true;
            this.textBoxRutaArchivo.Size = new System.Drawing.Size(347, 20);
            this.textBoxRutaArchivo.TabIndex = 0;
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point(365, 27);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 1;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.SeleccionarArchivo);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Incluir items con severidad 0.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(365, 265);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 3;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 342);
            this.Controls.Add(this.splitContainerFondo);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainerFondo;
        private System.Windows.Forms.SplitContainer splitContainerOpciones;
        private System.Windows.Forms.GroupBox groupBoxArchivo;
        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.Windows.Forms.GroupBox groupBoxColumnas;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.Button buttonEjecutar;
    }
}

