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
    public partial class Clientes : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public Clientes()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBclientes
                        orderby e.Id descending
                        select new { e.Id, e.Cnpj, e.Razao, e.Inscricao, e.NomeFantasia, e.Obs, e.ContatoNome, e.ContatoEmail, e.ContatoTelefone, e.endereco, e.freq_compra };
            bi.DataSource = query.ToList();
            dataClientes.DataSource = bi;
            dataClientes.Refresh();
        }

        private void ClearBoxes()
        {
            txtClienteCnpj.Text = null;
            txtClienteContatoEmail.Text = null;
            txtClienteContatoNome.Text = null;
            txtClienteContatoTelefone.Text = null;
            txtClienteEndereco.Text = null;
            txtClienteInscricao.Text = null;
            txtClienteNomeFantasia.Text = null;
            txtClienteObs.Text = null;
            txtClienteRazao.Text = null;
        }

        private void btnClienteAdicionar_Click(object sender, EventArgs e)
        {
            if (txtClienteCnpj.Text != string.Empty || txtClienteInscricao.Text != string.Empty || txtClienteNomeFantasia.Text != string.Empty || txtClienteRazao.Text != string.Empty)
            {
                var cliente = new DadosCliente()
                {
                    Cnpj = txtClienteCnpj.Text,
                    ContatoEmail = txtClienteContatoEmail.Text,
                    ContatoNome = txtClienteContatoNome.Text,
                    ContatoTelefone = txtClienteContatoTelefone.Text,
                    endereco = txtClienteEndereco.Text,
                    Inscricao = txtClienteInscricao.Text,
                    NomeFantasia = txtClienteNomeFantasia.Text,
                    Obs = txtClienteObs.Text,
                    Razao = txtClienteRazao.Text,
                };
                context.DBclientes.Add(cliente);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("preencha pelo menos um dos campos");
            }
            RefreshGrid();
            ClearBoxes();
        }

        private void btnClienteEditar_Click(object sender, EventArgs e)
        {
            if (btnClienteEditar.Text == "Editar")
            {
                txtClienteCnpj.Text = dataClientes.SelectedCells[1].Value.ToString();
                txtClienteContatoEmail.Text = dataClientes.SelectedCells[7].Value.ToString();
                txtClienteContatoNome.Text = dataClientes.SelectedCells[6].Value.ToString();
                txtClienteContatoTelefone.Text = dataClientes.SelectedCells[8].Value.ToString();
                txtClienteEndereco.Text = dataClientes.SelectedCells[9].Value.ToString();
                txtClienteInscricao.Text = dataClientes.SelectedCells[3].Value.ToString();
                txtClienteNomeFantasia.Text = dataClientes.SelectedCells[4].Value.ToString();
                txtClienteObs.Text = dataClientes.SelectedCells[5].Value.ToString();
                txtClienteRazao.Text = dataClientes.SelectedCells[2].Value.ToString();
                btnClienteEditar.Text = "Salvar";
            }
            else if (btnClienteEditar.Text == "Salvar")
            {
                var editarClientes = context.DBclientes.Find((int)dataClientes.SelectedCells[0].Value);

                editarClientes.Cnpj = txtClienteCnpj.Text;
                editarClientes.ContatoEmail = txtClienteContatoEmail.Text;
                editarClientes.ContatoNome = txtClienteContatoNome.Text;
                editarClientes.ContatoTelefone = txtClienteContatoTelefone.Text;
                editarClientes.endereco = txtClienteEndereco.Text;
                editarClientes.Inscricao = txtClienteInscricao.Text;
                editarClientes.NomeFantasia = txtClienteNomeFantasia.Text;
                editarClientes.Obs = txtClienteObs.Text;
                editarClientes.Razao = txtClienteRazao.Text;

                context.SaveChanges();
                RefreshGrid();

                btnClienteEditar.Text = "Editar";
                ClearBoxes();


            }
        }

        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnClienteExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBclientes.Find((int)dataClientes.SelectedCells[0].Value);
            context.DBclientes.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }
    }
}
