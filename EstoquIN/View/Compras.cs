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
            var fornecs = context.DBfornec.ToList();
            foreach (DadosFornec dado in fornecs)
            {
                cbCompraFornecedor.Items.Add(dado.NomeFantasia);
            }
            var insums = context.DBinsumos.ToList();
            foreach (DadosInsumos insu in insums)
            {
                cbCompraProdutoFornecido.Items.Add(insu.Nome);
            }
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBcompras
                        from f in context.DBfornec
                        from g in context.DBinsumos
                        orderby e.Id descending
                        where f.Id == e.DadosFornecId & g.Id == e.DadosInsumosId
                        select new { e.Id, e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.NotaFiscal, f.NomeFantasia, g.Nome};
            bi.DataSource = query.ToList();
            dataCompra.DataSource = bi;
            dataCompra.Refresh();
        }
        private void ClearBoxes()
        {
            cbCompraFornecedor.Text = null;
            cbCompraProdutoFornecido.Text = null;
            txtCompraFormaPagamento.Text = null;
            dateCompraData.Text = null;
            txtCompraQuantidade.Text = null;
            txtCompraValorTotal.Text = null;
            txtCompraValorUnit.Text = null;
            checkCompraStatus.Checked = false;
            picNotaFiscal.Image = null;
            
        }

        private void btnCompraAdicionar_Click(object sender, EventArgs e)
        {
            if (cbCompraFornecedor.Text != string.Empty & cbCompraProdutoFornecido.Text != string.Empty || txtCompraQuantidade.Text != string.Empty)
            {
                var compra = new DadosCompras()
                {
                    fornec = (cbCompraFornecedor.SelectedItem as DadosFornec),
                    insumos = (cbCompraProdutoFornecido.SelectedItem as DadosInsumos),
                    FormPag = txtCompraFormaPagamento.Text,
                    Data = dateCompraData.Value,
                    Quant = txtCompraQuantidade.Text,
                    ValorTotal = txtCompraValorTotal.Text,
                    ValorUnit = txtCompraValorUnit.Text,
                    Status = checkCompraStatus.Checked,
                    NotaFiscal = picNotaFiscal.ImageLocation,
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
                txtCompraFormaPagamento.Text = dataCompra.SelectedCells[2].Value.ToString();
                txtCompraQuantidade.Text = dataCompra.SelectedCells[3].Value.ToString();
                txtCompraValorTotal.Text = dataCompra.SelectedCells[4].Value.ToString();
                txtCompraValorUnit.Text = dataCompra.SelectedCells[5].Value.ToString();
                checkCompraStatus.Text = dataCompra.SelectedCells[6].Value.ToString();
                picNotaFiscal.ImageLocation = dataCompra.SelectedCells[7].Value.ToString();
                cbCompraFornecedor.Text = dataCompra.SelectedCells[8].Value.ToString();
                cbCompraProdutoFornecido.Text =  dataCompra.SelectedCells[9].Value.ToString();
              
                btnCompraEditar.Text = "Salvar";
            }
            else if (btnCompraEditar.Text == "Salvar")
            {
                var editarCompras = context.DBcompras.Find((int)dataCompra.SelectedCells[0].Value);

                editarCompras.fornec = (cbCompraFornecedor.SelectedItem as DadosFornec);
                editarCompras.insumos = (cbCompraProdutoFornecido.SelectedItem as DadosInsumos);
                editarCompras.Data = dateCompraData.Value;
                editarCompras.FormPag = txtCompraFormaPagamento.Text;
                editarCompras.Quant = txtCompraQuantidade.Text;
                editarCompras.ValorTotal = txtCompraValorTotal.Text;
                editarCompras.ValorUnit = txtCompraValorUnit.Text;
                editarCompras.Status = checkCompraStatus.Checked;
                editarCompras.NotaFiscal = picNotaFiscal.ImageLocation;

                context.SaveChanges();
                RefreshGrid();

                btnCompraEditar.Text = "Editar";
                ClearBoxes();

            }
        }

        private void btnCompraExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBcompras.Find((int)dataCompra.SelectedCells[0].Value);
            context.DBcompras.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }

        private void btnCompraCancelar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        private void btnCompraUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picNotaFiscal.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
