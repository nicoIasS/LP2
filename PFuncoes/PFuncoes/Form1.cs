using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Soma1()
        {
            Double resultado = 2 + 3;
            MessageBox.Show("O resultado é: " + resultado);
        }



        private void btnSoma1_Click(object sender, EventArgs e)
        {
            Soma1();
        }


        Double Soma2()
        {
            Double resultado = 2 + 6;
            return resultado;

        }

        private void btnSoma2_Click(object sender, EventArgs e)
        {
            double auxiliar = Soma2();
            MessageBox.Show(auxiliar.ToString());
            //MessageBox.Show(Soma2().ToString());
        }

        void Soma3 (double x, double y)
        {
            Double resultado = x + y;

            MessageBox.Show("O resultado é: " + resultado.ToString());
        }

        private void btnSoma3_Click(object sender, EventArgs e)
        {
            Soma3(2,3);
        }

        Double Soma4(double x, double y) {
            Double resultado = x + y;
                return resultado;
        }

        private void btnSoma4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Soma4(2,3).ToString());
        }

        void Soma5(ref double resultado, ref double a)
        {
            a = 40;
            resultado = 2 + 3;
        }

        private void btnSoma5_Click(object sender, EventArgs e)
        {
            double r = 0;
            Double x = 20;
            Soma5(ref r,ref x);
            MessageBox.Show(x.ToString());
            MessageBox.Show(r.ToString());
        }

        Double Soma6(ref double dobro, double x, double y)
        {
            dobro = (x + y) * 2;
            return x + y;
        }

        private void btnSoma6_Click(object sender, EventArgs e)
        {
            double x = 2;
            double y = 5;
            double dobro = 0;
            MessageBox.Show($"soma={Soma6(ref dobro, x,y)}" + $"dobro={dobro}");
        }
    }
}
