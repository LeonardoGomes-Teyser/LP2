using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            int quantidade = 0;
            string texto = rtfTexto.Text;

            if (texto != string.Empty)

                while (posicao < texto.Length)
                {
                    if (texto[posicao] == ' ')
                    {

                        quantidade++;
  
                    }

                    posicao++;

                }

            MessageBox.Show(quantidade.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int R = 0;


            foreach (char letra in rtfTexto.Text)
            {
                if (char.ToUpper(letra) == 'R')
                    R++;
                
            }

            MessageBox.Show(R.ToString());
        }

        private void BtnPar_Click(object sender, EventArgs e)
        {
            int Pares = 0;
            string texto =  rtfTexto.Text;

            for (int letra = 0; letra < rtfTexto.TextLength-1; letra++ )
            {
                if (texto[letra] == texto[letra + 1])
                    Pares++;
            }

            MessageBox.Show(Pares.ToString());
        }
    }
}
