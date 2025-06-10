using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFerramenta0030482421016
{
    public partial class frmFabricante : Form
    {
        private BindingSource bnFabricante = new BindingSource();
        private bool bInlcusao = false;
        private DataSet dsFabricante = new DataSet();

        public frmFabricante()
        {
            InitializeComponent();
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            try
            {
                Fabricante RegFab = new Fabricante();
                dsFabricante.Tables.Add(RegFab.Listar());
                bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                dgvFabricante.DataSource = bnFabricante;
                bnvFabricante.BindingSource = bnFabricante;

                txtId.DataBindings.Add("TEXT", bnFabricante, "id");
                txtNome.DataBindings.Add("TEXT", bnFabricante, "nomefantasia");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            bnFabricante.AddNew();
            txtNome.Enabled = true;
            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInlcusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || (txtNome.Text.Replace(" ", "").Length < 2))
            {
                MessageBox.Show("Fabricante inválida");
            }
            else
            {
                Fabricante RegFab = new Fabricante();

                RegFab.IdFabricante = Convert.ToInt16(txtId.Text);
                RegFab.NomeFantasia = txtNome.Text;
                if (bInlcusao)
                {
                    if (RegFab.Salvar() > 0)
                    {
                        MessageBox.Show("Fabricante adicionada com sucesso!");

                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInlcusao = false;

                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Add(RegFab.Listar());
                        bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Fabricante!");
                    }
                }
                else
                {
                    if (RegFab.Alterar() > 0)
                    {
                        MessageBox.Show("Fabricante adicionada com sucesso!");
                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInlcusao = false;

                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Clear();
                        dsFabricante.Tables.Add(RegFab.Listar());
                        bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];
                    }
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Fabricante RegCat = new Fabricante();
                RegCat.IdFabricante = Convert.ToInt16(txtId.Text);

                if (RegCat.Excluir() > 0)
                {
                    MessageBox.Show("Fabricante Excluída com sucesso!");

                    Fabricante R = new Fabricante();
                    dsFabricante.Tables.Clear();
                    dsFabricante.Tables.Add(R.Listar());
                    bnFabricante.DataSource = dsFabricante.Tables["FABRICANTE"];

                }
                else
                {
                    MessageBox.Show("Erro ao excluir Fabricante!");
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFabricante.CancelEdit();

            txtId.Enabled = false;
            txtNome.Enabled = false;
            bnFabricante.CancelEdit();
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInlcusao = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFabricante.SelectedIndex == 0)
            {
                tbFabricante.SelectTab(1);
            }

            txtNome.Enabled = true;
            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInlcusao = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

