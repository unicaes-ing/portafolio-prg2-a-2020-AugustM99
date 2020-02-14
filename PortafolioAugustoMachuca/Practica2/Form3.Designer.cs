namespace Practica2
{
    partial class Form3
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
            this.txtCant = new System.Windows.Forms.TextBox();
            this.grpUno = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConver = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstConv1 = new System.Windows.Forms.ListBox();
            this.lstConv2 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpUno.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca la longitud a convertir";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(238, 27);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 1;
            this.txtCant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpUno
            // 
            this.grpUno.Controls.Add(this.lstConv1);
            this.grpUno.Location = new System.Drawing.Point(21, 86);
            this.grpUno.Name = "grpUno";
            this.grpUno.Size = new System.Drawing.Size(133, 118);
            this.grpUno.TabIndex = 2;
            this.grpUno.TabStop = false;
            this.grpUno.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitud convertida";
            // 
            // txtConver
            // 
            this.txtConver.Location = new System.Drawing.Point(160, 227);
            this.txtConver.Name = "txtConver";
            this.txtConver.ReadOnly = true;
            this.txtConver.Size = new System.Drawing.Size(135, 22);
            this.txtConver.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(44, 285);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 25);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstConv2);
            this.groupBox2.Location = new System.Drawing.Point(202, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "a";
            // 
            // lstConv1
            // 
            this.lstConv1.FormattingEnabled = true;
            this.lstConv1.ItemHeight = 16;
            this.lstConv1.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstConv1.Location = new System.Drawing.Point(6, 21);
            this.lstConv1.Name = "lstConv1";
            this.lstConv1.Size = new System.Drawing.Size(121, 84);
            this.lstConv1.TabIndex = 0;
            // 
            // lstConv2
            // 
            this.lstConv2.FormattingEnabled = true;
            this.lstConv2.ItemHeight = 16;
            this.lstConv2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lstConv2.Location = new System.Drawing.Point(7, 22);
            this.lstConv2.Name = "lstConv2";
            this.lstConv2.Size = new System.Drawing.Size(120, 84);
            this.lstConv2.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(148, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 322);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtConver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpUno);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Conversor";
            this.grpUno.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.GroupBox grpUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConver;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstConv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstConv2;
        private System.Windows.Forms.Button btnClear;
    }
}