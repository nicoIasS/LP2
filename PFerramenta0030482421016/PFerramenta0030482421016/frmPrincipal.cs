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

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
