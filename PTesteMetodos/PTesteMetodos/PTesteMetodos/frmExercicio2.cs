using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtBoxPalavra1.Text, txtBoxPalavra2.Text) == 0)
            {
                MessageBox.Show("As palavras são iguais");
            }
            else
            {
                MessageBox.Show("As palavras são diferentes");
            }
        }

        private void btnInserir1no2_Click(object sender, EventArgs e)
        {
            txtBoxPalavra2.Text = "";
            string texto1 = txtBoxPalavra1.Text;
            string texto2 = txtBoxPalavra2.Text;
            int meio = texto2.Length / 2;
            string resultado = texto2.Insert(meio, texto1);
            txtBoxPalavra2.Text = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = txtBoxPalavra1.Text;
            int meio = texto1.Length / 2;
            string resultado = texto1.Insert(meio, "**");
            txtBoxPalavra2.Text = resultado;
        }
    }
}
