namespace ProyectoPav
{
    partial class frmAtencion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdMotivos = new System.Windows.Forms.Button();
            this.cmdRevision = new System.Windows.Forms.Button();
            this.cmdPlan = new System.Windows.Forms.Button();
            this.cmdDiagnostico = new System.Windows.Forms.Button();
            this.cmdObservacion = new System.Windows.Forms.Button();
            this.cmdAgregarAtencion = new System.Windows.Forms.Button();
            this.cmdBuffer = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.gpbAtencion = new System.Windows.Forms.GroupBox();
            this.dtpHoy = new System.Windows.Forms.DateTimePicker();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gpbAtencion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMotivos
            // 
            this.cmdMotivos.Location = new System.Drawing.Point(19, 22);
            this.cmdMotivos.Name = "cmdMotivos";
            this.cmdMotivos.Size = new System.Drawing.Size(108, 63);
            this.cmdMotivos.TabIndex = 0;
            this.cmdMotivos.Text = "Motivos";
            this.cmdMotivos.UseVisualStyleBackColor = true;
            this.cmdMotivos.Click += new System.EventHandler(this.cmdMotivos_Click);
            // 
            // cmdRevision
            // 
            this.cmdRevision.Location = new System.Drawing.Point(19, 91);
            this.cmdRevision.Name = "cmdRevision";
            this.cmdRevision.Size = new System.Drawing.Size(108, 59);
            this.cmdRevision.TabIndex = 1;
            this.cmdRevision.Text = "Revision";
            this.cmdRevision.UseVisualStyleBackColor = true;
            this.cmdRevision.Click += new System.EventHandler(this.cmdRevision_Click);
            // 
            // cmdPlan
            // 
            this.cmdPlan.Location = new System.Drawing.Point(19, 257);
            this.cmdPlan.Name = "cmdPlan";
            this.cmdPlan.Size = new System.Drawing.Size(108, 75);
            this.cmdPlan.TabIndex = 2;
            this.cmdPlan.Text = "Plan Terapeutico";
            this.cmdPlan.UseVisualStyleBackColor = true;
            this.cmdPlan.Click += new System.EventHandler(this.cmdPlan_Click);
            // 
            // cmdDiagnostico
            // 
            this.cmdDiagnostico.Location = new System.Drawing.Point(19, 170);
            this.cmdDiagnostico.Name = "cmdDiagnostico";
            this.cmdDiagnostico.Size = new System.Drawing.Size(108, 70);
            this.cmdDiagnostico.TabIndex = 3;
            this.cmdDiagnostico.Text = "Diagnostico";
            this.cmdDiagnostico.UseVisualStyleBackColor = true;
            this.cmdDiagnostico.Click += new System.EventHandler(this.cmdDiagnostico_Click);
            // 
            // cmdObservacion
            // 
            this.cmdObservacion.Location = new System.Drawing.Point(19, 358);
            this.cmdObservacion.Name = "cmdObservacion";
            this.cmdObservacion.Size = new System.Drawing.Size(108, 75);
            this.cmdObservacion.TabIndex = 4;
            this.cmdObservacion.Text = "Observacion";
            this.cmdObservacion.UseVisualStyleBackColor = true;
            this.cmdObservacion.Click += new System.EventHandler(this.cmdObservacion_Click);
            // 
            // cmdAgregarAtencion
            // 
            this.cmdAgregarAtencion.Location = new System.Drawing.Point(31, 508);
            this.cmdAgregarAtencion.Name = "cmdAgregarAtencion";
            this.cmdAgregarAtencion.Size = new System.Drawing.Size(153, 23);
            this.cmdAgregarAtencion.TabIndex = 5;
            this.cmdAgregarAtencion.Text = "Agregar atencion";
            this.cmdAgregarAtencion.UseVisualStyleBackColor = true;
            // 
            // cmdBuffer
            // 
            this.cmdBuffer.Location = new System.Drawing.Point(222, 508);
            this.cmdBuffer.Name = "cmdBuffer";
            this.cmdBuffer.Size = new System.Drawing.Size(75, 23);
            this.cmdBuffer.TabIndex = 6;
            this.cmdBuffer.Text = "Guardar";
            this.cmdBuffer.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(682, 497);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 7;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // gpbAtencion
            // 
            this.gpbAtencion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbAtencion.Controls.Add(this.dtpHoy);
            this.gpbAtencion.Controls.Add(this.lblAnterior);
            this.gpbAtencion.Controls.Add(this.lblActual);
            this.gpbAtencion.Controls.Add(this.richTextBox2);
            this.gpbAtencion.Controls.Add(this.richTextBox1);
            this.gpbAtencion.Location = new System.Drawing.Point(239, 122);
            this.gpbAtencion.Name = "gpbAtencion";
            this.gpbAtencion.Size = new System.Drawing.Size(433, 344);
            this.gpbAtencion.TabIndex = 8;
            this.gpbAtencion.TabStop = false;
            this.gpbAtencion.Text = "groupBox1";
            // 
            // dtpHoy
            // 
            this.dtpHoy.Enabled = false;
            this.dtpHoy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHoy.Location = new System.Drawing.Point(165, 212);
            this.dtpHoy.Name = "dtpHoy";
            this.dtpHoy.Size = new System.Drawing.Size(200, 20);
            this.dtpHoy.TabIndex = 14;
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Location = new System.Drawing.Point(23, 63);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(35, 13);
            this.lblAnterior.TabIndex = 13;
            this.lblAnterior.Text = "label5";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(23, 219);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(35, 13);
            this.lblActual.TabIndex = 12;
            this.lblActual.Text = "label4";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 241);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(380, 75);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(380, 75);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(239, 33);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(35, 13);
            this.lblMedico.TabIndex = 9;
            this.lblMedico.Text = "label1";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(239, 94);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(35, 13);
            this.lblPaciente.TabIndex = 10;
            this.lblPaciente.Text = "label2";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(401, 94);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(35, 13);
            this.lblHistorial.TabIndex = 11;
            this.lblHistorial.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.cmdObservacion);
            this.groupBox2.Controls.Add(this.cmdPlan);
            this.groupBox2.Controls.Add(this.cmdDiagnostico);
            this.groupBox2.Controls.Add(this.cmdRevision);
            this.groupBox2.Controls.Add(this.cmdMotivos);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 468);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 576);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.gpbAtencion);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBuffer);
            this.Controls.Add(this.cmdAgregarAtencion);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmAtencion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAtencion_Load);
            this.gpbAtencion.ResumeLayout(false);
            this.gpbAtencion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMotivos;
        private System.Windows.Forms.Button cmdRevision;
        private System.Windows.Forms.Button cmdPlan;
        private System.Windows.Forms.Button cmdDiagnostico;
        private System.Windows.Forms.Button cmdObservacion;
        private System.Windows.Forms.Button cmdAgregarAtencion;
        private System.Windows.Forms.Button cmdBuffer;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.GroupBox gpbAtencion;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHoy;
    }
}

