namespace Practica2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoUno = new System.Windows.Forms.RadioButton();
            this.rdoDos = new System.Windows.Forms.RadioButton();
            this.rdoTres = new System.Windows.Forms.RadioButton();
            this.rdoCuatro = new System.Windows.Forms.RadioButton();
            this.rdoCinco = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(122, 62);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(122, 104);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(122, 227);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(100, 22);
            this.txtDesc.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(122, 285);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(122, 161);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(183, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCinco);
            this.groupBox1.Controls.Add(this.rdoCuatro);
            this.groupBox1.Controls.Add(this.rdoTres);
            this.groupBox1.Controls.Add(this.rdoDos);
            this.groupBox1.Controls.Add(this.rdoUno);
            this.groupBox1.Location = new System.Drawing.Point(270, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 212);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoUno
            // 
            this.rdoUno.AutoSize = true;
            this.rdoUno.Checked = true;
            this.rdoUno.Location = new System.Drawing.Point(18, 38);
            this.rdoUno.Name = "rdoUno";
            this.rdoUno.Size = new System.Drawing.Size(49, 21);
            this.rdoUno.TabIndex = 0;
            this.rdoUno.TabStop = true;
            this.rdoUno.Text = "0%";
            this.rdoUno.UseVisualStyleBackColor = true;
            // 
            // rdoDos
            // 
            this.rdoDos.AutoSize = true;
            this.rdoDos.Location = new System.Drawing.Point(18, 72);
            this.rdoDos.Name = "rdoDos";
            this.rdoDos.Size = new System.Drawing.Size(49, 21);
            this.rdoDos.TabIndex = 1;
            this.rdoDos.Text = "5%";
            this.rdoDos.UseVisualStyleBackColor = true;
            // 
            // rdoTres
            // 
            this.rdoTres.AutoSize = true;
            this.rdoTres.Location = new System.Drawing.Point(18, 110);
            this.rdoTres.Name = "rdoTres";
            this.rdoTres.Size = new System.Drawing.Size(57, 21);
            this.rdoTres.TabIndex = 2;
            this.rdoTres.Text = "10%";
            this.rdoTres.UseVisualStyleBackColor = true;
            // 
            // rdoCuatro
            // 
            this.rdoCuatro.AutoSize = true;
            this.rdoCuatro.Location = new System.Drawing.Point(18, 148);
            this.rdoCuatro.Name = "rdoCuatro";
            this.rdoCuatro.Size = new System.Drawing.Size(57, 21);
            this.rdoCuatro.TabIndex = 3;
            this.rdoCuatro.Text = "15%";
            this.rdoCuatro.UseVisualStyleBackColor = true;
            this.rdoCuatro.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdoCinco
            // 
            this.rdoCinco.AutoSize = true;
            this.rdoCinco.Location = new System.Drawing.Point(18, 185);
            this.rdoCinco.Name = "rdoCinco";
            this.rdoCinco.Size = new System.Drawing.Size(57, 21);
            this.rdoCinco.TabIndex = 4;
            this.rdoCinco.Text = "20%";
            this.rdoCinco.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Descuento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCinco;
        private System.Windows.Forms.RadioButton rdoCuatro;
        private System.Windows.Forms.RadioButton rdoTres;
        private System.Windows.Forms.RadioButton rdoDos;
        private System.Windows.Forms.RadioButton rdoUno;
    }
}