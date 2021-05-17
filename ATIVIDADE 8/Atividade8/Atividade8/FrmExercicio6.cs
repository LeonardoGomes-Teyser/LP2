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
    public partial class FrmExercicio6 : Form
    {
        public FrmExercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //// receber as três notas de cada aluno

            int linha = 20; // quantiade de alunos
            int coluna = 3; // quantidade de notas

            // matriz:
            double[,] notas = new double[linha, coluna];


            /// calcular média
            double[] notaAluno = new double[linha];

            /// imprimir o resultado
            string saida = "";

            // o processamento 
            for (int i=0; i<linha; i++)
            {
                notaAluno[i] = 0;

                for (int j = 0; j < coluna; j++)
                {
                    var nota = Interaction.InputBox($"Nota #{j + 1}", $"Entre com a nota do aluno {i + 1}");

                    if (!double.TryParse(nota, out notas[i, j]))
                    {
                        MessageBox.Show("Erro");
                        j--;
                        continue;
                    }

                    notaAluno[i] += notas[i, j];
                }

                notaAluno[i] = notaAluno[i] / 3.0;
                saida += $"Aluno {i + 1}: média: {notaAluno[i]:N2} \n ";
            }

            MessageBox.Show(saida);

        }
    }
}
