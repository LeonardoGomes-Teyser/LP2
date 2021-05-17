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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";


            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Entrar com o dado da posição:" + (i + 1).ToString(),
                "Entrada de Dados");



                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                }
            }
            auxiliar = "";

            Array.Reverse(vetor);

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                auxiliar += vetor[i] + "\n";
            }

            MessageBox.Show(auxiliar);
        }
    }
}
