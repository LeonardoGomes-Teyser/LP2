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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(TxtN.Text);
            double h = 1;

            if (n > 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    h += 1.0 / i;
                }

                MessageBox.Show(h.ToString("N2"));
            }
        }
    }
}
