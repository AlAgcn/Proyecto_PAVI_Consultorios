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
            this.gbxAtencion = new System.Windows.Forms.GroupBox();
            this.dtpHoy = new System.Windows.Forms.DateTimePicker();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.rcbActual = new System.Windows.Forms.RichTextBox();
            this.rcbAnterior = new System.Windows.Forms.RichTextBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.gbxSOAP = new System.Windows.Forms.GroupBox();
            this.gbxAtencion.SuspendLayout();
            this.gbxSOAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMotivos
            // 
            this.cmdMotivos.Location = new System.Drawing.Point(19, 41);
            this.cmdMotivos.Name = "cmdMotivos";
            this.cmdMotivos.Size = new System.Drawing.Size(136, 44);
            this.cmdMotivos.TabIndex = 0;
            this.cmdMotivos.Text = "Motivos";
            this.cmdMotivos.UseVisualStyleBackColor = true;
            this.cmdMotivos.Click += new System.EventHandler(this.cmdMotivos_Click);
            // 
            // cmdRevision
            // 
            this.cmdRevision.Location = new System.Drawing.Point(19, 110);
            this.cmdRevision.Name = "cmdRevision";
            this.cmdRevision.Size = new System.Drawing.Size(136, 44);
            this.cmdRevision.TabIndex = 1;
            this.cmdRevision.Text = "Revision";
            this.cmdRevision.UseVisualStyleBackColor = true;
            this.cmdRevision.Click += new System.EventHandler(this.cmdRevision_Click);
            // 
            // cmdPlan
            // 
            this.cmdPlan.Location = new System.Drawing.Point(19, 276);
            this.cmdPlan.Name = "cmdPlan";
            this.cmdPlan.Size = new System.Drawing.Size(136, 44);
            this.cmdPlan.TabIndex = 2;
            this.cmdPlan.Text = "Plan Terapeutico";
            this.cmdPlan.UseVisualStyleBackColor = true;
            this.cmdPlan.Click += new System.EventHandler(this.cmdPlan_Click);
            // 
            // cmdDiagnostico
            // 
            this.cmdDiagnostico.Location = new System.Drawing.Point(19, 189);
            this.cmdDiagnostico.Name = "cmdDiagnostico";
            this.cmdDiagnostico.Size = new System.Drawing.Size(136, 44);
            this.cmdDiagnostico.TabIndex = 3;
            this.cmdDiagnostico.Text = "Diagnostico";
            this.cmdDiagnostico.UseVisualStyleBackColor = true;
            this.cmdDiagnostico.Click += new System.EventHandler(this.cmdDiagnostico_Click);
            // 
            // cmdObservacion
            // 
            this.cmdObservacion.Location = new System.Drawing.Point(19, 377);
            this.cmdObservacion.Name = "cmdObservacion";
            this.cmdObservacion.Size = new System.Drawing.Size(136, 44);
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
            this.cmdBuffer.Click += new System.EventHandler(this.cmdBuffer_Click);
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
            // gbxAtencion
            // 
            this.gbxAtencion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxAtencion.Controls.Add(this.dtpHoy);
            this.gbxAtencion.Controls.Add(this.lblAnterior);
            this.gbxAtencion.Controls.Add(this.lblActual);
            this.gbxAtencion.Controls.Add(this.rcbActual);
            this.gbxAtencion.Controls.Add(this.rcbAnterior);
            this.gbxAtencion.Location = new System.Drawing.Point(239, 122);
            this.gbxAtencion.Name = "gbxAtencion";
            this.gbxAtencion.Size = new System.Drawing.Size(433, 344);
            this.gbxAtencion.TabIndex = 8;
            this.gbxAtencion.TabStop = false;
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
            // rcbActual
            // 
            this.rcbActual.Location = new System.Drawing.Point(17, 241);
            this.rcbActual.Name = "rcbActual";
            this.rcbActual.Size = new System.Drawing.Size(380, 75);
            this.rcbActual.TabIndex = 1;
            this.rcbActual.Text = "";
            // 
            // rcbAnterior
            // 
            this.rcbAnterior.Location = new System.Drawing.Point(17, 79);
            this.rcbAnterior.Name = "rcbAnterior";
            this.rcbAnterior.Size = new System.Drawing.Size(380, 75);
            this.rcbAnterior.TabIndex = 0;
            this.rcbAnterior.Text = "";
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
            // gbxSOAP
            // 
            this.gbxSOAP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxSOAP.Controls.Add(this.cmdObservacion);
            this.gbxSOAP.Controls.Add(this.cmdPlan);
            this.gbxSOAP.Controls.Add(this.cmdDiagnostico);
            this.gbxSOAP.Controls.Add(this.cmdRevision);
            this.gbxSOAP.Controls.Add(this.cmdMotivos);
            this.gbxSOAP.Location = new System.Drawing.Point(12, 22);
            this.gbxSOAP.Name = "gbxSOAP";
            this.gbxSOAP.Size = new System.Drawing.Size(172, 468);
            this.gbxSOAP.TabIndex = 14;
            this.gbxSOAP.TabStop = false;
            this.gbxSOAP.Text = "S.O.A.P";
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
            this.Controls.Add(this.gbxAtencion);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBuffer);
            this.Controls.Add(this.cmdAgregarAtencion);
            this.Controls.Add(this.gbxSOAP);
            this.Name = "frmAtencion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAtencion_Load);
            this.gbxAtencion.ResumeLayout(false);
            this.gbxAtencion.PerformLayout();
            this.gbxSOAP.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbxAtencion;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.RichTextBox rcbActual;
        private System.Windows.Forms.RichTextBox rcbAnterior;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.GroupBox gbxSOAP;
        private System.Windows.Forms.DateTimePicker dtpHoy;
    }
}

