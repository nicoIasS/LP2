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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumbCnt_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int contNum = 0;

            while (cont < richTextBox1.Text.Length)
            {
                if (char.IsNumber(richTextBox1.Text[cont]))
                {
                    contNum++;
                }
                cont++;
            }

            MessageBox.Show($"O texto contém {contNum} caracteres numéricos.");
        }

        private void btn1Char_Click(object sender, EventArgs e)
        {
            int cont = 0;

            while (cont < richTextBox1.Text.Length)
            {
                if (char.IsWhiteSpace(richTextBox1.Text[cont]))
                {
                    MessageBox.Show($"O primeiro espaço em branco está na posição {cont}");
                    break;
                }
                cont++;
            }
        }

        private void btnCntLetra_Click(object sender, EventArgs e)
        {
            string texto = richTextBox1.Text;
            int contLetras = 0;

            foreach (char c in texto)
            {
                if (char.IsLetter(c))
                {
                    contLetras++;
                }
            }
            MessageBox.Show($"O texto contém {contLetras} letras.");
        }
    }
}
