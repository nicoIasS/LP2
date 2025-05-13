using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class frmEx5 : Form
    {
        public frmEx5()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {

        }

        private void frmEx5_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string [] gabarito = { "A", "B", "C", "D", "E", "D", "C", "B", "A", "E", };
            string auxiliar = ""; 
            for (int aluno = 0; aluno < 2; aluno++)
            {
                for (int resposta= 0; resposta < 10; resposta++)
                {
                    auxiliar = Interaction.InputBox("Digite a resposta" + ( resposta+ 1) + " do aluno " + (aluno+1), "Entrada de Dados");
                    if (auxiliar.ToUpper() == gabarito[resposta])
                    {
                        lBoxNotas.Items.Add("O aluno " + (aluno + 1) + " acertou a questão " + (resposta + 1) + " era " + gabarito[resposta] +
                            " escolheu " + auxiliar.ToUpper());
                    }
                    else
                    {
                        lBoxNotas.Items.Add("O aluno " + (aluno + 1) + " errou a questão " + (resposta + 1) + " era " + gabarito[resposta] +
                            " escolheu " + auxiliar.ToUpper());
                    }
                }

            }
        }
    }
}
