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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form aberto = new Form();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio1 objFrm1 = new FrmExercicio1();
            objFrm1.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm1.WindowState = FormWindowState.Maximized;
            objFrm1.Show();

            aberto = objFrm1;
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio2 objFrm2 = new FrmExercicio2();
            objFrm2.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();

            aberto = objFrm2;
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio3 objFrm3 = new FrmExercicio3();
            objFrm3.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();

            aberto = objFrm3;
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio4 objFrm4 = new FrmExercicio4();
            objFrm4.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();

            aberto = objFrm4;
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio5 objFrm5 = new FrmExercicio5();
            objFrm5.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();

            aberto = objFrm5;
        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio6 objFrm6 = new FrmExercicio6();
            objFrm6.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm6.WindowState = FormWindowState.Maximized;
            objFrm6.Show();

            aberto = objFrm6;
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Close();

            FrmExercicio7 objFrm7 = new FrmExercicio7();
            objFrm7.MdiParent = this; // componente atual no caso o FrmPrincipal
            objFrm7.WindowState = FormWindowState.Maximized;
            objFrm7.Show();

            aberto = objFrm7;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
