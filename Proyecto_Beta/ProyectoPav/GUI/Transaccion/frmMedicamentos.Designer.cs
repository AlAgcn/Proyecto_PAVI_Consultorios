namespace ProyectoPav
{
    partial class frmMedicamentos
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
            this.txtFarmaco = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonodroga = new System.Windows.Forms.TextBox();
            this.lblMonodroga = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstMedicamentos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFarmaco
            // 
            this.txtFarmaco.Location = new System.Drawing.Point(99, 18);
            this.txtFarmaco.Name = "txtFarmaco";
            this.txtFarmaco.Size = new System.Drawing.Size(269, 20);
            this.txtFarmaco.TabIndex = 2;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(99, 65);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(269, 20);
            this.txtLaboratorio.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(425, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 49);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(27, 210);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(27, 248);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(215, 248);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laboratorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Farmaco";
            // 
            // txtMonodroga
            // 
            this.txtMonodroga.Location = new System.Drawing.Point(99, 112);
            this.txtMonodroga.Name = "txtMonodroga";
            this.txtMonodroga.Size = new System.Drawing.Size(269, 20);
            this.txtMonodroga.TabIndex = 6;
            // 
            // lblMonodroga
            // 
            this.lblMonodroga.AutoSize = true;
            this.lblMonodroga.Location = new System.Drawing.Point(12, 120);
            this.lblMonodroga.Name = "lblMonodroga";
            this.lblMonodroga.Size = new System.Drawing.Size(61, 13);
            this.lblMonodroga.TabIndex = 5;
            this.lblMonodroga.Text = "Monodroga";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.Location = new System.Drawing.Point(397, 18);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(138, 186);
            this.lstMedicamentos.TabIndex = 0;
            // 
            // frmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 287);
            this.Controls.Add(this.lstMedicamentos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMonodroga);
            this.Controls.Add(this.txtMonodroga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtFarmaco);
            this.Name = "frmMedicamentos";
            this.Text = "frmMedicamentos";
            this.Load += new System.EventHandler(this.frmMedicamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFarmaco;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonodroga;
        private System.Windows.Forms.Label lblMonodroga;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstMedicamentos;
    }
}