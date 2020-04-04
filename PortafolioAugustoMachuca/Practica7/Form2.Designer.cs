namespace Practica7
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxCod = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreMas = new System.Windows.Forms.TextBox();
            this.cboProp = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rdoMacho = new System.Windows.Forms.RadioButton();
            this.rdoHembra = new System.Windows.Forms.RadioButton();
            this.btnGuardarMas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Propietario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha nac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo";
            // 
            // mtxCod
            // 
            this.mtxCod.Location = new System.Drawing.Point(147, 13);
            this.mtxCod.Mask = ">LL0000";
            this.mtxCod.Name = "mtxCod";
            this.mtxCod.Size = new System.Drawing.Size(100, 22);
            this.mtxCod.TabIndex = 0;
            // 
            // txtNombreMas
            // 
            this.txtNombreMas.Location = new System.Drawing.Point(147, 54);
            this.txtNombreMas.Name = "txtNombreMas";
            this.txtNombreMas.Size = new System.Drawing.Size(200, 22);
            this.txtNombreMas.TabIndex = 1;
            this.txtNombreMas.TextChanged += new System.EventHandler(this.txtNombreMas_TextChanged);
            // 
            // cboProp
            // 
            this.cboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProp.FormattingEnabled = true;
            this.cboProp.Location = new System.Drawing.Point(147, 98);
            this.cboProp.Name = "cboProp";
            this.cboProp.Size = new System.Drawing.Size(200, 24);
            this.cboProp.TabIndex = 9;
            this.cboProp.Tag = "";
            // 
            // cboEspecie
            // 
            this.cboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Perico",
            "Conejo",
            "Tortuga"});
            this.cboEspecie.Location = new System.Drawing.Point(147, 138);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(156, 24);
            this.cboEspecie.TabIndex = 10;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(147, 184);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(128, 22);
            this.dtpFechaNac.TabIndex = 11;
            this.dtpFechaNac.Value = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(147, 228);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(128, 22);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // rdoMacho
            // 
            this.rdoMacho.AutoSize = true;
            this.rdoMacho.Location = new System.Drawing.Point(147, 274);
            this.rdoMacho.Name = "rdoMacho";
            this.rdoMacho.Size = new System.Drawing.Size(71, 21);
            this.rdoMacho.TabIndex = 13;
            this.rdoMacho.TabStop = true;
            this.rdoMacho.Text = "Macho";
            this.rdoMacho.UseVisualStyleBackColor = true;
            // 
            // rdoHembra
            // 
            this.rdoHembra.AutoSize = true;
            this.rdoHembra.Location = new System.Drawing.Point(224, 275);
            this.rdoHembra.Name = "rdoHembra";
            this.rdoHembra.Size = new System.Drawing.Size(79, 21);
            this.rdoHembra.TabIndex = 14;
            this.rdoHembra.TabStop = true;
            this.rdoHembra.Text = "Hembra";
            this.rdoHembra.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMas
            // 
            this.btnGuardarMas.Location = new System.Drawing.Point(355, 275);
            this.btnGuardarMas.Name = "btnGuardarMas";
            this.btnGuardarMas.Size = new System.Drawing.Size(147, 23);
            this.btnGuardarMas.TabIndex = 15;
            this.btnGuardarMas.Text = "Guardar mascota";
            this.btnGuardarMas.UseVisualStyleBackColor = true;
            this.btnGuardarMas.Click += new System.EventHandler(this.btnGuardarMas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(711, 643);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(11, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 309);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Propietario";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Especie";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 85;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha nac";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Peso";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sexo";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 678);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarMas);
            this.Controls.Add(this.rdoHembra);
            this.Controls.Add(this.rdoMacho);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.cboProp);
            this.Controls.Add(this.txtNombreMas);
            this.Controls.Add(this.mtxCod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxCod;
        private System.Windows.Forms.TextBox txtNombreMas;
        private System.Windows.Forms.ComboBox cboProp;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.RadioButton rdoMacho;
        private System.Windows.Forms.RadioButton rdoHembra;
        private System.Windows.Forms.Button btnGuardarMas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}