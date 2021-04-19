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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover1_Click(object sender, EventArgs e)
        {
            int posicao;

            posicao = TxtPalavra2.Text.IndexOf(TxtPalavra1.Text);

            while (posicao >= 0)
            {

                TxtPalavra2.Text = TxtPalavra2.Text.Substring(0, posicao) +
                    TxtPalavra2.Text.Substring(posicao + TxtPalavra1.Text.Length,
                        TxtPalavra2.Text.Length - TxtPalavra1.Text.Length - posicao);

                posicao = TxtPalavra2.Text.IndexOf(TxtPalavra1.Text);

            }
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            TxtPalavra2.Text = TxtPalavra2.Text.Replace(TxtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            char[] meuArray = TxtPalavra1.Text.ToCharArray();
            Array.Reverse(meuArray);

            foreach (char c in meuArray)
            {
                TxtPalavra2.Text += c;
            }

        }
    }
}
