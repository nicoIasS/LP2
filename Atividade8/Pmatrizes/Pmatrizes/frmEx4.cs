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
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            string[] vetor = new string[10];
            string auxiliar = "";
            int charCnt=0;
            for (int i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite o " + (i + 1) + "º nome", "Entrada de Dados");
                vetor[i] = auxiliar;
                charCnt = 0;
                for (int c=0; c < vetor[i].Length; c++)
                {
                    if (vetor[i].Substring(c,1) != " ")
                    {
                        charCnt++;
                    }

                }
                lboxNomes.Items.Add("O nome: " + vetor[i] + " tem " + charCnt + " caracteres");
            }
            
        }

        private void lboxNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
