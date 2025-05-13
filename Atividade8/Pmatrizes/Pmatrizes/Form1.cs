using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            for(int i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite o " + i+1 +"º dado", "Entrada de Dados");
                if(!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("número inválido");
                    i--;
                }
            }

            Array.Reverse(vetor);
            auxiliar = "";
            foreach (int dado in vetor) 
            {
                auxiliar += dado + "\n";
            
            }
            MessageBox.Show(auxiliar);
            /* auxiliar ="";
             auxilair = string.Join("\n",vetor);*/ 
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>(new string[] { "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otávio", "Marcelo", "Pedro", "Thais" });
            lista.Remove("Otávio");
            string auxiliar = "";
            auxiliar = string.Join("\n", lista);
            MessageBox.Show(auxiliar);
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Double[,] notas = new double[20, 3];
            double[] media = new double[20];
            double totNota;
            string aux="", auxString="";

            for (int aluno =0; aluno < 20; aluno++)
            {
                totNota = 0;
                for(int nota=0; nota< 3; nota++)
                {
                    aux = Interaction.InputBox("Digite a " + (nota+1) + "ª nota do aluno " + (aluno+1));
                    totNota += nota;
                    if(!Double.TryParse(aux,out notas[aluno,nota]) || notas[aluno,nota] <0 || notas[aluno, nota] > 10){
                        MessageBox.Show("Digite uma nota válida (entre 0 e 10)");
                    }
                }

                media[aluno] = totNota / 3;
            }
            
            for(int i = 0; i < 20; i++)
            {
                auxString += "Aluno " + (i + 1) + ": média " + media; 
            }

            MessageBox.Show(auxString);
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEx4>().Count() > 0)
            {
                Application.OpenForms["frmEx4"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmEx4 obj1 = new frmEx4(); // crio o objeto do novo formulario
                obj1.Show();
            }
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEx5>().Count() > 0)
            {
                Application.OpenForms["frmEx5"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                frmEx5 obj1 = new frmEx5(); // crio o objeto do novo formulario
                obj1.Show();
            }
        }
    }
}
