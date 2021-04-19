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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            int n1 = Int32.Parse(TxtN1.Text);
            int n2 = Int32.Parse(TxtN2.Text);
            int escolha = aleatorio.Next(n1, n2);

            MessageBox.Show(escolha.ToString());

        }
    }
}
