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
    public partial class Produtos : Form
    {
        private EstoqDBContext context;
        public Produtos()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBprodutos
                        orderby e.Id descending
                        select new { e.Id, e.Nome, e.Peso, e.ValorAtacado, e.ValorVarejo, e.Obs};
            bi.DataSource = query.ToList();
            dataProduto.DataSource = bi;
            dataProduto.Refresh();
        }

        private void ClearBoxes()
        {
            txtProdutoNome.Text = null;
            txtProdutoPeso.Text = null;
            txtProdutosCodBar.Text = null;
            txtValorAtacado.Text = null;
            txtValorVarejo.Text = null;
            txtProdutoObs.Text = null;
        }

        private void btnProdutoAdicionar_Click(object sender, EventArgs e)
        {
            if (txtProdutoNome.Text != string.Empty || txtProdutosCodBar.Text != string.Empty)
            {
                var produto = new DadosProdutos()
                {
                    Nome = txtProdutoNome.Text,
                    Peso = txtProdutoPeso.Text,
                    ValorVarejo = txtValorVarejo.Text,
                    ValorAtacado = txtValorAtacado.Text,
                    CodBarras = txtProdutosCodBar.Text,
                    Obs = txtProdutoObs.Text,
                };
                context.DBprodutos.Add(produto);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("informe um nome ou código de barras");
            }
            RefreshGrid();
            ClearBoxes();
        }

        private void btnProdutoEditar_Click(object sender, EventArgs e)
        {
            if (btnProdutoEditar.Text == "Editar")
            {
                txtProdutoNome.Text = dataProduto.SelectedCells[1].Value.ToString();
                txtProdutoPeso.Text = dataProduto.SelectedCells[2].Value.ToString();
                txtValorVarejo.Text = dataProduto.SelectedCells[3].Value.ToString();
                txtValorAtacado.Text = dataProduto.SelectedCells[4].Value.ToString();
                txtProdutoObs.Text = dataProduto.SelectedCells[6].Value.ToString();
                txtProdutosCodBar.Text = dataProduto.SelectedCells[5].Value.ToString();
                btnProdutoEditar.Text = "Salvar";
            }
            else if (btnProdutoEditar.Text == "Salvar")
            {
                var editarProd = context.DBprodutos.Find((int)dataProduto.SelectedCells[0].Value);

                editarProd.Nome = txtProdutoNome.Text;
                editarProd.Peso = txtProdutoPeso.Text;
                editarProd.ValorVarejo = txtValorVarejo.Text;
                editarProd.ValorAtacado = txtValorAtacado.Text;
                editarProd.CodBarras = txtProdutosCodBar.Text;
                editarProd.Obs = txtProdutoObs.Text;

                context.SaveChanges();
                RefreshGrid();

                btnProdutoEditar.Text = "Editar";
                ClearBoxes();


            }
        }

        private void btnProdutoCancelar_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnProdutoExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBprodutos.Find((int)dataProduto.SelectedCells[0].Value);
            context.DBprodutos.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }
    }
}
