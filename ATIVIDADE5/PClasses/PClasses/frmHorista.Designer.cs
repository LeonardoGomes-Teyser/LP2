
namespace PClasses
{
    partial class frmHorista
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
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalPorHora = new System.Windows.Forms.TextBox();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário por Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de Horas:";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(43, 208);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(176, 34);
            this.labelEmpresa.TabIndex = 4;
            this.labelEmpresa.Text = "Data Entrada na Empresa:\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dias de Faltas:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(240, 52);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(83, 22);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(240, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 22);
            this.txtNome.TabIndex = 7;
            // 
            // txtSalPorHora
            // 
            this.txtSalPorHora.Location = new System.Drawing.Point(240, 131);
            this.txtSalPorHora.Name = "txtSalPorHora";
            this.txtSalPorHora.Size = new System.Drawing.Size(83, 22);
            this.txtSalPorHora.TabIndex = 8;
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Location = new System.Drawing.Point(240, 170);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(83, 22);
            this.txtNumHoras.TabIndex = 9;
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(240, 203);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(123, 22);
            this.txtDataEntradaEmpresa.TabIndex = 10;
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(240, 238);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(83, 22);
            this.txtDiasFalta.TabIndex = 11;
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(307, 324);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(145, 44);
            this.btnInstanciarHorista.TabIndex = 12;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.btnInstanciarHorista_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.txtSalPorHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalPorHora;
        private System.Windows.Forms.TextBox txtNumHoras;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Button btnInstanciarHorista;
    }
}