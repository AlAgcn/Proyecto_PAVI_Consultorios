namespace ProyectoPav
{
    partial class frmAtencion1
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
            this.tbcAtencion = new System.Windows.Forms.TabControl();
            this.tbpMotivo = new System.Windows.Forms.TabPage();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.rtbMotivoAns = new System.Windows.Forms.RichTextBox();
            this.tbpRevision = new System.Windows.Forms.TabPage();
            this.rtbRevison = new System.Windows.Forms.RichTextBox();
            this.rtbRevisionAns = new System.Windows.Forms.RichTextBox();
            this.tbpDiagnostico = new System.Windows.Forms.TabPage();
            this.rtbDiagnostico = new System.Windows.Forms.RichTextBox();
            this.rtbDiagnosticoAns = new System.Windows.Forms.RichTextBox();
            this.tbpPlan = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblDieta = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.lstMedicamentos = new System.Windows.Forms.ListBox();
            this.cboDietas = new System.Windows.Forms.ComboBox();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.id_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monodroga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpObservacion = new System.Windows.Forms.TabPage();
            this.rtbObservacion = new System.Windows.Forms.RichTextBox();
            this.rtbObservacionAns = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarTodo = new System.Windows.Forms.Button();
            this.gpbDataPaciente = new System.Windows.Forms.GroupBox();
            this.lblHistoriaClinica = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbcAtencion.SuspendLayout();
            this.tbpMotivo.SuspendLayout();
            this.tbpRevision.SuspendLayout();
            this.tbpDiagnostico.SuspendLayout();
            this.tbpPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.tbpObservacion.SuspendLayout();
            this.gpbDataPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAtencion
            // 
            this.tbcAtencion.Controls.Add(this.tbpMotivo);
            this.tbcAtencion.Controls.Add(this.tbpRevision);
            this.tbcAtencion.Controls.Add(this.tbpDiagnostico);
            this.tbcAtencion.Controls.Add(this.tbpPlan);
            this.tbcAtencion.Controls.Add(this.tbpObservacion);
            this.tbcAtencion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbcAtencion.Location = new System.Drawing.Point(0, 117);
            this.tbcAtencion.Name = "tbcAtencion";
            this.tbcAtencion.SelectedIndex = 0;
            this.tbcAtencion.Size = new System.Drawing.Size(672, 292);
            this.tbcAtencion.TabIndex = 0;
            // 
            // tbpMotivo
            // 
            this.tbpMotivo.Controls.Add(this.rtbMotivo);
            this.tbpMotivo.Controls.Add(this.rtbMotivoAns);
            this.tbpMotivo.Location = new System.Drawing.Point(4, 22);
            this.tbpMotivo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbpMotivo.Name = "tbpMotivo";
            this.tbpMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMotivo.Size = new System.Drawing.Size(664, 266);
            this.tbpMotivo.TabIndex = 0;
            this.tbpMotivo.Text = "Motivo";
            this.tbpMotivo.UseVisualStyleBackColor = true;
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.Location = new System.Drawing.Point(274, 104);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(382, 154);
            this.rtbMotivo.TabIndex = 15;
            this.rtbMotivo.Text = "";
            // 
            // rtbMotivoAns
            // 
            this.rtbMotivoAns.BackColor = System.Drawing.Color.Silver;
            this.rtbMotivoAns.Enabled = false;
            this.rtbMotivoAns.Location = new System.Drawing.Point(8, 3);
            this.rtbMotivoAns.Name = "rtbMotivoAns";
            this.rtbMotivoAns.Size = new System.Drawing.Size(244, 260);
            this.rtbMotivoAns.TabIndex = 14;
            this.rtbMotivoAns.Text = "";
            // 
            // tbpRevision
            // 
            this.tbpRevision.Controls.Add(this.rtbRevison);
            this.tbpRevision.Controls.Add(this.rtbRevisionAns);
            this.tbpRevision.Location = new System.Drawing.Point(4, 22);
            this.tbpRevision.Name = "tbpRevision";
            this.tbpRevision.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRevision.Size = new System.Drawing.Size(664, 266);
            this.tbpRevision.TabIndex = 1;
            this.tbpRevision.Text = "Revision";
            this.tbpRevision.UseVisualStyleBackColor = true;
            // 
            // rtbRevison
            // 
            this.rtbRevison.Location = new System.Drawing.Point(258, 106);
            this.rtbRevison.Name = "rtbRevison";
            this.rtbRevison.Size = new System.Drawing.Size(398, 154);
            this.rtbRevison.TabIndex = 15;
            this.rtbRevison.Text = "";
            // 
            // rtbRevisionAns
            // 
            this.rtbRevisionAns.BackColor = System.Drawing.Color.Silver;
            this.rtbRevisionAns.Enabled = false;
            this.rtbRevisionAns.Location = new System.Drawing.Point(3, 3);
            this.rtbRevisionAns.Name = "rtbRevisionAns";
            this.rtbRevisionAns.Size = new System.Drawing.Size(244, 260);
            this.rtbRevisionAns.TabIndex = 14;
            this.rtbRevisionAns.Text = "";
            // 
            // tbpDiagnostico
            // 
            this.tbpDiagnostico.Controls.Add(this.rtbDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.rtbDiagnosticoAns);
            this.tbpDiagnostico.Location = new System.Drawing.Point(4, 22);
            this.tbpDiagnostico.Name = "tbpDiagnostico";
            this.tbpDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiagnostico.Size = new System.Drawing.Size(664, 266);
            this.tbpDiagnostico.TabIndex = 2;
            this.tbpDiagnostico.Text = "Diagnostico";
            this.tbpDiagnostico.UseVisualStyleBackColor = true;
            // 
            // rtbDiagnostico
            // 
            this.rtbDiagnostico.Location = new System.Drawing.Point(256, 106);
            this.rtbDiagnostico.Name = "rtbDiagnostico";
            this.rtbDiagnostico.Size = new System.Drawing.Size(400, 154);
            this.rtbDiagnostico.TabIndex = 15;
            this.rtbDiagnostico.Text = "";
            // 
            // rtbDiagnosticoAns
            // 
            this.rtbDiagnosticoAns.BackColor = System.Drawing.Color.Silver;
            this.rtbDiagnosticoAns.Enabled = false;
            this.rtbDiagnosticoAns.Location = new System.Drawing.Point(3, 3);
            this.rtbDiagnosticoAns.Name = "rtbDiagnosticoAns";
            this.rtbDiagnosticoAns.Size = new System.Drawing.Size(244, 260);
            this.rtbDiagnosticoAns.TabIndex = 14;
            this.rtbDiagnosticoAns.Text = "";
            // 
            // tbpPlan
            // 
            this.tbpPlan.Controls.Add(this.btnGuardar);
            this.tbpPlan.Controls.Add(this.btnCancelar);
            this.tbpPlan.Controls.Add(this.btnAgregar);
            this.tbpPlan.Controls.Add(this.lblLista);
            this.tbpPlan.Controls.Add(this.lblDieta);
            this.tbpPlan.Controls.Add(this.lblFrecuencia);
            this.tbpPlan.Controls.Add(this.lblDuracion);
            this.tbpPlan.Controls.Add(this.txtDuracion);
            this.tbpPlan.Controls.Add(this.txtFrecuencia);
            this.tbpPlan.Controls.Add(this.lstMedicamentos);
            this.tbpPlan.Controls.Add(this.cboDietas);
            this.tbpPlan.Controls.Add(this.dgvMedicamentos);
            this.tbpPlan.Location = new System.Drawing.Point(4, 22);
            this.tbpPlan.Name = "tbpPlan";
            this.tbpPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPlan.Size = new System.Drawing.Size(664, 266);
            this.tbpPlan.TabIndex = 3;
            this.tbpPlan.Text = "Plan Terapeutico";
            this.tbpPlan.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(602, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(62, 28);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(602, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(513, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(0, 90);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(128, 13);
            this.lblLista.TabIndex = 8;
            this.lblLista.Text = "Listado de Medicamentos";
            // 
            // lblDieta
            // 
            this.lblDieta.AutoSize = true;
            this.lblDieta.Location = new System.Drawing.Point(3, 36);
            this.lblDieta.Name = "lblDieta";
            this.lblDieta.Size = new System.Drawing.Size(32, 13);
            this.lblDieta.TabIndex = 7;
            this.lblDieta.Text = "Dieta";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(143, 49);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(60, 13);
            this.lblFrecuencia.TabIndex = 6;
            this.lblFrecuencia.Text = "Frecuencia";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(339, 49);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duracion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(395, 49);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 20);
            this.txtDuracion.TabIndex = 4;
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(209, 49);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtFrecuencia.TabIndex = 3;
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.Location = new System.Drawing.Point(3, 116);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(125, 147);
            this.lstMedicamentos.TabIndex = 2;
            // 
            // cboDietas
            // 
            this.cboDietas.FormattingEnabled = true;
            this.cboDietas.Location = new System.Drawing.Point(3, 52);
            this.cboDietas.Name = "cboDietas";
            this.cboDietas.Size = new System.Drawing.Size(120, 21);
            this.cboDietas.TabIndex = 1;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_medicamento,
            this.monodroga,
            this.farmaco,
            this.frecuencia,
            this.duracion,
            this.laboratorio});
            this.dgvMedicamentos.Location = new System.Drawing.Point(154, 116);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(442, 150);
            this.dgvMedicamentos.TabIndex = 0;
            // 
            // id_medicamento
            // 
            this.id_medicamento.HeaderText = "ID";
            this.id_medicamento.Name = "id_medicamento";
            this.id_medicamento.Width = 30;
            // 
            // monodroga
            // 
            this.monodroga.HeaderText = "Monodroga";
            this.monodroga.Name = "monodroga";
            // 
            // farmaco
            // 
            this.farmaco.HeaderText = "Farmaco";
            this.farmaco.Name = "farmaco";
            // 
            // frecuencia
            // 
            this.frecuencia.HeaderText = "Frecuencia";
            this.frecuencia.Name = "frecuencia";
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            // 
            // laboratorio
            // 
            this.laboratorio.HeaderText = "Laboratorio";
            this.laboratorio.Name = "laboratorio";
            // 
            // tbpObservacion
            // 
            this.tbpObservacion.Controls.Add(this.rtbObservacion);
            this.tbpObservacion.Controls.Add(this.rtbObservacionAns);
            this.tbpObservacion.Location = new System.Drawing.Point(4, 22);
            this.tbpObservacion.Name = "tbpObservacion";
            this.tbpObservacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpObservacion.Size = new System.Drawing.Size(664, 266);
            this.tbpObservacion.TabIndex = 4;
            this.tbpObservacion.Text = "Observacion";
            this.tbpObservacion.UseVisualStyleBackColor = true;
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.Location = new System.Drawing.Point(250, 104);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(406, 154);
            this.rtbObservacion.TabIndex = 1;
            this.rtbObservacion.Text = "";
            // 
            // rtbObservacionAns
            // 
            this.rtbObservacionAns.BackColor = System.Drawing.Color.Silver;
            this.rtbObservacionAns.Enabled = false;
            this.rtbObservacionAns.Location = new System.Drawing.Point(3, 3);
            this.rtbObservacionAns.Name = "rtbObservacionAns";
            this.rtbObservacionAns.Size = new System.Drawing.Size(244, 260);
            this.rtbObservacionAns.TabIndex = 0;
            this.rtbObservacionAns.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(598, 84);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 27);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarTodo
            // 
            this.btnGuardarTodo.Location = new System.Drawing.Point(460, 88);
            this.btnGuardarTodo.Name = "btnGuardarTodo";
            this.btnGuardarTodo.Size = new System.Drawing.Size(111, 23);
            this.btnGuardarTodo.TabIndex = 10;
            this.btnGuardarTodo.Text = "Guardar Atencion";
            this.btnGuardarTodo.UseVisualStyleBackColor = true;
            this.btnGuardarTodo.Click += new System.EventHandler(this.btnGuardarTodo_Click);
            // 
            // gpbDataPaciente
            // 
            this.gpbDataPaciente.Controls.Add(this.lblHistoriaClinica);
            this.gpbDataPaciente.Controls.Add(this.lblNombre);
            this.gpbDataPaciente.Location = new System.Drawing.Point(0, 0);
            this.gpbDataPaciente.Name = "gpbDataPaciente";
            this.gpbDataPaciente.Size = new System.Drawing.Size(282, 100);
            this.gpbDataPaciente.TabIndex = 11;
            this.gpbDataPaciente.TabStop = false;
            this.gpbDataPaciente.Text = "Datos del Paciente";
            // 
            // lblHistoriaClinica
            // 
            this.lblHistoriaClinica.AutoSize = true;
            this.lblHistoriaClinica.Location = new System.Drawing.Point(12, 66);
            this.lblHistoriaClinica.Name = "lblHistoriaClinica";
            this.lblHistoriaClinica.Size = new System.Drawing.Size(35, 13);
            this.lblHistoriaClinica.TabIndex = 1;
            this.lblHistoriaClinica.Text = "label2";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // frmAtencion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 409);
            this.Controls.Add(this.gpbDataPaciente);
            this.Controls.Add(this.btnGuardarTodo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tbcAtencion);
            this.Name = "frmAtencion1";
            this.Text = "Atencion1";
            this.Load += new System.EventHandler(this.frmAtencion1_Load);
            this.tbcAtencion.ResumeLayout(false);
            this.tbpMotivo.ResumeLayout(false);
            this.tbpRevision.ResumeLayout(false);
            this.tbpDiagnostico.ResumeLayout(false);
            this.tbpPlan.ResumeLayout(false);
            this.tbpPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.tbpObservacion.ResumeLayout(false);
            this.gpbDataPaciente.ResumeLayout(false);
            this.gpbDataPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAtencion;
        private System.Windows.Forms.TabPage tbpMotivo;
        private System.Windows.Forms.TabPage tbpRevision;
        private System.Windows.Forms.TabPage tbpDiagnostico;
        private System.Windows.Forms.TabPage tbpPlan;
        private System.Windows.Forms.TabPage tbpObservacion;
        private System.Windows.Forms.RichTextBox rtbObservacion;
        private System.Windows.Forms.RichTextBox rtbObservacionAns;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.ListBox lstMedicamentos;
        private System.Windows.Forms.ComboBox cboDietas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn monodroga;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratorio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblDieta;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarTodo;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.RichTextBox rtbMotivoAns;
        private System.Windows.Forms.RichTextBox rtbRevison;
        private System.Windows.Forms.RichTextBox rtbRevisionAns;
        private System.Windows.Forms.RichTextBox rtbDiagnostico;
        private System.Windows.Forms.RichTextBox rtbDiagnosticoAns;
        private System.Windows.Forms.GroupBox gpbDataPaciente;
        private System.Windows.Forms.Label lblHistoriaClinica;
        private System.Windows.Forms.Label lblNombre;
    }
}