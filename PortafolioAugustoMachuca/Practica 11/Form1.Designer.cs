namespace Practica_11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCir = new System.Windows.Forms.RadioButton();
            this.rdoCua = new System.Windows.Forms.RadioButton();
            this.rdoTrian = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTrian);
            this.groupBox1.Controls.Add(this.rdoCua);
            this.groupBox1.Controls.Add(this.rdoCir);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione:";
            // 
            // rdoCir
            // 
            this.rdoCir.AutoSize = true;
            this.rdoCir.Location = new System.Drawing.Point(7, 41);
            this.rdoCir.Name = "rdoCir";
            this.rdoCir.Size = new System.Drawing.Size(72, 21);
            this.rdoCir.TabIndex = 0;
            this.rdoCir.Text = "Círculo";
            this.rdoCir.UseVisualStyleBackColor = true;
            this.rdoCir.CheckedChanged += new System.EventHandler(this.rdoCir_CheckedChanged);
            // 
            // rdoCua
            // 
            this.rdoCua.AutoSize = true;
            this.rdoCua.Location = new System.Drawing.Point(7, 89);
            this.rdoCua.Name = "rdoCua";
            this.rdoCua.Size = new System.Drawing.Size(91, 21);
            this.rdoCua.TabIndex = 1;
            this.rdoCua.Text = "Cuadrado";
            this.rdoCua.UseVisualStyleBackColor = true;
            this.rdoCua.CheckedChanged += new System.EventHandler(this.rdoCua_CheckedChanged);
            // 
            // rdoTrian
            // 
            this.rdoTrian.AutoSize = true;
            this.rdoTrian.Location = new System.Drawing.Point(7, 142);
            this.rdoTrian.Name = "rdoTrian";
            this.rdoTrian.Size = new System.Drawing.Size(89, 21);
            this.rdoTrian.TabIndex = 2;
            this.rdoTrian.Text = "Tríangulo";
            this.rdoTrian.UseVisualStyleBackColor = true;
            this.rdoTrian.CheckedChanged += new System.EventHandler(this.rdoTrian_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(21, 239);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(107, 24);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "El área es:";
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(249, 241);
            this.txtResp.Name = "txtResp";
            this.txtResp.ReadOnly = true;
            this.txtResp.Size = new System.Drawing.Size(133, 22);
            this.txtResp.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(249, 53);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(133, 22);
            this.txt1.TabIndex = 4;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(249, 123);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(133, 22);
            this.txt2.TabIndex = 5;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(246, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 17);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Valor 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(246, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 17);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Valor 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 280);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Figuras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTrian;
        private System.Windows.Forms.RadioButton rdoCua;
        private System.Windows.Forms.RadioButton rdoCir;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

