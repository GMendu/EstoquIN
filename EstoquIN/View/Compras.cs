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
    public partial class Compras : Form
    {
        private EstoqDBContext context;
        public Compras()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBcompras
                        orderby e.Id descending
                        select new { e.Id, e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.NotaFiscal};
            bi.DataSource = query.ToList();
            dataCompra.DataSource = bi;
            dataCompra.Refresh();
        }
        private void ClearBoxes()
        {
            cbCompraFornecedor.Text = null;
            cbCompraProdutoFornecido.Text = null;
            cbCompraFormaPagamento.Text = null;
            dateCompraData.Text = null;
            txtCompraQuantidade.Text = null;
            txtCompraValorTotal.Text = null;
            txtCompraValorUnit.Text = null;
        }

        private void btnCompraAdicionar_Click(object sender, EventArgs e)
        {
            if (cbCompraFornecedor.Text != string.Empty & cbCompraProdutoFornecido.Text != string.Empty || txtCompraQuantidade.Text != string.Empty)
            {
                var compra = new DadosCompras()
                {
                    //fornec = cbCompraFornecedor.Text,
                    //insumos = cbCompraProdutoFornecido.Text,
                    FormPag = cbCompraFormaPagamento.Text,
                    //Data = dateCompraData.text,
                    Quant = txtCompraQuantidade.Text,
                    ValorTotal = txtCompraValorTotal.Text,
                    ValorUnit = txtCompraValorUnit.Text,
                };
                context.DBcompras.Add(compra);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("preencha todos os campos");
            }
            RefreshGrid();
            ClearBoxes();
        }

        private void btnCompraEditar_Click(object sender, EventArgs e)
        {
            if (btnCompraEditar.Text == "Editar")
            {
                dateCompraData.Text = dataCompra.SelectedCells[1].Value.ToString();
                cbCompraFormaPagamento.Text = dataCompra.SelectedCells[7].Value.ToString();
                txtCompraQuantidade.Text = dataCompra.SelectedCells[6].Value.ToString();
                txtCompraValorTotal.Text = dataCompra.SelectedCells[8].Value.ToString();
                txtCompraValorUnit.Text = dataCompra.SelectedCells[9].Value.ToString();
                checkCompraStatus.Text = dataCompra.SelectedCells[3].Value.ToString();
              
                btnCompraEditar.Text = "Salvar";
            }
            else if (btnCompraEditar.Text == "Salvar")
            {
                var editarCompras = context.DBcompras.Find((int)dataCompra.SelectedCells[0].Value);

                //editarCompras.fornec = cbCompraFornecedor.Text;
                //editarCompras.insumos = cbCompraProdutoFornecido
               // editarCompras.Data = dateCompraData.Text;
                editarCompras.FormPag = cbCompraFormaPagamento.Text;
                editarCompras.Quant = txtCompraQuantidade.Text;
                editarCompras.ValorTotal = txtCompraValorTotal.Text;
                editarCompras.ValorUnit = txtCompraValorUnit.Text;
                //editarCompras.Status = txtFornecInscricao.Text;
                //editarCompras.NotaFiscal = txtFornecNomeFantasia.Text;

                context.SaveChanges();
                RefreshGrid();

                btnCompraEditar.Text = "Editar";
                ClearBoxes();


            }
        }

        private void btnCompraExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCompraCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
