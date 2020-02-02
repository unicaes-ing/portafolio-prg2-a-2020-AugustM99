namespace Practica1
{
    partial class Form4
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.txttotPago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título del Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Impuesto (13%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total a pagar:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(244, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(129, 337);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "Nueva";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(18, 337);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cboLibros
            // 
            this.cboLibros.DisplayMember = "(ninguno)";
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Items.AddRange(new object[] {
            "El principito",
            "Cálculo Diferencial I",
            "Física para Ingenieros",
            "El Universo, un misterio sin resolver",
            "Atrapados en el espacio",
            "Aprende a programar"});
            this.cboLibros.Location = new System.Drawing.Point(123, 32);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(250, 24);
            this.cboLibros.TabIndex = 25;
            this.cboLibros.Text = "               ------- Elija un libro -------";
            this.cboLibros.SelectedIndexChanged += new System.EventHandler(this.cboLibros_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(90, 75);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 26;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(90, 119);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 27;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(129, 174);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(100, 22);
            this.txtSub.TabIndex = 28;
            // 
            // txtImp
            // 
            this.txtImp.Location = new System.Drawing.Point(129, 217);
            this.txtImp.Name = "txtImp";
            this.txtImp.ReadOnly = true;
            this.txtImp.Size = new System.Drawing.Size(100, 22);
            this.txtImp.TabIndex = 29;
            // 
            // txttotPago
            // 
            this.txttotPago.Location = new System.Drawing.Point(129, 267);
            this.txttotPago.Name = "txttotPago";
            this.txttotPago.ReadOnly = true;
            this.txttotPago.Size = new System.Drawing.Size(100, 22);
            this.txttotPago.TabIndex = 30;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 373);
            this.Controls.Add(this.txttotPago);
            this.Controls.Add(this.txtImp);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboLibros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Librería Universitaria";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.TextBox txttotPago;
    }
}