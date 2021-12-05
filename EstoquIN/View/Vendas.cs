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
    public partial class Vendas : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public Vendas()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }
        public void RefreshCombo()
        {
            cbVendaCliente.Items.Clear();
            var clientes = context.DBclientes.ToList();
            foreach (DadosCliente client in clientes)
            {
                cbVendaCliente.Items.Add(client.NomeFantasia);
            }
            cbVendaProdutoCliente.Items.Clear();
            var produtos = context.DBprodutos.ToList();
            foreach (DadosProdutos prod in produtos)
            {
                cbVendaProdutoCliente.Items.Add(prod.Nome);
            }
        }
        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBvendas
                        from f in context.DBclientes
                        from g in context.DBprodutos
                        orderby e.Id descending
                        where f.Id == e.DadosClienteId & g.Id == e.DadosProdutosId
                        select new { e.Id, e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.NotaFiscal, e.cliente, e.produto, f.NomeFantasia, g.Nome };
            bi.DataSource = query.ToList();
            dataVenda.DataSource = bi;
            dataVenda.Refresh();
            RefreshCombo();
        }
        private void ClearBoxes()
        {
            cbVendaCliente.ResetText();
            cbVendaProdutoCliente.ResetText();
            txtVendaFormaPagamento.Text = null;
            dateVendaData.Text = null;
            txtVendaQuantidade.Text = null;
            txtVendaValorTotal.Text = null;
            txtVendaValorUnit.Text = null;
            checkVendaStatus.Checked = false;
            picVendaNotaFiscal.Image = null;

        }

        private void btnVendaAdicionar_Click(object sender, EventArgs e)
        {
            if (cbVendaCliente.SelectedItem != null & cbVendaProdutoCliente.SelectedItem != null || txtVendaQuantidade.Text != string.Empty)
            {
                var venda = new DadosVendas()
                {
                    DadosClienteId = ((DadosCliente)cbVendaCliente.SelectedItem).Id,
                    DadosProdutosId = ((DadosProdutos)cbVendaProdutoCliente.SelectedItem).Id,
                    FormPag = txtVendaFormaPagamento.Text,
                    Data = dateVendaData.Value,
                    Quant = txtVendaQuantidade.Text,
                    ValorTotal = txtVendaValorTotal.Text,
                    ValorUnit = txtVendaValorUnit.Text,
                    Status = checkVendaStatus.Checked,
                    NotaFiscal = picVendaNotaFiscal.ImageLocation,
                };
                context.DBvendas.Add(venda);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("preencha todos os campos");
            }
            RefreshGrid();
            ClearBoxes();
        }

        private void btnVendaEditar_Click(object sender, EventArgs e)
        {
            if (btnVendaEditar.Text == "Editar")
            {

                dateVendaData.Text = dataVenda.SelectedCells[1].Value.ToString();
                txtVendaFormaPagamento.Text = dataVenda.SelectedCells[2].Value.ToString();
                txtVendaQuantidade.Text = dataVenda.SelectedCells[3].Value.ToString();
                txtVendaValorTotal.Text = dataVenda.SelectedCells[4].Value.ToString();
                txtVendaValorUnit.Text = dataVenda.SelectedCells[5].Value.ToString();
                checkVendaStatus.Text = dataVenda.SelectedCells[6].Value.ToString();
                picVendaNotaFiscal.ImageLocation = dataVenda.SelectedCells[7].Value.ToString();
                cbVendaCliente.Text = dataVenda.SelectedCells[8].Value.ToString();
                cbVendaProdutoCliente.Text = dataVenda.SelectedCells[9].Value.ToString();

                btnVendaEditar.Text = "Salvar";
            }
            else if (btnVendaEditar.Text == "Salvar")
            {
                var editarVendas = context.DBvendas.Find((int)dataVenda.SelectedCells[0].Value);

                editarVendas.DadosClienteId = (cbVendaCliente.SelectedItem as DadosVendas).Id;
                editarVendas.DadosProdutosId = (cbVendaProdutoCliente.SelectedItem as DadosProdutos).Id;
                editarVendas.Data = dateVendaData.Value;
                editarVendas.FormPag = txtVendaFormaPagamento.Text;
                editarVendas.Quant = txtVendaQuantidade.Text;
                editarVendas.ValorTotal = txtVendaValorTotal.Text;
                editarVendas.ValorUnit = txtVendaValorUnit.Text;
                editarVendas.Status = checkVendaStatus.Checked;
                editarVendas.NotaFiscal = picVendaNotaFiscal.ImageLocation;

                context.SaveChanges();
                RefreshGrid();

                btnVendaEditar.Text = "Editar";
                ClearBoxes();

            }
        }

        private void btnVendaCancelar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnVendaExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBvendas.Find((int)dataVenda.SelectedCells[0].Value);
            context.DBvendas.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }

        private void btnVendaUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picVendaNotaFiscal.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
