using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFerramenta0030482421016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.CATEGORIA'. Você pode movê-la ou removê-la conforme necessário.
            this.cATEGORIATableAdapter.Fill(this.dataSet1.CATEGORIA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cATEGORIATableAdapter.Update(this.dataSet1.CATEGORIA);
        }
    }
}
