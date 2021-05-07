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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form aberto = new Form();

        private void atividade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio1 objFrm1 = new FrmExercicio1();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();

            aberto = objFrm1;
        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio2 objFrm2 = new FrmExercicio2();
            objFrm2.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();

            aberto = objFrm2;
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio3 objFrm3 = new FrmExercicio3();
            objFrm3.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();

            aberto = objFrm3;
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio4 objFrm4 = new FrmExercicio4();
            objFrm4.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();

            aberto = objFrm4;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
