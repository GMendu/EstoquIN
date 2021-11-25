using EstoquIN.ConfigDB;
using EstoquIN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace EstoquIN.View
{
    public partial class Fornecedores : Form
    {
        private EstoqDBContext context;
        public Fornecedores()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBfornec
                        orderby e.Id descending
                        select new { e.Id, e.Cnpj, e.Razao, e.Inscricao, e.NomeFantasia, e.Observ, e.ContatoNome, e.ContatoEmail, e.ContatoTelefone, e.Endereco};
            bi.DataSource = query.ToList();
            dataFornec.DataSource = bi;
            dataFornec.Refresh();

            BindingSource bs = new BindingSource();
            var queri = from c in context.DBinsumos
                        orderby c.Id descending
                        select new { c.Id, c.Nome };
            bs.DataSource = queri.ToList();
            dataFornecMaterial.DataSource = bs;
            dataFornecMaterial.Refresh();
        }

        private void ClearBoxes()
        {
            txtFornecCnpj.Text = null;
            txtFornecContatoEmail.Text = null;
            txtFornecContatoNome.Text = null;
            txtFornecContatoTelefone.Text = null;
            txtFornecEndereco.Text = null;
            txtFornecInscricao.Text = null;
            txtFornecNomeFantasia.Text = null;
            txtFornecObs.Text = null;
            txtFornecRazao.Text = null;
        }

        private void btnFornecAdicionar_Click(object sender, EventArgs e)
        {
            if (txtFornecCnpj.Text != string.Empty || txtFornecInscricao.Text != string.Empty || txtFornecNomeFantasia.Text != string.Empty || txtFornecRazao.Text != string.Empty)
            {
                var fornecedor = new DadosFornec()
                {
                    Cnpj = txtFornecCnpj.Text,
                    ContatoEmail = txtFornecContatoEmail.Text,
                    ContatoNome = txtFornecContatoNome.Text,
                    ContatoTelefone = txtFornecContatoTelefone.Text,
                    Endereco = txtFornecEndereco.Text,
                    Inscricao = txtFornecInscricao.Text,
                    NomeFantasia = txtFornecNomeFantasia.Text,
                    Observ = txtFornecObs.Text,
                    Razao = txtFornecRazao.Text,
                };
                context.DBfornec.Add(fornecedor);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("preencha pelo menos um dos campos");
            }
            RefreshGrid();
            ClearBoxes();
        }

        private void btnFornecEditar_Click(object sender, EventArgs e)
        {
            if (btnFornecEditar.Text == "Editar")
            {
                txtFornecCnpj.Text = dataFornec.SelectedCells[1].Value.ToString();
                txtFornecContatoEmail.Text = dataFornec.SelectedCells[7].Value.ToString();
                txtFornecContatoNome.Text = dataFornec.SelectedCells[6].Value.ToString();
                txtFornecContatoTelefone.Text = dataFornec.SelectedCells[8].Value.ToString();
                txtFornecEndereco.Text = dataFornec.SelectedCells[9].Value.ToString();
                txtFornecInscricao.Text = dataFornec.SelectedCells[3].Value.ToString();
                txtFornecNomeFantasia.Text = dataFornec.SelectedCells[4].Value.ToString();
                txtFornecObs.Text = dataFornec.SelectedCells[5].Value.ToString();
                txtFornecRazao.Text = dataFornec.SelectedCells[2].Value.ToString();
                btnFornecEditar.Text = "Salvar";
            }
            else if (btnFornecEditar.Text == "Salvar")
            {
                var editarClientes = context.DBclientes.Find((int)dataFornec.SelectedCells[0].Value);

                editarClientes.Cnpj = txtFornecCnpj.Text;
                editarClientes.ContatoEmail = txtFornecContatoEmail.Text;
                editarClientes.ContatoNome = txtFornecContatoNome.Text;
                editarClientes.ContatoTelefone = txtFornecContatoTelefone.Text;
                editarClientes.endereco = txtFornecEndereco.Text;
                editarClientes.Inscricao = txtFornecInscricao.Text;
                editarClientes.NomeFantasia = txtFornecNomeFantasia.Text;
                editarClientes.Obs = txtFornecObs.Text;
                editarClientes.Razao = txtFornecRazao.Text;

                context.SaveChanges();
                RefreshGrid();

                btnFornecEditar.Text = "Editar";
                ClearBoxes();


            }
        }

        private void btnFornecCancelar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnFornecExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBfornec.Find((int)dataFornec.SelectedCells[0].Value);
            context.DBfornec.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }
    }
}
