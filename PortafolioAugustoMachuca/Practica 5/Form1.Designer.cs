namespace Practica_5
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
            this.lstVendedor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdAsc = new System.Windows.Forms.Button();
            this.btnOrdDes = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstVendedor
            // 
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.ItemHeight = 16;
            this.lstVendedor.Location = new System.Drawing.Point(12, 54);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(179, 340);
            this.lstVendedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedores";
            // 
            // btnOrdAsc
            // 
            this.btnOrdAsc.Location = new System.Drawing.Point(225, 63);
            this.btnOrdAsc.Name = "btnOrdAsc";
            this.btnOrdAsc.Size = new System.Drawing.Size(102, 28);
            this.btnOrdAsc.TabIndex = 2;
            this.btnOrdAsc.Text = "Ordenar A-Z";
            this.btnOrdAsc.UseVisualStyleBackColor = true;
            this.btnOrdAsc.Click += new System.EventHandler(this.btnOrdAsc_Click);
            // 
            // btnOrdDes
            // 
            this.btnOrdDes.Location = new System.Drawing.Point(225, 106);
            this.btnOrdDes.Name = "btnOrdDes";
            this.btnOrdDes.Size = new System.Drawing.Size(102, 26);
            this.btnOrdDes.TabIndex = 3;
            this.btnOrdDes.Text = "Ordenar Z-A";
            this.btnOrdDes.UseVisualStyleBackColor = true;
            this.btnOrdDes.Click += new System.EventHandler(this.btnOrdDes_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(225, 147);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(102, 26);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(227, 371);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 22);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // txtBuscarNom
            // 
            this.txtBuscarNom.Location = new System.Drawing.Point(227, 329);
            this.txtBuscarNom.Name = "txtBuscarNom";
            this.txtBuscarNom.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarNom.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 422);
            this.Controls.Add(this.txtBuscarNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnOrdDes);
            this.Controls.Add(this.btnOrdAsc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVendedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdAsc;
        private System.Windows.Forms.Button btnOrdDes;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNom;
    }
}

