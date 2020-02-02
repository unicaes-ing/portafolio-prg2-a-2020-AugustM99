namespace Practica1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInv1 = new System.Windows.Forms.TextBox();
            this.txtInv2 = new System.Windows.Forms.TextBox();
            this.txtInv3 = new System.Windows.Forms.TextBox();
            this.txtPorcen1 = new System.Windows.Forms.TextBox();
            this.txtPorcen2 = new System.Windows.Forms.TextBox();
            this.txtPorcen3 = new System.Windows.Forms.TextBox();
            this.txtTotInv = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversionistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porcentajes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Inversión:";
            // 
            // txtInv1
            // 
            this.txtInv1.Location = new System.Drawing.Point(46, 59);
            this.txtInv1.Name = "txtInv1";
            this.txtInv1.Size = new System.Drawing.Size(109, 22);
            this.txtInv1.TabIndex = 6;
            this.txtInv1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtInv2
            // 
            this.txtInv2.Location = new System.Drawing.Point(46, 113);
            this.txtInv2.Name = "txtInv2";
            this.txtInv2.Size = new System.Drawing.Size(109, 22);
            this.txtInv2.TabIndex = 7;
            // 
            // txtInv3
            // 
            this.txtInv3.Location = new System.Drawing.Point(46, 166);
            this.txtInv3.Name = "txtInv3";
            this.txtInv3.Size = new System.Drawing.Size(109, 22);
            this.txtInv3.TabIndex = 8;
            // 
            // txtPorcen1
            // 
            this.txtPorcen1.Location = new System.Drawing.Point(192, 59);
            this.txtPorcen1.Name = "txtPorcen1";
            this.txtPorcen1.ReadOnly = true;
            this.txtPorcen1.Size = new System.Drawing.Size(107, 22);
            this.txtPorcen1.TabIndex = 9;
            // 
            // txtPorcen2
            // 
            this.txtPorcen2.Location = new System.Drawing.Point(192, 113);
            this.txtPorcen2.Name = "txtPorcen2";
            this.txtPorcen2.ReadOnly = true;
            this.txtPorcen2.Size = new System.Drawing.Size(107, 22);
            this.txtPorcen2.TabIndex = 10;
            // 
            // txtPorcen3
            // 
            this.txtPorcen3.Location = new System.Drawing.Point(192, 166);
            this.txtPorcen3.Name = "txtPorcen3";
            this.txtPorcen3.ReadOnly = true;
            this.txtPorcen3.Size = new System.Drawing.Size(107, 22);
            this.txtPorcen3.TabIndex = 11;
            // 
            // txtTotInv
            // 
            this.txtTotInv.Location = new System.Drawing.Point(50, 235);
            this.txtTotInv.Name = "txtTotInv";
            this.txtTotInv.ReadOnly = true;
            this.txtTotInv.Size = new System.Drawing.Size(120, 22);
            this.txtTotInv.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(243, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(130, 271);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 271);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 306);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotInv);
            this.Controls.Add(this.txtPorcen3);
            this.Controls.Add(this.txtPorcen2);
            this.Controls.Add(this.txtPorcen1);
            this.Controls.Add(this.txtInv3);
            this.Controls.Add(this.txtInv2);
            this.Controls.Add(this.txtInv1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Inversiones";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.TextBox txtInv1;
        private System.Windows.Forms.TextBox txtInv2;
        private System.Windows.Forms.TextBox txtInv3;
        private System.Windows.Forms.TextBox txtPorcen1;
        private System.Windows.Forms.TextBox txtPorcen2;
        private System.Windows.Forms.TextBox txtPorcen3;
        private System.Windows.Forms.TextBox txtTotInv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalc;
    }
}