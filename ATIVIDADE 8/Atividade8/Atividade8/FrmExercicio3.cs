using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int[] quantidade = new int[3];
            double[] valor = new double[3];
            double total = 0;

            for (int i = 0; i<quantidade.Length; i++)
            {
                var leitura = Interaction.InputBox($"Quantidade Vendida do item {i+1} ", "Recebendo Informação");

                if (!int.TryParse(leitura, out quantidade [i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                    continue;
                }

                leitura = Interaction.InputBox($"Valor do item {i + 1} ", "Recebendo Informação");

                if (!double.TryParse(leitura, out valor[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                    continue;
                }

                total = total + (quantidade[i] * valor[i]);

            }

            MessageBox.Show("Total Faturado = " + total);
        }

    }
}
