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

        }

        private void btnProdutoEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutoCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutoExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
