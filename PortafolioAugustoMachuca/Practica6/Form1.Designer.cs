namespace Practica6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLimpiar = new System.Windows.Forms.RadioButton();
            this.rdoOrdenar = new System.Windows.Forms.RadioButton();
            this.rdoQuitar = new System.Windows.Forms.RadioButton();
            this.rdoInsertar = new System.Windows.Forms.RadioButton();
            this.rdoBuscar = new System.Windows.Forms.RadioButton();
            this.rdoAgregar = new System.Windows.Forms.RadioButton();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 16;
            this.lstNombres.Location = new System.Drawing.Point(16, 71);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(159, 244);
            this.lstNombres.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLimpiar);
            this.groupBox1.Controls.Add(this.rdoOrdenar);
            this.groupBox1.Controls.Add(this.rdoQuitar);
            this.groupBox1.Controls.Add(this.rdoInsertar);
            this.groupBox1.Controls.Add(this.rdoBuscar);
            this.groupBox1.Controls.Add(this.rdoAgregar);
            this.groupBox1.Location = new System.Drawing.Point(217, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acción";
            // 
            // rdoLimpiar
            // 
            this.rdoLimpiar.AutoSize = true;
            this.rdoLimpiar.Location = new System.Drawing.Point(6, 160);
            this.rdoLimpiar.Name = "rdoLimpiar";
            this.rdoLimpiar.Size = new System.Drawing.Size(75, 21);
            this.rdoLimpiar.TabIndex = 5;
            this.rdoLimpiar.TabStop = true;
            this.rdoLimpiar.Text = "Limpiar";
            this.rdoLimpiar.UseVisualStyleBackColor = true;
            // 
            // rdoOrdenar
            // 
            this.rdoOrdenar.AutoSize = true;
            this.rdoOrdenar.Location = new System.Drawing.Point(7, 133);
            this.rdoOrdenar.Name = "rdoOrdenar";
            this.rdoOrdenar.Size = new System.Drawing.Size(82, 21);
            this.rdoOrdenar.TabIndex = 4;
            this.rdoOrdenar.TabStop = true;
            this.rdoOrdenar.Text = "Ordenar";
            this.rdoOrdenar.UseVisualStyleBackColor = true;
            // 
            // rdoQuitar
            // 
            this.rdoQuitar.AutoSize = true;
            this.rdoQuitar.Location = new System.Drawing.Point(7, 105);
            this.rdoQuitar.Name = "rdoQuitar";
            this.rdoQuitar.Size = new System.Drawing.Size(68, 21);
            this.rdoQuitar.TabIndex = 3;
            this.rdoQuitar.TabStop = true;
            this.rdoQuitar.Text = "Quitar";
            this.rdoQuitar.UseVisualStyleBackColor = true;
            // 
            // rdoInsertar
            // 
            this.rdoInsertar.AutoSize = true;
            this.rdoInsertar.Location = new System.Drawing.Point(7, 77);
            this.rdoInsertar.Name = "rdoInsertar";
            this.rdoInsertar.Size = new System.Drawing.Size(77, 21);
            this.rdoInsertar.TabIndex = 2;
            this.rdoInsertar.TabStop = true;
            this.rdoInsertar.Text = "Insertar";
            this.rdoInsertar.UseVisualStyleBackColor = true;
            // 
            // rdoBuscar
            // 
            this.rdoBuscar.AutoSize = true;
            this.rdoBuscar.Location = new System.Drawing.Point(7, 49);
            this.rdoBuscar.Name = "rdoBuscar";
            this.rdoBuscar.Size = new System.Drawing.Size(73, 21);
            this.rdoBuscar.TabIndex = 1;
            this.rdoBuscar.TabStop = true;
            this.rdoBuscar.Text = "Buscar";
            this.rdoBuscar.UseVisualStyleBackColor = true;
            // 
            // rdoAgregar
            // 
            this.rdoAgregar.AutoSize = true;
            this.rdoAgregar.Location = new System.Drawing.Point(7, 21);
            this.rdoAgregar.Name = "rdoAgregar";
            this.rdoAgregar.Size = new System.Drawing.Size(80, 21);
            this.rdoAgregar.TabIndex = 0;
            this.rdoAgregar.TabStop = true;
            this.rdoAgregar.Text = "Agregar";
            this.rdoAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(217, 224);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(108, 30);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(327, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 29);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 393);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejer1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdoLimpiar;
        private System.Windows.Forms.RadioButton rdoOrdenar;
        private System.Windows.Forms.RadioButton rdoQuitar;
        private System.Windows.Forms.RadioButton rdoInsertar;
        private System.Windows.Forms.RadioButton rdoBuscar;
        private System.Windows.Forms.RadioButton rdoAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

