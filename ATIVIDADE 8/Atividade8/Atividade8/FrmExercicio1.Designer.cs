﻿
namespace Atividade8
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
            this.BtnNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNumeros
            // 
            this.BtnNumeros.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumeros.ForeColor = System.Drawing.Color.Black;
            this.BtnNumeros.Location = new System.Drawing.Point(268, 238);
            this.BtnNumeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNumeros.Name = "BtnNumeros";
            this.BtnNumeros.Size = new System.Drawing.Size(259, 63);
            this.BtnNumeros.TabIndex = 0;
            this.BtnNumeros.Text = "Números";
            this.BtnNumeros.UseVisualStyleBackColor = true;
            this.BtnNumeros.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 554);
            this.Controls.Add(this.BtnNumeros);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNumeros;
    }
}