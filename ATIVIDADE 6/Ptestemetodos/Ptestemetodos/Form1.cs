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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        Form aberto = new Form();

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrei no copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrei no colar");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio2 objFrm2 = new FrmExercicio2();
            objFrm2.MdiParent = this; 
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();

            aberto = objFrm2;
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio3 objFrm3 = new FrmExercicio3();
            objFrm3.MdiParent = this; 
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();

            aberto = objFrm3;
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio4 objFrm4 = new FrmExercicio4();
            objFrm4.MdiParent = this; 
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();

            aberto = objFrm4;
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio5 objFrm5 = new FrmExercicio5();
            objFrm5.MdiParent = this; 
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();

            aberto = objFrm5;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
