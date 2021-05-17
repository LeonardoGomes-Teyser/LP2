using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade8
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            string[] Alunos =
                {"Viviane",
                "André",
                "Hélio",
                "Denise",
                "Junior",
                "Leonardo",
                "Jose",
                "Nelma",
                "Tobby"
                        };

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;

            for (I=0; I < N-1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show("A resposta é = " + Total);
        }
    }
}
