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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercícioP2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frmExercicio2 formEx2 = new frmExercicio2();
                formEx2.MdiParent = this;
                formEx2.WindowState = FormWindowState.Maximized;
                formEx2.Show();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolheu copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolheu colar");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicioP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frmExercicio3 formEx3 = new frmExercicio3();
                formEx3.MdiParent = this;
                formEx3.WindowState = FormWindowState.Maximized;
                formEx3.Show();
            }
        }

        private void exercícioP4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frmExercicio4 formEx4 = new frmExercicio4();
                formEx4.MdiParent = this;
                formEx4.WindowState = FormWindowState.Maximized;
                formEx4.Show();
            }
        }

        private void exercícioP5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio5"].BringToFront();
            }
            else
            {
                frmExercicio5 formEx5 = new frmExercicio5();
                formEx5.MdiParent = this;
                formEx5.WindowState = FormWindowState.Maximized;
                formEx5.Show();
            }
        }
    }
}
