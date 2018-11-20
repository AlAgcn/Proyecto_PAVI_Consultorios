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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbcAtencion = new System.Windows.Forms.TabControl();
            this.tbpMotivo = new System.Windows.Forms.TabPage();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.tbpRevision = new System.Windows.Forms.TabPage();
            this.rtbRevison = new System.Windows.Forms.RichTextBox();
            this.tbpDiagnostico = new System.Windows.Forms.TabPage();
            this.rtbDiagnostico = new System.Windows.Forms.RichTextBox();
            this.tbpPlan = new System.Windows.Forms.TabPage();
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarTodo = new System.Windows.Forms.Button();
            this.gpbDataPaciente = new System.Windows.Forms.GroupBox();
            this.lblHistoriaClinica = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rptMotivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptRevision = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptDiagnostico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptObservacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this._3DataSet = new ProyectoPav._3DataSet();
            this.Atenciones_MedicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Atenciones_MedicasTableAdapter = new ProyectoPav._3DataSetTableAdapters.Atenciones_MedicasTableAdapter();
            this.tbcAtencion.SuspendLayout();
            this.tbpMotivo.SuspendLayout();
            this.tbpRevision.SuspendLayout();
            this.tbpDiagnostico.SuspendLayout();
            this.tbpPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.tbpObservacion.SuspendLayout();
            this.gpbDataPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atenciones_MedicasBindingSource)).BeginInit();
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
            this.tbcAtencion.Location = new System.Drawing.Point(0, 139);
            this.tbcAtencion.Name = "tbcAtencion";
            this.tbcAtencion.SelectedIndex = 0;
            this.tbcAtencion.Size = new System.Drawing.Size(672, 270);
            this.tbcAtencion.TabIndex = 0;
            // 
            // tbpMotivo
            // 
            this.tbpMotivo.Controls.Add(this.rptMotivos);
            this.tbpMotivo.Controls.Add(this.rtbMotivo);
            this.tbpMotivo.Location = new System.Drawing.Point(4, 22);
            this.tbpMotivo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbpMotivo.Name = "tbpMotivo";
            this.tbpMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMotivo.Size = new System.Drawing.Size(664, 244);
            this.tbpMotivo.TabIndex = 0;
            this.tbpMotivo.Text = "Motivo*";
            this.tbpMotivo.UseVisualStyleBackColor = true;
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.Location = new System.Drawing.Point(348, 42);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(293, 179);
            this.rtbMotivo.TabIndex = 15;
            this.rtbMotivo.Text = "";
            // 
            // tbpRevision
            // 
            this.tbpRevision.Controls.Add(this.rptRevision);
            this.tbpRevision.Controls.Add(this.rtbRevison);
            this.tbpRevision.Location = new System.Drawing.Point(4, 22);
            this.tbpRevision.Name = "tbpRevision";
            this.tbpRevision.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRevision.Size = new System.Drawing.Size(664, 244);
            this.tbpRevision.TabIndex = 1;
            this.tbpRevision.Text = "Revision";
            this.tbpRevision.UseVisualStyleBackColor = true;
            // 
            // rtbRevison
            // 
            this.rtbRevison.Location = new System.Drawing.Point(335, 46);
            this.rtbRevison.Name = "rtbRevison";
            this.rtbRevison.Size = new System.Drawing.Size(323, 179);
            this.rtbRevison.TabIndex = 15;
            this.rtbRevison.Text = "";
            // 
            // tbpDiagnostico
            // 
            this.tbpDiagnostico.Controls.Add(this.rptDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.rtbDiagnostico);
            this.tbpDiagnostico.Location = new System.Drawing.Point(4, 22);
            this.tbpDiagnostico.Name = "tbpDiagnostico";
            this.tbpDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiagnostico.Size = new System.Drawing.Size(664, 244);
            this.tbpDiagnostico.TabIndex = 2;
            this.tbpDiagnostico.Text = "Diagnostico*";
            this.tbpDiagnostico.UseVisualStyleBackColor = true;
            // 
            // rtbDiagnostico
            // 
            this.rtbDiagnostico.Location = new System.Drawing.Point(344, 42);
            this.rtbDiagnostico.Name = "rtbDiagnostico";
            this.rtbDiagnostico.Size = new System.Drawing.Size(294, 179);
            this.rtbDiagnostico.TabIndex = 15;
            this.rtbDiagnostico.Text = "";
            // 
            // tbpPlan
            // 
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
            this.tbpPlan.Size = new System.Drawing.Size(664, 244);
            this.tbpPlan.TabIndex = 3;
            this.tbpPlan.Text = "Plan Terapeutico*";
            this.tbpPlan.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(519, 25);
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
            this.lblLista.Location = new System.Drawing.Point(9, 62);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(128, 13);
            this.lblLista.TabIndex = 8;
            this.lblLista.Text = "Listado de Medicamentos";
            // 
            // lblDieta
            // 
            this.lblDieta.AutoSize = true;
            this.lblDieta.Location = new System.Drawing.Point(9, 12);
            this.lblDieta.Name = "lblDieta";
            this.lblDieta.Size = new System.Drawing.Size(32, 13);
            this.lblDieta.TabIndex = 7;
            this.lblDieta.Text = "Dieta";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(149, 25);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(60, 13);
            this.lblFrecuencia.TabIndex = 6;
            this.lblFrecuencia.Text = "Frecuencia";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(345, 25);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duracion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(401, 25);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 20);
            this.txtDuracion.TabIndex = 4;
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(215, 25);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtFrecuencia.TabIndex = 3;
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.Location = new System.Drawing.Point(11, 78);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(125, 160);
            this.lstMedicamentos.TabIndex = 2;
            // 
            // cboDietas
            // 
            this.cboDietas.FormattingEnabled = true;
            this.cboDietas.Location = new System.Drawing.Point(9, 28);
            this.cboDietas.Name = "cboDietas";
            this.cboDietas.Size = new System.Drawing.Size(120, 21);
            this.cboDietas.TabIndex = 1;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_medicamento,
            this.monodroga,
            this.farmaco,
            this.frecuencia,
            this.duracion,
            this.laboratorio});
            this.dgvMedicamentos.Location = new System.Drawing.Point(154, 72);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(502, 164);
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
            this.tbpObservacion.Controls.Add(this.rptObservacion);
            this.tbpObservacion.Controls.Add(this.rtbObservacion);
            this.tbpObservacion.Location = new System.Drawing.Point(4, 22);
            this.tbpObservacion.Name = "tbpObservacion";
            this.tbpObservacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpObservacion.Size = new System.Drawing.Size(664, 244);
            this.tbpObservacion.TabIndex = 4;
            this.tbpObservacion.Text = "Observacion";
            this.tbpObservacion.UseVisualStyleBackColor = true;
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.Location = new System.Drawing.Point(332, 57);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(324, 179);
            this.rtbObservacion.TabIndex = 1;
            this.rtbObservacion.Text = "";
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
            this.lblHistoriaClinica.Click += new System.EventHandler(this.lblHistoriaClinica_Click);
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
            // rptMotivos
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.Atenciones_MedicasBindingSource;
            this.rptMotivos.LocalReport.DataSources.Add(reportDataSource5);
            this.rptMotivos.LocalReport.ReportEmbeddedResource = "ProyectoPav.GUI.Transaccion.rptMotivos.rdlc";
            this.rptMotivos.Location = new System.Drawing.Point(11, 42);
            this.rptMotivos.Name = "rptMotivos";
            this.rptMotivos.Size = new System.Drawing.Size(284, 179);
            this.rptMotivos.TabIndex = 16;
            // 
            // rptRevision
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.Atenciones_MedicasBindingSource;
            this.rptRevision.LocalReport.DataSources.Add(reportDataSource6);
            this.rptRevision.LocalReport.ReportEmbeddedResource = "ProyectoPav.GUI.Transaccion.rptRevision.rdlc";
            this.rptRevision.Location = new System.Drawing.Point(25, 46);
            this.rptRevision.Name = "rptRevision";
            this.rptRevision.Size = new System.Drawing.Size(284, 179);
            this.rptRevision.TabIndex = 17;
            // 
            // rptDiagnostico
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.Atenciones_MedicasBindingSource;
            this.rptDiagnostico.LocalReport.DataSources.Add(reportDataSource7);
            this.rptDiagnostico.LocalReport.ReportEmbeddedResource = "ProyectoPav.GUI.Transaccion.rptDiagnostico.rdlc";
            this.rptDiagnostico.Location = new System.Drawing.Point(21, 42);
            this.rptDiagnostico.Name = "rptDiagnostico";
            this.rptDiagnostico.Size = new System.Drawing.Size(284, 179);
            this.rptDiagnostico.TabIndex = 18;
            // 
            // rptObservacion
            // 
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.Atenciones_MedicasBindingSource;
            this.rptObservacion.LocalReport.DataSources.Add(reportDataSource8);
            this.rptObservacion.LocalReport.ReportEmbeddedResource = "ProyectoPav.GUI.Transaccion.rptObservacion.rdlc";
            this.rptObservacion.Location = new System.Drawing.Point(11, 57);
            this.rptObservacion.Name = "rptObservacion";
            this.rptObservacion.Size = new System.Drawing.Size(284, 179);
            this.rptObservacion.TabIndex = 18;
            // 
            // _3DataSet
            // 
            this._3DataSet.DataSetName = "_3DataSet";
            this._3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Atenciones_MedicasBindingSource
            // 
            this.Atenciones_MedicasBindingSource.DataMember = "Atenciones_Medicas";
            this.Atenciones_MedicasBindingSource.DataSource = this._3DataSet;
            // 
            // Atenciones_MedicasTableAdapter
            // 
            this.Atenciones_MedicasTableAdapter.ClearBeforeFill = true;
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
            this.Text = "           ";
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
            ((System.ComponentModel.ISupportInitialize)(this._3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atenciones_MedicasBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblDieta;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarTodo;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.RichTextBox rtbRevison;
        private System.Windows.Forms.RichTextBox rtbDiagnostico;
        private System.Windows.Forms.GroupBox gpbDataPaciente;
        private System.Windows.Forms.Label lblHistoriaClinica;
        private System.Windows.Forms.Label lblNombre;
        private Microsoft.Reporting.WinForms.ReportViewer rptMotivos;
        private Microsoft.Reporting.WinForms.ReportViewer rptRevision;
        private Microsoft.Reporting.WinForms.ReportViewer rptDiagnostico;
        private Microsoft.Reporting.WinForms.ReportViewer rptObservacion;
        private System.Windows.Forms.BindingSource Atenciones_MedicasBindingSource;
        private _3DataSet _3DataSet;
        private _3DataSetTableAdapters.Atenciones_MedicasTableAdapter Atenciones_MedicasTableAdapter;
    }
}