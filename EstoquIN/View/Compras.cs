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
using System.IO;

namespace EstoquIN.View
{
    public partial class Compras : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        
        public Compras()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }
        public void RefreshCombo()
        {
            cbCompraFornecedor.Items.Clear();
            var fornecs = context.DBfornec.ToList();
            foreach (DadosFornec dado in fornecs)
            {
                cbCompraFornecedor.Items.Add(dado);
            }
            cbCompraProdutoFornecido.Items.Clear();
            var insums = context.DBinsumos.ToList();
            foreach (DadosInsumos insu in insums)
            {
                cbCompraProdutoFornecido.Items.Add(insu);
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
                        select new { e.Id, e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.NotaFiscal, e.Insumos, e.Fornec, f.NomeFantasia, g.Nome};
            bi.DataSource = query.ToList();
            dataCompra.DataSource = bi;
            dataCompra.Refresh();
            RefreshCombo();
        }
        private void ClearBoxes()
        {
            cbCompraFornecedor.ResetText();
            cbCompraProdutoFornecido.ResetText();
            txtCompraFormaPagamento.Text = null;
            dateCompraData.Text = null;
            txtCompraQuantidade.Text = null;
            txtCompraValorTotal.Text = null;
            txtCompraValorUnit.Text = null;
            checkCompraStatus.Checked = false;
            picNotaFiscal.Image = null;
            
        }

        private string SalvarImg(int y)
        {
            var x = 0;
            if (picNotaFiscal.Image != null)
            {
                if (y == -1)
                {
                    var imgs = context.DBcompras.ToList();
                    foreach (DadosCompras img in imgs)
                    {
                        x = img.Id;
                    }
                }
                else
                {
                    x = y;
                }
                string fotoNome = "img_" + x + ".jpg";
                string folder = @"C:\Users\Aluno\source\repos\abbbbbb\EstoquIN\Images";
                string pathstring = Path.Combine(folder, fotoNome);
                Image a = picNotaFiscal.Image;
                a.Save(pathstring);
                return pathstring;
            }
            else
            {
                return null;
            }
        }

        private void btnCompraAdicionar_Click(object sender, EventArgs e)
        {

            if (cbCompraFornecedor.SelectedItem != null & cbCompraProdutoFornecido.SelectedItem != null || txtCompraQuantidade.Text != string.Empty)
            {
                var compra = new DadosCompras()
                {
                    DadosFornecId = ((DadosFornec)cbCompraFornecedor.SelectedItem).Id,
                    DadosInsumosId = ((DadosInsumos)cbCompraProdutoFornecido.SelectedItem).Id,
                    FormPag = txtCompraFormaPagamento.Text,
                    Data = dateCompraData.Value,
                    Quant = txtCompraQuantidade.Text,
                    ValorTotal = txtCompraValorTotal.Text,
                    ValorUnit = txtCompraValorUnit.Text,
                    Status = checkCompraStatus.Checked,
                    NotaFiscal = SalvarImg(-1),
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
                checkCompraStatus.Checked = bool.Parse(dataCompra.SelectedCells[6].Value.ToString());
                if(dataCompra.SelectedCells[7].Value != null)
                    picNotaFiscal.ImageLocation = dataCompra.SelectedCells[7].Value.ToString();
                cbCompraFornecedor.Text = dataCompra.SelectedCells[9].Value.ToString();
                cbCompraProdutoFornecido.Text =  dataCompra.SelectedCells[8].Value.ToString();
              
                btnCompraEditar.Text = "Salvar";
            }
            else if (btnCompraEditar.Text == "Salvar")
            {
                var editarCompras = context.DBcompras.Find((int)dataCompra.SelectedCells[0].Value);

                editarCompras.DadosFornecId = ((DadosFornec)cbCompraFornecedor.SelectedItem).Id;
                editarCompras.DadosInsumosId = ((DadosInsumos)cbCompraProdutoFornecido.SelectedItem).Id;
                editarCompras.Data = dateCompraData.Value;
                editarCompras.FormPag = txtCompraFormaPagamento.Text;
                editarCompras.Quant = txtCompraQuantidade.Text;
                editarCompras.ValorTotal = txtCompraValorTotal.Text;
                editarCompras.ValorUnit = txtCompraValorUnit.Text;
                editarCompras.Status = checkCompraStatus.Checked;
                editarCompras.NotaFiscal = SalvarImg((int)dataCompra.SelectedCells[0].Value);

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
            btnCompraEditar.Text = "Editar";
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
