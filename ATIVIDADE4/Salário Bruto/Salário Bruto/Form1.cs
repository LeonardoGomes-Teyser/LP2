using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salário_Bruto
{
    public partial class Form1 : Form
    {
        string Nome, EstadoCivil;
        double SalBruto, NumFilhos, SalFamilia;

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSalFamilia.Clear();
            txtSalLiquid.Clear();
            txtDescIRFF.Clear();
            txtDescINSS.Clear();
            txtAliqIRFF.Clear();
            txtAliqINSS.Clear();
            mskbFilhos.Clear();
            mskbSalBrut.Clear();
            ckbxCasado.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNome.Text) || (txtNome.Text.Length < 7))
            {
                MessageBox.Show("Nome Inválido");
            }
            else
            {
                if(double.TryParse(mskbSalBrut.Text, out SalBruto) && double.TryParse(mskbFilhos.Text, out NumFilhos))
                {
                    double SalLiquid = 0;
                    double DescINSS = 0;
                    double DescIRFF = 0;

                    lblInfo.Visible = true;
                    Nome = txtNome.Text;

                    //Casado ou solteiro
                    if (ckbxCasado.Checked)
                    EstadoCivil = "Casado(a)";
                    else
                        EstadoCivil = "Solteiro(a)";

                    //Menssagem para o usuário sobre suas informações
                    if (rdbMasculino.Checked)
                        lblInfo.Text = "Os descontos do salário do Sr." + Nome + " que é " + EstadoCivil + " e que tem " + NumFilhos + " filho(s) são: ";
                    else
                        lblInfo.Text = "Os descontos do salário do Sra." + Nome + " que é " + EstadoCivil + " e que tem " + NumFilhos + " filho(s) são: ";


                    // Calculo de desconto do INSS
                    if(SalBruto <= 800.47)
                    {
                        txtAliqINSS.Text = "7.65%";
                        DescINSS = 7.65 / 100 * SalBruto;
                    }
                    else if (SalBruto <= 1050)
                    {
                        txtAliqINSS.Text = "8.65%";
                        DescINSS = 8.65 / 100 * SalBruto;
                    }
                    else if (SalBruto <= 1400.77)
                    {
                        txtAliqINSS.Text = "9%";
                        DescINSS = 9 / 100 * SalBruto;
                    }
                    else if (SalBruto <= 2801.56)
                    {
                        txtAliqINSS.Text = "11%";
                        DescINSS = 11 / 100 * SalBruto;
                    }
                    else if (SalBruto > 2801.56)
                    {
                        txtAliqINSS.Text = "R$ 308.17";
                        DescINSS = 308.17;
                    }
                    DescINSS = Math.Round(DescINSS, 2);
                    txtDescINSS.Text = "R$ " + DescINSS.ToString();

                    //Calculo do desconto do IRFF
                    if(SalBruto <= 1257.12)
                    {
                        txtAliqIRFF.Text = "Isento";
                        DescIRFF = 0;
                    }
                    else if(SalBruto <= 2512.00)
                    {
                        txtAliqIRFF.Text = "15%";
                        DescIRFF = 15 / 100 * SalBruto;
                    }
                    else if (SalBruto > 2512.00)
                    {
                        txtAliqIRFF.Text = "27.5%";
                        DescIRFF = 27.5 / 100 * SalBruto;
                    }
                    DescIRFF = Math.Round(DescIRFF, 2);
                    txtDescIRFF.Text = "R$ " + DescIRFF.ToString();

                    //Cálculo do salário da família 
                    if (SalBruto <= 435.52)
                        SalFamilia = 22.33 * NumFilhos;
                    else if (SalBruto <= 654.61)
                        SalFamilia = 15.74 * NumFilhos;
                    else if (SalBruto > 654.61)
                        SalFamilia = 0;
                    txtSalFamilia.Text = "R$ " + SalFamilia;

                    //Cálculo do salçario líquido
                    SalLiquid = SalBruto - DescINSS - DescIRFF + SalFamilia;
                    txtSalLiquid.Text = "R$ " + SalLiquid.ToString();

                 





                }
                else
                {
                    MessageBox.Show("Preencha os dados corretamente");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
