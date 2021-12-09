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
    public partial class Vendas : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public Vendas(int hierarquia)
        {
            InitializeComponent();
            if (hierarquia == 2)
            {
                btnVendaExcluir.Enabled = false;
                btnVendaExcluir.BackColor = Color.FromArgb(52, 52, 52);
            }
            
            context = new EstoqDBContext();
            RefreshGrid();
        }
        public void RefreshCombo()
        {
            cbVendaCliente.Items.Clear();
            var clientes = context.DBclientes.ToList();
            foreach (DadosCliente client in clientes)
            {
                cbVendaCliente.Items.Add(client);
            }
            cbVendaProdutoCliente.Items.Clear();
            var produtos = context.DBprodutos.ToList();
            foreach (DadosProdutos prod in produtos)
            {
                cbVendaProdutoCliente.Items.Add(prod);
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
                        select new { e.Id, e.Data, e.FormPag, e.Quant, e.ValorTotal, e.ValorUnit, e.Status, e.Images, e.cliente, e.produto};
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
            btnVendaAdicionar.Text = "Adicionar";
            btnVendaEditar.Text = "Editar";

        }
        private int SalvarImg()
        {
            if (picVendaNotaFiscal.Image != null)
            {
                Random r = new Random();
                string pathstring = "C:";
                do
                {
                    int idrand = r.Next(2147483646);
                    string fotoNome = "img_" + idrand + ".jpg";
                    string folder = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\";
                    pathstring = Path.Combine(folder, fotoNome);
                } while (File.Exists(pathstring));
                Image a = picVendaNotaFiscal.Image;
                a.Save(pathstring);
                var newImg = new DadosImages
                {
                    Path = pathstring,
                    Categoria = "vendas"
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
                        if(img.Path == @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\img_0.jpg")
                        {
                            noimg = img.Id;
                            verif = false;
                        }
                    }
                    if (verif)
                    {
                        var newImg = new DadosImages
                        {
                            Path = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\img_0.jpg",
                            Categoria = "placeholder"
                        };
                        context.DBImage.Add(newImg);
                        noimg = newImg.Id;
                    }
                }
                return noimg;
            }
            
        }
        private void btnVendaAdicionar_Click(object sender, EventArgs e)
        {
            if (cbVendaCliente.SelectedItem != null & cbVendaProdutoCliente.SelectedItem != null && txtVendaQuantidade.Text != string.Empty)
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
                    DadosImagesId = SalvarImg(),
                };
                context.DBvendas.Add(venda);
                context.SaveChanges();
                RefreshGrid();
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("preencha todos os campos");
            }
            
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
                if (dataVenda.SelectedCells[7].Value != null)
                    picVendaNotaFiscal.ImageLocation = dataVenda.SelectedCells[7].Value.ToString();
                cbVendaCliente.Text = dataVenda.SelectedCells[8].Value.ToString();
                cbVendaProdutoCliente.Text = dataVenda.SelectedCells[9].Value.ToString();
                btnVendaAdicionar.Text = "Duplicar";
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
                editarVendas.DadosImagesId = SalvarImg();
                context.SaveChanges();
                RefreshGrid();
                ClearBoxes();

            }
        }
        // adicionar btnClienteAdicionar.Text = "Adicionar"; ao botão cancelar, adicionar e salvar
        // adicionar btnConfigEditar.Text = "Editar"; ao botão adicionar
        // adicionar btnClienteAdicionar.Text = "Duplicar"; ao botão editar
        private void btnVendaCancelar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnVendaExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR?, ESTA AÇÃO É IRREVERSÍVEL", "EXCLUIR", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                var t = context.DBvendas.Find((int)dataVenda.SelectedCells[0].Value);
                context.DBvendas.Remove(t);
                context.SaveChanges();
                RefreshGrid();
                ClearBoxes();
            }
            
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

        private void btnCalcQuant_Click(object sender, EventArgs e)
        {
            txtVendaQuantidade.Text = (double.Parse(txtVendaValorTotal.Text) / double.Parse(txtVendaValorUnit.Text)).ToString();
        }

        private void btnCalcUnit_Click(object sender, EventArgs e)
        {
            txtVendaValorUnit.Text = (double.Parse(txtVendaValorTotal.Text) / double.Parse(txtVendaQuantidade.Text)).ToString();  
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            txtVendaValorTotal.Text = (double.Parse(txtVendaValorUnit.Text) * double.Parse(txtVendaQuantidade.Text)).ToString();
        }
    }
}
