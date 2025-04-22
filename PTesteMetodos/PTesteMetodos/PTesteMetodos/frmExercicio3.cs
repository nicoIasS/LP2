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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string texto1 = txtPalavra1.Text;
            string texto2 = txtPalavra2.Text;
            string resultado = texto2.Replace(texto1, string.Empty);
            txtPalavra2.Text = resultado;
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);
            txtPalavra2.Text = "";
            foreach (char c in vetor)
            {
                txtPalavra2.Text += c;
            }
            //outro jeito:
            //string auxiliar = new string(vetor);
            //txtPalavra1.Text = auxiliar;
        }

        private void txtBoxPalavra1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
