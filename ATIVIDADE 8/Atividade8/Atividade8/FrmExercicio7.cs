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
    public partial class FrmExercicio7 : Form
    {
        public FrmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // int tam = 3;
            string[] nomes = new string[9];
            int[] letras = new int[nomes.Length];

            for (int i=0; i<nomes.Length; i++)
            {
                var leitura = Interaction.InputBox("Entre com o #{} nome", "Leitura de Nomes");

                if (string.IsNullOrEmpty(leitura))
                {
                    MessageBox.Show("Nome inválido");
                    i--;
                    continue;
                }

                // Se sucesso, passe o nome

                nomes[i] = leitura;
                int quantidade = 0;

                foreach(char letra in nomes[i])
                {
                    if (letra != ' ')
                        quantidade++;
                }

                // adiciono a quantidade de letras ao meu vetor referente a posição do nome
                letras[i] = quantidade;
            }

                // gerar uma saida
            for (int i=0; i<nomes.Length;i++)
            {
                ListNomes.Items.Add($"o nome: {nomes[i]} tem {letras[i]} caracteres \n");
            }
        }
    }
}
