namespace ProyectoPav
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnHistoriaClinica = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPacientes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnPacientes.Location = new System.Drawing.Point(182, 223);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(176, 72);
            this.btnPacientes.TabIndex = 1;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // btnHistoriaClinica
            // 
            this.btnHistoriaClinica.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHistoriaClinica.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnHistoriaClinica.Location = new System.Drawing.Point(182, 50);
            this.btnHistoriaClinica.Name = "btnHistoriaClinica";
            this.btnHistoriaClinica.Size = new System.Drawing.Size(176, 72);
            this.btnHistoriaClinica.TabIndex = 2;
            this.btnHistoriaClinica.Text = "Historias Clinicas";
            this.btnHistoriaClinica.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Green;
            this.btnUsuario.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnUsuario.Location = new System.Drawing.Point(603, 50);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(176, 72);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Gold;
            this.btnConsultas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultas.Location = new System.Drawing.Point(603, 223);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(176, 72);
            this.btnConsultas.TabIndex = 4;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 353);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnHistoriaClinica);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnHistoriaClinica;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnConsultas;

    }
}