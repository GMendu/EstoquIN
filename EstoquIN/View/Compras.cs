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
                        from h in context.DBImage
                        orderby e.Id descending
                        where f.Id == e.DadosFornecId & g.Id == e.DadosInsumosId & h.Id == e.DadosImagesId
                        select new { e.Id, e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.Images, e.Insumos, e.Fornec};
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
            btnCompraAdicionar.Text = "Adicionar";
            btnCompraEditar.Text = "Editar";
        }

        private int SalvarImg()
        {
            if (picNotaFiscal.Image != null)
            {
                Random r = new Random();
                string pathstring = "C:";
                do
                {
                    int idrand = r.Next(2147483646);
                    string fotoNome = "img_" + idrand + ".jpg";
                    string folder = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\";
                    pathstring = Path.Combine(folder, fotoNome);
                }while (File.Exists(pathstring));
                Image a = picNotaFiscal.Image;
                a.Save(pathstring);
                var newImg = new DadosImages
                {
                    Path = pathstring,
                    Categoria = "compras"
                };
                context.DBImage.Add(newImg);
                context.SaveChanges();
                RefreshGrid();
                return newImg.Id;

            }
            else
            {
                int noimg = 0;
                if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\img_0.jpg"))
                {
                    bool verif = true;
                    var imgs = context.DBImage.ToList();
                    foreach (DadosImages img in imgs)
                    {
                        if (img.Path == @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\img_0.jpg")
                        {
                            noimg = img.Id;
                            verif = false;
                        }
                    }
                    if (verif)
                    {
                        var newImg = new DadosImages
                        {
                            Path = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\img_0.jpg",//modifcar na instalação para a pasta do computador desejada
                            Categoria = "placeholder"
                        };
                        context.DBImage.Add(newImg);
                        noimg = newImg.Id;
                    }
                }
                return noimg;
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
                    DadosImagesId = SalvarImg(),
                };
                context.DBcompras.Add(compra);
                context.SaveChanges();
                RefreshGrid();
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("preencha todos os campos");
            }
            
        }

        private void btnCompraEditar_Click(object sender, EventArgs e)
        {
            if (btnCompraEditar.Text == "Editar")
            {
                //e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.Images, e.Insumos, e.Fornec
                dateCompraData.Text = dataCompra.SelectedCells[1].Value.ToString();
                txtCompraFormaPagamento.Text = dataCompra.SelectedCells[2].Value.ToString();
                txtCompraQuantidade.Text = dataCompra.SelectedCells[3].Value.ToString();
                txtCompraValorTotal.Text = dataCompra.SelectedCells[4].Value.ToString();
                txtCompraValorUnit.Text = dataCompra.SelectedCells[5].Value.ToString();
                checkCompraStatus.Checked = bool.Parse(dataCompra.SelectedCells[6].Value.ToString());
                if (dataCompra.SelectedCells[7].Value != null)
                    picNotaFiscal.ImageLocation = dataCompra.SelectedCells[7].Value.ToString();
                cbCompraProdutoFornecido.Text = dataCompra.SelectedCells[8].Value.ToString();
                cbCompraFornecedor.Text = dataCompra.SelectedCells[9].Value.ToString();
                btnCompraAdicionar.Text = "Duplicar";
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
                editarCompras.DadosImagesId = SalvarImg();

                context.SaveChanges();
                RefreshGrid();
                ClearBoxes();

            }
        }
        // adicionar btnClienteAdicionar.Text = "Adicionar"; ao botão cancelar, adicionar e salvar
        // adicionar btnConfigEditar.Text = "Editar"; ao botão adicionar
        // adicionar btnClienteAdicionar.Text = "Duplicar"; ao botão editar
        private void btnCompraExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR?, ESTA AÇÃO É IRREVERSÍVEL", "EXCLUIR", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                var t = context.DBcompras.Find((int)dataCompra.SelectedCells[0].Value);
                context.DBcompras.Remove(t);
                context.SaveChanges();
                RefreshGrid();
                ClearBoxes();
            }
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
