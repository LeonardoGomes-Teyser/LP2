
namespace Ptestemetodos
{
    partial class FrmExercicio2
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
            this.TxtPalavra1 = new System.Windows.Forms.TextBox();
            this.TxtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPalavra1
            // 
            this.TxtPalavra1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPalavra1.Location = new System.Drawing.Point(149, 12);
            this.TxtPalavra1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPalavra1.Name = "TxtPalavra1";
            this.TxtPalavra1.Size = new System.Drawing.Size(301, 34);
            this.TxtPalavra1.TabIndex = 0;
            this.TxtPalavra1.TextChanged += new System.EventHandler(this.TxtPalavra1_TextChanged);
            // 
            // TxtPalavra2
            // 
            this.TxtPalavra2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPalavra2.Location = new System.Drawing.Point(149, 77);
            this.TxtPalavra2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPalavra2.Name = "TxtPalavra2";
            this.TxtPalavra2.Size = new System.Drawing.Size(301, 34);
            this.TxtPalavra2.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(17, 143);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(194, 65);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Testar se são iguais\r\n";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir1.Location = new System.Drawing.Point(267, 143);
            this.btnInserir1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(183, 65);
            this.btnInserir1.TabIndex = 3;
            this.btnInserir1.Text = "Inserir o 1º no meio do 2º";
            this.btnInserir1.UseVisualStyleBackColor = false;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInserir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir2.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir2.Location = new System.Drawing.Point(149, 238);
            this.btnInserir2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(194, 65);
            this.btnInserir2.TabIndex = 4;
            this.btnInserir2.Text = "Inserir Asteriscos no meio do 1º ";
            this.btnInserir2.UseVisualStyleBackColor = false;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.BackColor = System.Drawing.Color.Transparent;
            this.lblPalavra1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPalavra1.Location = new System.Drawing.Point(11, 12);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(108, 33);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.BackColor = System.Drawing.Color.Transparent;
            this.lblPalavra2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPalavra2.Location = new System.Drawing.Point(11, 78);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(108, 33);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 418);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.TxtPalavra2);
            this.Controls.Add(this.TxtPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(734, 465);
            this.MinimumSize = new System.Drawing.Size(734, 465);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.Load += new System.EventHandler(this.FrmExercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPalavra1;
        private System.Windows.Forms.TextBox TxtPalavra2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}