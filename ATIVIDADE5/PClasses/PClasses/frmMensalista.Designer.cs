
namespace PClasses
{
    partial class frmMensalista
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
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnInstanciarMensalistaPassandoParametros = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(157, 289);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(184, 48);
            this.btnInstanciarMensalista.TabIndex = 4;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInstanciarMensalistaPassandoParametros
            // 
            this.btnInstanciarMensalistaPassandoParametros.Location = new System.Drawing.Point(434, 289);
            this.btnInstanciarMensalistaPassandoParametros.Name = "btnInstanciarMensalistaPassandoParametros";
            this.btnInstanciarMensalistaPassandoParametros.Size = new System.Drawing.Size(200, 48);
            this.btnInstanciarMensalistaPassandoParametros.TabIndex = 5;
            this.btnInstanciarMensalistaPassandoParametros.Text = "Instanciar Mensalista Passando Parâmetros";
            this.btnInstanciarMensalistaPassandoParametros.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalistaPassandoParametros.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(434, 79);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 22);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(434, 177);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(100, 22);
            this.txtDataEntradaEmpresa.TabIndex = 7;
            // 
            // txtSalMensal
            // 
            this.txtSalMensal.Location = new System.Drawing.Point(434, 149);
            this.txtSalMensal.Name = "txtSalMensal";
            this.txtSalMensal.Size = new System.Drawing.Size(100, 22);
            this.txtSalMensal.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(434, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 22);
            this.txtNome.TabIndex = 9;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalMensal);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnInstanciarMensalistaPassandoParametros);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnInstanciarMensalistaPassandoParametros;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.TextBox txtSalMensal;
        private System.Windows.Forms.TextBox txtNome;
    }
}