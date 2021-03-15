using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        double PesoIdeal, Altura, PesoAtual;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_peso_atual_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdb_homem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdb_mulher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void msktxt_altura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_peso_atual.Clear();
            msktxt_altura.Clear();
            txt_resultado.Clear();

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if ((txt_peso_atual.Text == "0"))
                txt_resultado.Text = "ERRO";

            else
            {
                if (double.TryParse(msktxt_altura.Text, out Altura) && double.TryParse(txt_peso_atual.Text, out PesoAtual))
                    PesoAtual = Convert.ToDouble(txt_peso_atual.Text);

                // Condição HOMEM
                if (rdb_homem.Checked)
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    PesoIdeal = Math.Round(PesoIdeal, 2);
                    if (PesoAtual == PesoIdeal)
                    {
                        txt_resultado.Text = PesoIdeal + "Kg. ";
                        MessageBox.Show("Parabéns! Você está no peso atual");
                    }
                    else if (PesoAtual < PesoIdeal)
                    {
                        txt_resultado.Text = PesoIdeal + "Kg. ";
                        MessageBox.Show("Coma mais desgraça!");
                    }
                    else if (PesoAtual > PesoIdeal)
                    {
                        txt_resultado.Text = PesoIdeal + "Kg. ";
                        MessageBox.Show("Faça dieta seu gordo!");
                    }
                }

                //Condição MULHER
                if (rdb_mulher.Checked)
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                    PesoIdeal = Math.Round(PesoIdeal, 2);
                    if (PesoAtual == PesoIdeal)
                    {
                        txt_resultado.Text = PesoIdeal + "Kg. ";
                        MessageBox.Show("Parabéns! Você está no peso atual");
                    }
                    else if (PesoAtual < PesoIdeal)
                    {
                        txt_resultado.Text = PesoIdeal + "Kg. ";
                        MessageBox.Show("Coma mais desgraça!");
                    }
                    else if (PesoAtual > PesoIdeal)
                    {
                        txt_resultado.Text = PesoIdeal + "Kg. ";
                        MessageBox.Show("Faça dieta sua gorda!");
                    }

                    if ((!rdb_homem.Checked) && (!rdb_mulher.Checked))
                        txt_resultado.Text = "Selecione o sexo!" + MessageBoxIcon.Error;

                }
            }
        }
    }
}

