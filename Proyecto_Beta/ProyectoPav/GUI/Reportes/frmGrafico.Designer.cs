namespace ProyectoPav
{
    partial class frmGrafiquin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chtAtencionesMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtAtencionesMes)).BeginInit();
            this.SuspendLayout();
            // 
            // chtAtencionesMes
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAtencionesMes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAtencionesMes.Legends.Add(legend1);
            this.chtAtencionesMes.Location = new System.Drawing.Point(100, 142);
            this.chtAtencionesMes.Name = "chtAtencionesMes";
            this.chtAtencionesMes.Size = new System.Drawing.Size(454, 300);
            this.chtAtencionesMes.TabIndex = 0;
            this.chtAtencionesMes.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año de atenciones";
            // 
            // txtanio
            // 
            this.txtanio.Enabled = false;
            this.txtanio.Location = new System.Drawing.Point(214, 49);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(100, 20);
            this.txtanio.TabIndex = 2;
            this.txtanio.Text = "2018";
            // 
            // frmGrafiquin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 482);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chtAtencionesMes);
            this.Name = "frmGrafiquin";
            this.Text = "Grafico de Barras de una atencion";
            this.Load += new System.EventHandler(this.frmGrafiquin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAtencionesMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtAtencionesMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtanio;
    }
}