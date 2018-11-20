namespace ProyectoPav
{
    partial class frmRepoHistorias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Atenciones_MedicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3DataSet = new ProyectoPav._3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroHist = new System.Windows.Forms.TextBox();
            this.txtNombrePac = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.Atenciones_MedicasTableAdapter = new ProyectoPav._3DataSetTableAdapters.Atenciones_MedicasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Atenciones_MedicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Atenciones_MedicasBindingSource
            // 
            this.Atenciones_MedicasBindingSource.DataMember = "Atenciones_Medicas";
            this.Atenciones_MedicasBindingSource.DataSource = this._3DataSet;
            // 
            // _3DataSet
            // 
            this._3DataSet.DataSetName = "_3DataSet";
            this._3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Atenciones_MedicasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPav.GUI.Transaccion.rptHistoriasClinicas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(422, 365);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro Historia Clinica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Hasta";
            // 
            // txtNroHist
            // 
            this.txtNroHist.Location = new System.Drawing.Point(554, 47);
            this.txtNroHist.Name = "txtNroHist";
            this.txtNroHist.Size = new System.Drawing.Size(40, 20);
            this.txtNroHist.TabIndex = 4;
            // 
            // txtNombrePac
            // 
            this.txtNombrePac.Location = new System.Drawing.Point(720, 50);
            this.txtNombrePac.Name = "txtNombrePac";
            this.txtNombrePac.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePac.TabIndex = 5;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(618, 47);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 8;
            this.btnBuscarPaciente.Text = "...";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(676, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(757, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(466, 342);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(566, 123);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtFechaDesde.TabIndex = 12;
            this.txtFechaDesde.Text = "dia-mes-año";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(566, 200);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.txtFechaHasta.TabIndex = 13;
            this.txtFechaHasta.Text = "dia-mes-año";
            this.txtFechaHasta.TextChanged += new System.EventHandler(this.txtFechaHasta_TextChanged);
            // 
            // Atenciones_MedicasTableAdapter
            // 
            this.Atenciones_MedicasTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepoHistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 410);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtNombrePac);
            this.Controls.Add(this.txtNroHist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepoHistorias";
            this.Text = "frmRepoHistorias";
            this.Load += new System.EventHandler(this.frmRepoHistorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Atenciones_MedicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroHist;
        private System.Windows.Forms.TextBox txtNombrePac;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.TextBox txtFechaHasta;
        private System.Windows.Forms.BindingSource Atenciones_MedicasBindingSource;
        private _3DataSet _3DataSet;
        private _3DataSetTableAdapters.Atenciones_MedicasTableAdapter Atenciones_MedicasTableAdapter;
    }
}