namespace ProyectoPav
{
    partial class frmElegirPaciente
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
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdDetalle = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHistoria = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblHistoClinica = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(537, 93);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 8;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(537, 340);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdDetalle
            // 
            this.cmdDetalle.Location = new System.Drawing.Point(24, 340);
            this.cmdDetalle.Name = "cmdDetalle";
            this.cmdDetalle.Size = new System.Drawing.Size(130, 23);
            this.cmdDetalle.TabIndex = 10;
            this.cmdDetalle.Text = "Ver Paciente";
            this.cmdDetalle.UseVisualStyleBackColor = true;
            this.cmdDetalle.Click += new System.EventHandler(this.cmdDetalle_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(24, 150);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(588, 150);
            this.dgvPacientes.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtHistoria
            // 
            this.txtHistoria.Location = new System.Drawing.Point(332, 94);
            this.txtHistoria.Name = "txtHistoria";
            this.txtHistoria.Size = new System.Drawing.Size(100, 20);
            this.txtHistoria.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(332, 37);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(24, 94);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoPaciente.TabIndex = 2;
            this.lblApellidoPaciente.Text = "Apellido Paciente";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(24, 43);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // lblHistoClinica
            // 
            this.lblHistoClinica.AutoSize = true;
            this.lblHistoClinica.Location = new System.Drawing.Point(250, 98);
            this.lblHistoClinica.Name = "lblHistoClinica";
            this.lblHistoClinica.Size = new System.Drawing.Size(76, 13);
            this.lblHistoClinica.TabIndex = 6;
            this.lblHistoClinica.Text = "Historia Clinica";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(250, 44);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // frmElegirPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 388);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblHistoClinica);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtHistoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.cmdDetalle);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdConsultar);
            this.Name = "frmElegirPaciente";
            this.Text = "frmElegirPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdDetalle;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHistoria;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblHistoClinica;
        private System.Windows.Forms.Label lblDNI;
    }
}