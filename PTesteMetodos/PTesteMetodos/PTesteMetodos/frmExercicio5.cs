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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int n1, n2;

            if (int.TryParse(txtNumero1.Text, out n1) && int.TryParse(txtNumero2.Text, out n2))
            {
                if (n1 < n2)
                {
                    Random random = new Random();
                    int numeroSorteado = random.Next(n1, n2 + 1);
                    MessageBox.Show("Número sorteado: " + numeroSorteado);
                }
                else
                {
                    MessageBox.Show("O primeiro número deve ser menor que o segundo.");
                }
            }
            else
            {
                MessageBox.Show("Insira números válidos.");
            }
        }
    }
}
