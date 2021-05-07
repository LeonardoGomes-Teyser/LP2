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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string texto = TxtPalavra.Text;

            // remover os espaço

            texto = texto.Replace(" ", "");

            // deixar maiusculo

            texto = texto.ToUpper();

            // inverter 

            string textoInvertido = new string(texto.Reverse().ToArray());

            // comparar 

            if (texto == textoInvertido)
            {
                MessageBox.Show("É palíndromo");
            }
            else
                MessageBox.Show("Não é palíndromo");
        }
    }
}
