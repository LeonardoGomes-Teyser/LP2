using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulos
{
    public partial class Form1 : Form
    {
        double A, B, C;

        private void button1_Click(object sender, EventArgs e)
        {
            txt_resultado.Clear();
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_a.Text) || string.IsNullOrEmpty(txt_b.Text) || string.IsNullOrEmpty(txt_c.Text)) 
            {
                txt_resultado.Text = "Preencha os campos em branco";
            }
            else
            {
                if (double.TryParse(txt_a.Text, out A) && double.TryParse(txt_b.Text, out B) && double.TryParse(txt_c.Text, out C))
                {
                    if ((A == B) && (B == C) && (A == C))
                        txt_resultado.Text = "Equilatero";
                    else
                        txt_resultado.Text = "Isoceles";
                    if ((A != B) && (B != C) && (A != C))
                        txt_resultado.Text = "Escaleno";
                }
                else
                    txt_resultado.Text = "Digite números no campo";

            }

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
