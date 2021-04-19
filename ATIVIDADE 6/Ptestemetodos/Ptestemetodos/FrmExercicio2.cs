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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
             int meio = TxtPalavra1.Text.Length / 2;
                TxtPalavra2.Text = TxtPalavra1.Text.Insert(meio, "**");
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (String.Compare(TxtPalavra1.Text, TxtPalavra2.Text)==0)
                MessageBox.Show("As palavras são iguais");
            else
                MessageBox.Show("As palavras são diferentes");
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int metade = TxtPalavra2.Text.Length / 2;

            TxtPalavra2.Text = TxtPalavra2.Text.Substring(0, metade) +
                TxtPalavra1.Text +
                TxtPalavra2.Text.Substring(metade, TxtPalavra2.Text.Length - metade);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void TxtPalavra1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmExercicio2_Load(object sender, EventArgs e)
        {

        }
    }
}
