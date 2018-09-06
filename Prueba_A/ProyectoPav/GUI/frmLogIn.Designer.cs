namespace ProyectoPav
{
    partial class frmLogIn
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
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.txtPasswords = new System.Windows.Forms.TextBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblPasswords = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(208, 38);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(180, 20);
            this.txtUsuarios.TabIndex = 0;
            this.txtUsuarios.Text = "Ingresar Usuario";
            // 
            // txtPasswords
            // 
            this.txtPasswords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswords.CausesValidation = false;
            this.txtPasswords.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPasswords.Location = new System.Drawing.Point(208, 95);
            this.txtPasswords.Name = "txtPasswords";
            this.txtPasswords.PasswordChar = '*';
            this.txtPasswords.Size = new System.Drawing.Size(180, 20);
            this.txtPasswords.TabIndex = 1;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(25, 38);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(64, 20);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "Usuario";
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.lblPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswords.Location = new System.Drawing.Point(25, 95);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(92, 20);
            this.lblPasswords.TabIndex = 3;
            this.lblPasswords.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(208, 149);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Ingresar";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(313, 149);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(431, 184);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblPasswords);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.txtPasswords);
            this.Controls.Add(this.txtUsuarios);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.TextBox txtPasswords;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblPasswords;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnSalir;
    }
}

