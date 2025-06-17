using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFerramenta0030482421016
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            try
            {
                conexao = new SqlConnection("Data Source=APOLO;Persist Security Info=True;User ID=BD2421009;Password=Fodase123 ");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados = /" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros = /" + ex.Message);
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<frmCategoria>().Count() > 0)
            {
                Application.OpenForms["frmCategoria"].BringToFront();
            }
            else
            {
                frmCategoria FrmCategoria = new frmCategoria();
                FrmCategoria.MdiParent = this;
                FrmCategoria.WindowState = FormWindowState.Maximized;
                FrmCategoria.Show();
            }
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFabricante>().Count() > 0)
            {
                Application.OpenForms["frmFabricante"].BringToFront();
            }
            else
            {
                frmFabricante frmFabricante = new frmFabricante();
                frmFabricante.MdiParent = this;
                frmFabricante.WindowState = FormWindowState.Maximized;
                frmFabricante.Show();
            }
        }

        private void ferramentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFerramenta>().Count() > 0)
            {
                Application.OpenForms["frmFerramentas"].BringToFront();
            }
            else
            {
                frmFerramenta frmFerramenta = new frmFerramenta();
                frmFerramenta.MdiParent = this;
                frmFerramenta.WindowState = FormWindowState.Maximized;
                frmFerramenta.Show();
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sObreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                Application.OpenForms["frmSobre"].BringToFront();
            }
            else
            {
                frmSobre frmSobre = new frmSobre();
                frmSobre.MdiParent = this;
                frmSobre.WindowState = FormWindowState.Maximized;
                frmSobre.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
