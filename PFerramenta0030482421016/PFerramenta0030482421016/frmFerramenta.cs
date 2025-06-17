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
    public partial class frmFerramenta : Form
    {
        private BindingSource bnFerramenta = new BindingSource();
        private bool bInlcusao = false;
        private DataSet dsFerramenta = new DataSet();
        private DataSet dsCategoria = new DataSet();
        private DataSet dsFabricante = new DataSet();
        

        public frmFerramenta()
        {
            InitializeComponent();
        }

        private void frmFerramenta_Load(object sender, EventArgs e)
        {
            try
            {
                Ferramentas RegFer = new Ferramentas();
                dsFerramenta.Tables.Add(RegFer.Listar());
                bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                dgvFerramenta.DataSource = bnFerramenta;
                bnvFerramenta.BindingSource = bnFerramenta;

                txtId.DataBindings.Add("TEXT", bnFerramenta, "id");
                txtNome.DataBindings.Add("TEXT", bnFerramenta, "nome");
                cbxDistribuicao.DataBindings.Add("SelectedItem", bnFerramenta, "distribuicao");
                dtpCadastro.DataBindings.Add("TEXT", bnFerramenta, "dtcadastro");
                txtSiteOfc.DataBindings.Add("TEXT", bnFerramenta, "siteoficial");
                
                Categoria RegCat = new Categoria();
                dsCategoria.Tables.Add(RegCat.Listar());
                cbxCategoria.DataSource = dsCategoria.Tables["Categoria"];
                cbxCategoria.DisplayMember = "descricao";
                cbxCategoria.ValueMember = "id";
                cbxCategoria.DataBindings.Add("SelectedValue", bnFerramenta, "idCategoria");
                
                Fabricante RegFab = new Fabricante();
                dsFabricante.Tables.Add(RegFab.Listar());
                cbxFabricante.DataSource = dsFabricante.Tables["Fabricante"];
                cbxFabricante.DisplayMember = "nomefantasia";
                cbxFabricante.ValueMember = "id";
                cbxFabricante.DataBindings.Add("SelectedValue", bnFerramenta, "idFabricante");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectedIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }

            bnFerramenta.AddNew();

            txtNome.Enabled = true;
            txtNome.Focus();
            txtSiteOfc.Enabled = true;
            cbxDistribuicao.Enabled = true;
            dtpCadastro.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxFabricante.Enabled = true;

            cbxCategoria.SelectedIndex = 0;
            cbxFabricante.SelectedIndex = 0;
            cbxDistribuicao.SelectedIndex = 0;


            btnNovoRegistro.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInlcusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || (txtNome.Text.Replace(" ", "").Length < 1))
            {
                MessageBox.Show("Nome inválido");
            }
            else if(cbxDistribuicao.SelectedIndex == -1)
            {
                MessageBox.Show("Distribuição inválida");
            }
            else if(txtSiteOfc.Text == ""|| txtSiteOfc.Text.Replace(" " , "").Length < 8)
            {
                MessageBox.Show("Site oficial inválido!");
            }
            else if (Convert.ToDateTime(dtpCadastro.Value)<DateTime.Today)
            {
                MessageBox.Show("Data inválida");
            }
            else if (cbxFabricante.SelectedIndex ==-1)
            {
                MessageBox.Show("Fabricante inválido");
            }
            else
            {
                Ferramentas RegFer = new Ferramentas();
                RegFer.IdFerramenta = Convert.ToInt16(txtId.Text);
                RegFer.Nome = txtNome.Text;
                RegFer.Distribuicao = Convert.ToChar(cbxDistribuicao.SelectedItem);
                RegFer.DtCadastro= dtpCadastro.Value;
                RegFer.SiteOficial = txtSiteOfc.Text;
                RegFer.IdCategoria= Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
                RegFer.IdFabricante= Convert.ToInt32(cbxFabricante.SelectedValue.ToString());

                if (bInlcusao)
                {
                    if (RegFer.Salvar() > 0)
                    {
                        MessageBox.Show("Ferramenta adicionada com sucesso!");

                        txtNome.Enabled = false;
                        txtSiteOfc.Enabled = false;
                        cbxDistribuicao.Enabled = false;
                        dtpCadastro.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxFabricante.Enabled = false;

                        btnNovoRegistro.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        bInlcusao = false;


                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Add(RegFer.Listar());
                        bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Ferramenta!");
                    }
                }
                else
                {
                    RegFer.IdFerramenta = Convert.ToInt32(txtId.Text);
                    if (RegFer.Alterar() > 0)
                    {
                        MessageBox.Show("Ferramenta alterada com sucesso!");
                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        txtSiteOfc.Enabled = false;
                        cbxDistribuicao.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxFabricante.Enabled =false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInlcusao = false;

                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Add(RegFer.Listar());
                        bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                    }
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectedIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Ferramentas RegFer = new Ferramentas();
                RegFer.IdFerramenta = Convert.ToInt16(txtId.Text);

                if (RegFer.Excluir() > 0)
                {
                    MessageBox.Show("Ferramenta Excluída com sucesso!");

                    Ferramentas R = new Ferramentas();
                    dsFerramenta.Tables.Clear();
                    dsFerramenta.Tables.Add(R.Listar());
                    bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];

                }
                else
                {
                    MessageBox.Show("Erro ao excluir Ferramenta!");
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFerramenta.CancelEdit();

            txtNome.Enabled = false;
            txtSiteOfc.Enabled = false;
            cbxDistribuicao.Enabled = false;
            dtpCadastro.Enabled = false;
            cbxCategoria.Enabled = false;
            cbxFabricante.Enabled = false;

            btnNovoRegistro.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            bInlcusao = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFerramenta.SelectedIndex == 0)
            {
                tbFerramenta.SelectTab(1);
            }

            txtNome.Enabled = true;
            txtSiteOfc.Enabled = true;
            cbxDistribuicao.Enabled = true;
            dtpCadastro.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxFabricante.Enabled = true;

            cbxDistribuicao.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 0;
            cbxFabricante.SelectedIndex = 0;

            btnNovoRegistro.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            
            bInlcusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
