namespace Practica_10
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.rdoCarro = new System.Windows.Forms.RadioButton();
            this.rdoCamion = new System.Windows.Forms.RadioButton();
            this.rdoMicrobus = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblTanque = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.txtTanque = new System.Windows.Forms.TextBox();
            this.nudMillas = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Millas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(85, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(186, 22);
            this.txtMarca.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(85, 68);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(186, 22);
            this.txtModel.TabIndex = 6;
            // 
            // rdoCarro
            // 
            this.rdoCarro.AutoSize = true;
            this.rdoCarro.Location = new System.Drawing.Point(85, 212);
            this.rdoCarro.Name = "rdoCarro";
            this.rdoCarro.Size = new System.Drawing.Size(64, 21);
            this.rdoCarro.TabIndex = 9;
            this.rdoCarro.Text = "Carro";
            this.rdoCarro.UseVisualStyleBackColor = true;
            this.rdoCarro.CheckedChanged += new System.EventHandler(this.rdoCarro_CheckedChanged);
            // 
            // rdoCamion
            // 
            this.rdoCamion.AutoSize = true;
            this.rdoCamion.Location = new System.Drawing.Point(155, 212);
            this.rdoCamion.Name = "rdoCamion";
            this.rdoCamion.Size = new System.Drawing.Size(76, 21);
            this.rdoCamion.TabIndex = 10;
            this.rdoCamion.Text = "Camión";
            this.rdoCamion.UseVisualStyleBackColor = true;
            this.rdoCamion.CheckedChanged += new System.EventHandler(this.rdoCamion_CheckedChanged);
            // 
            // rdoMicrobus
            // 
            this.rdoMicrobus.AutoSize = true;
            this.rdoMicrobus.Location = new System.Drawing.Point(237, 212);
            this.rdoMicrobus.Name = "rdoMicrobus";
            this.rdoMicrobus.Size = new System.Drawing.Size(86, 21);
            this.rdoMicrobus.TabIndex = 11;
            this.rdoMicrobus.Text = "Microbús";
            this.rdoMicrobus.UseVisualStyleBackColor = true;
            this.rdoMicrobus.CheckedChanged += new System.EventHandler(this.rdoMicrobus_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(340, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 32);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(14, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 237);
            this.dataGridView1.TabIndex = 13;
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(487, 164);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(71, 17);
            this.lblPasajeros.TabIndex = 17;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // lblTanque
            // 
            this.lblTanque.AutoSize = true;
            this.lblTanque.Location = new System.Drawing.Point(481, 116);
            this.lblTanque.Name = "lblTanque";
            this.lblTanque.Size = new System.Drawing.Size(156, 17);
            this.lblTanque.TabIndex = 16;
            this.lblTanque.Text = "Tanque de combustible";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(481, 68);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(137, 17);
            this.lblCapacidad.TabIndex = 15;
            this.lblCapacidad.Text = "Capacidad de Carga";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(488, 20);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(57, 17);
            this.lblPuertas.TabIndex = 14;
            this.lblPuertas.Text = "Puertas";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(641, 63);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(186, 22);
            this.txtCapacidad.TabIndex = 19;
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(641, 17);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(186, 22);
            this.txtPuertas.TabIndex = 18;
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(641, 161);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(186, 22);
            this.txtPasajeros.TabIndex = 21;
            // 
            // txtTanque
            // 
            this.txtTanque.Location = new System.Drawing.Point(641, 113);
            this.txtTanque.Name = "txtTanque";
            this.txtTanque.Size = new System.Drawing.Size(186, 22);
            this.txtTanque.TabIndex = 20;
            // 
            // nudMillas
            // 
            this.nudMillas.Location = new System.Drawing.Point(85, 116);
            this.nudMillas.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudMillas.Name = "nudMillas";
            this.nudMillas.Size = new System.Drawing.Size(120, 22);
            this.nudMillas.TabIndex = 22;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(85, 162);
            this.nudPrecio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 22);
            this.nudPrecio.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marca";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modelo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Millas";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Puertas";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Capacidad (Kg)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Combustible (Gal)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Pasajeros";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 511);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudMillas);
            this.Controls.Add(this.txtPasajeros);
            this.Controls.Add(this.txtTanque);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.lblTanque);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rdoMicrobus);
            this.Controls.Add(this.rdoCamion);
            this.Controls.Add(this.rdoCarro);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autos Nuevos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.RadioButton rdoCarro;
        private System.Windows.Forms.RadioButton rdoCamion;
        private System.Windows.Forms.RadioButton rdoMicrobus;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblTanque;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.TextBox txtTanque;
        private System.Windows.Forms.NumericUpDown nudMillas;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

