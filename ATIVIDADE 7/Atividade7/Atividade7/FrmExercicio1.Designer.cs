
namespace Atividade7
{
    partial class FrmExercicio1
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
            this.rtfTexto = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.BtnPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfTexto
            // 
            this.rtfTexto.Location = new System.Drawing.Point(64, 76);
            this.rtfTexto.Name = "rtfTexto";
            this.rtfTexto.Size = new System.Drawing.Size(940, 94);
            this.rtfTexto.TabIndex = 0;
            this.rtfTexto.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBranco.Location = new System.Drawing.Point(64, 259);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(154, 82);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Numero de Espaços em Branco\r\n";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnR
            // 
            this.BtnR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnR.Location = new System.Drawing.Point(452, 262);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(167, 79);
            this.BtnR.TabIndex = 2;
            this.BtnR.Text = "Quantidade de \"R\"";
            this.BtnR.UseVisualStyleBackColor = true;
            this.BtnR.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnPar
            // 
            this.BtnPar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPar.Location = new System.Drawing.Point(842, 259);
            this.BtnPar.Name = "BtnPar";
            this.BtnPar.Size = new System.Drawing.Size(162, 82);
            this.BtnPar.TabIndex = 3;
            this.BtnPar.Text = "Par de letras repetidas";
            this.BtnPar.UseVisualStyleBackColor = true;
            this.BtnPar.Click += new System.EventHandler(this.BtnPar_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.BtnPar);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rtfTexto);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfTexto;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button BtnR;
        private System.Windows.Forms.Button BtnPar;
    }
}