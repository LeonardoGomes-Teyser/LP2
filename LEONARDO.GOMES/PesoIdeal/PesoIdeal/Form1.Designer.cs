
namespace PesoIdeal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_calcular = new System.Windows.Forms.Button();
            this.rdb_mulher = new System.Windows.Forms.RadioButton();
            this.rdb_homem = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_peso_atual = new System.Windows.Forms.TextBox();
            this.msktxt_altura = new System.Windows.Forms.MaskedTextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Black;
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(27, 35);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(122, 72);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // rdb_mulher
            // 
            this.rdb_mulher.AutoSize = true;
            this.rdb_mulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mulher.Location = new System.Drawing.Point(663, 46);
            this.rdb_mulher.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_mulher.Name = "rdb_mulher";
            this.rdb_mulher.Size = new System.Drawing.Size(115, 29);
            this.rdb_mulher.TabIndex = 1;
            this.rdb_mulher.TabStop = true;
            this.rdb_mulher.Text = "MULHER";
            this.rdb_mulher.UseVisualStyleBackColor = true;
            this.rdb_mulher.CheckedChanged += new System.EventHandler(this.rdb_mulher_CheckedChanged);
            // 
            // rdb_homem
            // 
            this.rdb_homem.AutoSize = true;
            this.rdb_homem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_homem.Location = new System.Drawing.Point(7, 46);
            this.rdb_homem.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_homem.Name = "rdb_homem";
            this.rdb_homem.Size = new System.Drawing.Size(110, 29);
            this.rdb_homem.TabIndex = 2;
            this.rdb_homem.TabStop = true;
            this.rdb_homem.Text = "HOMEM";
            this.rdb_homem.UseVisualStyleBackColor = true;
            this.rdb_homem.CheckedChanged += new System.EventHandler(this.rdb_homem_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peso Atual:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_peso_atual
            // 
            this.txt_peso_atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_peso_atual.Location = new System.Drawing.Point(129, 42);
            this.txt_peso_atual.Margin = new System.Windows.Forms.Padding(4);
            this.txt_peso_atual.Name = "txt_peso_atual";
            this.txt_peso_atual.Size = new System.Drawing.Size(124, 27);
            this.txt_peso_atual.TabIndex = 6;
            this.txt_peso_atual.TextChanged += new System.EventHandler(this.txt_peso_atual_TextChanged);
            // 
            // msktxt_altura
            // 
            this.msktxt_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxt_altura.Location = new System.Drawing.Point(129, 95);
            this.msktxt_altura.Margin = new System.Windows.Forms.Padding(4);
            this.msktxt_altura.Mask = "0.00";
            this.msktxt_altura.Name = "msktxt_altura";
            this.msktxt_altura.Size = new System.Drawing.Size(124, 27);
            this.msktxt_altura.TabIndex = 7;
            this.msktxt_altura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxt_altura_MaskInputRejected);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.Black;
            this.bt_limpar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_limpar.Location = new System.Drawing.Point(206, 34);
            this.bt_limpar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(94, 35);
            this.bt_limpar.TabIndex = 8;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Black;
            this.bt_sair.ForeColor = System.Drawing.Color.Transparent;
            this.bt_sair.Location = new System.Drawing.Point(206, 73);
            this.bt_sair.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(94, 34);
            this.bt_sair.TabIndex = 9;
            this.bt_sair.Text = "SAIR";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Enabled = false;
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(428, 381);
            this.txt_resultado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(129, 34);
            this.txt_resultado.TabIndex = 10;
            this.txt_resultado.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "PESO IDEAL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rdb_homem);
            this.groupBox1.Controls.Add(this.rdb_mulher);
            this.groupBox1.Location = new System.Drawing.Point(78, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 93);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_peso_atual);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.msktxt_altura);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(73, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 144);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_calcular);
            this.groupBox3.Controls.Add(this.bt_limpar);
            this.groupBox3.Controls.Add(this.bt_sair);
            this.groupBox3.Location = new System.Drawing.Point(535, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 144);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(37, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 200);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Yellow;
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(976, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 363);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aviso!";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.txt_resultado);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(12, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(934, 448);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CÁLCULO DO PESO IDEAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 51);
            this.label3.TabIndex = 19;
            this.label3.Text = "PESO SINCERO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.RadioButton rdb_mulher;
        private System.Windows.Forms.RadioButton rdb_homem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_peso_atual;
        private System.Windows.Forms.MaskedTextBox msktxt_altura;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
    }
}

