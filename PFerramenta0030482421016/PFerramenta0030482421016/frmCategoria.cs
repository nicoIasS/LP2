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
    public partial class frmCategoria : Form
    {
        private BindingSource bnCategoria = new BindingSource();
        private bool bInlcusao = false;
        private DataSet dsCategoria = new DataSet();


        public frmCategoria()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                Categoria RegCat = new Categoria();
                dsCategoria.Tables.Add(RegCat.Listar());
                bnCategoria.DataSource = dsCategoria.Tables["CATEGORIA"];
                dgvCategoria.DataSource = bnCategoria;
                bnvCategoria.BindingSource = bnCategoria;

                txtId.DataBindings.Add("TEXT", bnCategoria, "id");
                txtDescricao.DataBindings.Add("TEXT", bnCategoria, "descricao");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if(tbCategoria.SelectedIndex == 0)
            {
                tbCategoria.SelectTab(1);
            }

            bnCategoria.AddNew();
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
            btnSalvar.Enabled= true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInlcusao = true;
        }
    }
}
