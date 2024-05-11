namespace AgenciaDeAutos
{
    partial class Historial
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
            this.dtgvHistorial = new System.Windows.Forms.DataGridView();
            this.fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.tbGanancias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btFiltro = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btRecargarDTGV = new System.Windows.Forms.Button();
            this.FiltrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHistorial
            // 
            this.dtgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistorial.Location = new System.Drawing.Point(54, 193);
            this.dtgvHistorial.Name = "dtgvHistorial";
            this.dtgvHistorial.Size = new System.Drawing.Size(1146, 260);
            this.dtgvHistorial.TabIndex = 0;
            this.dtgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHistorial_CellClick);
            this.dtgvHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHistorial_CellContentClick);
            // 
            // fechaInicial
            // 
            this.fechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicial.Location = new System.Drawing.Point(154, 58);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(92, 20);
            this.fechaInicial.TabIndex = 1;
            // 
            // fechaFinal
            // 
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(154, 103);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(92, 20);
            this.fechaFinal.TabIndex = 2;
            // 
            // tbGanancias
            // 
            this.tbGanancias.Location = new System.Drawing.Point(1100, 459);
            this.tbGanancias.Name = "tbGanancias";
            this.tbGanancias.ReadOnly = true;
            this.tbGanancias.Size = new System.Drawing.Size(100, 20);
            this.tbGanancias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(990, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total  de ganancias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carro:";
            // 
            // cbCarro
            // 
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Items.AddRange(new object[] {
            "Lamborghini Aventador SVJ",
            "Porsche 911 GT3 RS",
            "Ferrari F8 Tributo"});
            this.cbCarro.Location = new System.Drawing.Point(125, 150);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(121, 21);
            this.cbCarro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "Historial";
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(1060, 14);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(65, 44);
            this.btFiltro.TabIndex = 11;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(1060, 137);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(140, 45);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(536, 555);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(149, 39);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btRecargarDTGV
            // 
            this.btRecargarDTGV.Location = new System.Drawing.Point(1060, 78);
            this.btRecargarDTGV.Name = "btRecargarDTGV";
            this.btRecargarDTGV.Size = new System.Drawing.Size(140, 44);
            this.btRecargarDTGV.TabIndex = 15;
            this.btRecargarDTGV.Text = "Recargar";
            this.btRecargarDTGV.UseVisualStyleBackColor = true;
            this.btRecargarDTGV.Click += new System.EventHandler(this.btRecargarDTGV_Click);
            // 
            // FiltrarTodo
            // 
            this.FiltrarTodo.Location = new System.Drawing.Point(1131, 14);
            this.FiltrarTodo.Name = "FiltrarTodo";
            this.FiltrarTodo.Size = new System.Drawing.Size(69, 44);
            this.FiltrarTodo.TabIndex = 16;
            this.FiltrarTodo.Text = "Filtrar Todo";
            this.FiltrarTodo.UseVisualStyleBackColor = true;
            this.FiltrarTodo.Click += new System.EventHandler(this.FiltrarTodo_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1258, 628);
            this.Controls.Add(this.FiltrarTodo);
            this.Controls.Add(this.btRecargarDTGV);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGanancias);
            this.Controls.Add(this.fechaFinal);
            this.Controls.Add(this.fechaInicial);
            this.Controls.Add(this.dtgvHistorial);
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHistorial;
        private System.Windows.Forms.DateTimePicker fechaInicial;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.TextBox tbGanancias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btRecargarDTGV;
        private System.Windows.Forms.Button FiltrarTodo;
    }
}