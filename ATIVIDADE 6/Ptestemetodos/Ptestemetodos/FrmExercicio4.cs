using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int letra;
            int quantidade=0;

            for (letra = 0; letra < rtfTexto.Text.Length; letra++)
            {
                if (char.IsDigit(rtfTexto.Text[letra]))
                {
                    quantidade++;
                }
            }

            MessageBox.Show(quantidade.ToString());
        }


        private void btnBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            while ( !char.IsWhiteSpace(rtfTexto.Text[posicao]))
            {
                if (posicao == rtfTexto.Text.Length-1)
                {

                    posicao = 0;
                    break;
                }

                    posicao++;
                
            }

            MessageBox.Show(posicao.ToString()); 
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int quantidade = 0;


            foreach (char letra in rtfTexto.Text)
            {
                if (char.IsLetter(letra))
                    quantidade++;
            }



            MessageBox.Show(quantidade.ToString());
        }
    }
}
