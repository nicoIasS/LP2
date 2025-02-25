using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskbxSalario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Numeros = "0123456789";
            bool temNumero = Numeros.Contains(e.KeyChar);

            if (temNumero) {
                MessageBox.Show("nome não pode ter números");
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void txtEndereco_Validating(object sender, CancelEventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                MessageBox.Show("Endereço inválido!");
                e.Cancel = true;
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("E-mail inválido");
                txtEmail.Focus();
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void mskbxDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskbxDataNasc_Validated(object sender, EventArgs e)
        {
            DateTime dtNasc;

            if(!DateTime.TryParse(mskbxDataNasc.Text, out dtNasc))
            {
                MessageBox.Show("Data inválida! ");
                mskbxDataNasc.Focus();
            }
            else
            {
                MessageBox.Show("A data é : " + dtNasc.ToShortDateString());
            }
        }

        private void mskbxSalario_Validated(object sender, EventArgs e)
        {
            double salario;
            //salario = Convert.ToDouble( mskbxSalario.Text); //da buxa por algum motivo
            //if (salario < 0)
            if(!Double.TryParse(mskbxSalario.Text, out salario))
            {
                MessageBox.Show("Salário inválido");
                mskbxSalario.Focus();
            }
            else
            {
                MessageBox.Show("Salário inserido");
            }
        }

        private void mskbxDataNasc_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Data perdeu o foco");
        }
    }
}
