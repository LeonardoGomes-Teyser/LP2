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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnNomes_Click(object sender, EventArgs e)
        {
            // criar uma lista e adicionar nomes
            List<string> Nomes = new List<string>()
            {
              "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            //remover um determinado nome
            Nomes.Remove("Otávio");

            // imprimir a lista de nomes
            string saida = "";

            foreach (string nome in Nomes)
            {
                saida += nome + "\n";
            }
            MessageBox.Show(saida);
        }
    }
}
