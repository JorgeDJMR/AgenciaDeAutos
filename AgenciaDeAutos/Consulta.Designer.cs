﻿namespace AgenciaDeAutos
{
    partial class Consulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbConsultarFolio = new System.Windows.Forms.TextBox();
            this.btnBuscarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio:";
            // 
            // tbConsultarFolio
            // 
            this.tbConsultarFolio.Location = new System.Drawing.Point(115, 25);
            this.tbConsultarFolio.Name = "tbConsultarFolio";
            this.tbConsultarFolio.Size = new System.Drawing.Size(100, 20);
            this.tbConsultarFolio.TabIndex = 1;
            // 
            // btnBuscarDatos
            // 
            this.btnBuscarDatos.Location = new System.Drawing.Point(124, 82);
            this.btnBuscarDatos.Name = "btnBuscarDatos";
            this.btnBuscarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDatos.TabIndex = 2;
            this.btnBuscarDatos.Text = "Buscar";
            this.btnBuscarDatos.UseVisualStyleBackColor = true;
            this.btnBuscarDatos.Click += new System.EventHandler(this.btnBuscarDatos_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 142);
            this.Controls.Add(this.btnBuscarDatos);
            this.Controls.Add(this.tbConsultarFolio);
            this.Controls.Add(this.label1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consulta_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConsultarFolio;
        private System.Windows.Forms.Button btnBuscarDatos;
    }
}