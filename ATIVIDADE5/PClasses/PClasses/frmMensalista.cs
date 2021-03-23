using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtDataEntradaEmpresa.Text),
                Convert.ToDouble(txtSalMensal.Text));

            //get
            MessageBox.Show("Matricula :" + objMensalista.Matricula + "\n" +
                            "Nome : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias):" + objMensalista.TempoTrabalho());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Criar ou instanciar o objeto da classe mesnsalista 
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalMensal.Text);

            //get
            MessageBox.Show("Matricula :" + objMensalista.Matricula + "\n" +
                            "Nome : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias):" + objMensalista.TempoTrabalho());
        }
    }
}


