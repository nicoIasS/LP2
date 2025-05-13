using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Volume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura) || (altura <= 0))
            {
                MessageBox.Show("altura inválida!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        { 
            txtAltura.Text = "";
            txtRaio.Text = String.Empty;
            txtVolume.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio) || (raio <= 0))
            {
                MessageBox.Show("raio inválido!");
                txtRaio.Focus();
            }
            if (!double.TryParse(txtAltura.Text, out altura) || (altura <= 0))
            {
                MessageBox.Show("altura inválida!");
                txtRaio.Focus();
            }

            //volume = Math.PI * Math.Pow(double.Parse(txtRaio.Text), 2) * double.Parse(txtAltura.Text);
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            txtVolume.Text = volume.ToString("N2");
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtRaio.Text, out raio) || (raio <= 0)){
                MessageBox.Show("raio inválido!");
            }
        }
    }
}
