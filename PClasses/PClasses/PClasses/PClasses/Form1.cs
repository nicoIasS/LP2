using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensalista_Click(object sender, EventArgs e)
        {
            frmMensalista frmMensalista = new frmMensalista();
            frmMensalista.Show();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            frmHorista frmHorista = new frmHorista();
            frmHorista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste","mudei o titulo", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }
    }
}
