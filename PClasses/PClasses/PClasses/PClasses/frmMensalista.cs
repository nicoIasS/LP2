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

        private void btnInstMensPrmt_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                    Convert.ToInt32(txtMatricula.Text),
                    txtNome.Text,
                    Convert.ToDateTime(txtData.Text),
                    Convert.ToDouble(txtSal.Text)
                );

            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado + "\n" + "Matricula=" + objMensalista.Matricula + "\n" + "Tempo Trabalho= " + objMensalista.DataEntradaEmpresa + "\n" +
                "Salário Final: " + objMensalista.SalarioBruto().ToString("N2"));

        }

        private void btnInstMensal_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSal.Text);

            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado + "\n" + "Matricula=" + objMensalista.Matricula + "\n" + "Tempo Trabalho= " + objMensalista.DataEntradaEmpresa+ "\n" +
                "Salário Final: " + objMensalista.SalarioBruto().ToString("N2"));
        
        }

    }
}
