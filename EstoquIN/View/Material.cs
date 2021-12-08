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
    public partial class Material : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public Material()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBinsumos
                        orderby e.Id descending
                        select new { e.Id, e.Nome};
            bi.DataSource = query.ToList();
            dataMaterial.DataSource = bi;
            dataMaterial.Refresh();

            BindingSource bs = new BindingSource();
            var queri = from c in context.DBfornec
                        orderby c.Id descending
                        select new { c.Id, c.Cnpj, c.NomeFantasia, c.Razao, c.ContatoEmail, c.ContatoNome, c.ContatoTelefone };
            bs.DataSource = queri.ToList();
            dataMaterialFornec.DataSource = bs;
            dataMaterialFornec.Refresh();
        }

        private void ClearBoxes()
        {
            txtMaterialNome.Text = null;
        }

        private void btnMaterialAdicionar_Click(object sender, EventArgs e)
        {
            if(txtMaterialNome.Text != string.Empty)
            {
                var material = new DadosInsumos()
                {
                    Nome = txtMaterialNome.Text
                };
                context.DBinsumos.Add(material);
                context.SaveChanges();
                btnMaterialAdicionar.Text = "Adicionar";
                btnMaterialEditar.Text = "Editar";
                RefreshGrid();
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("preencha o nome");
            }
        }
        // adicionar btnClienteAdicionar.Text = "Adicionar"; ao botão cancelar, adicionar e salvar
        // adicionar btnConfigEditar.Text = "Editar"; ao botão adicionar
        // adicionar btnClienteAdicionar.Text = "Duplicar"; ao botão editar
        private void btnMaterialCancelar_Click(object sender, EventArgs e)
        {
            btnMaterialAdicionar.Text = "Adicionar";
            btnMaterialEditar.Text = "Editar";
            ClearBoxes();
        }

        private void btnMaterialEditar_Click(object sender, EventArgs e)
        {
            if (btnMaterialEditar.Text == "Editar")
            {
                txtMaterialNome.Text = dataMaterial.SelectedCells[1].Value.ToString();
                btnMaterialAdicionar.Text = "Duplicar";
                btnMaterialEditar.Text = "Salvar";
            }
            else if (btnMaterialEditar.Text == "Salvar")
            {
                var editarMaterial = context.DBinsumos.Find((int)dataMaterial.SelectedCells[0].Value);

                editarMaterial.Nome = txtMaterialNome.Text;

                context.SaveChanges();
                RefreshGrid();
                btnMaterialAdicionar.Text = "Adicionar";
                btnMaterialEditar.Text = "Editar";
                ClearBoxes();
            }
        }

        private void btnMaterialExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBinsumos.Find((int)dataMaterial.SelectedCells[0].Value);
            context.DBinsumos.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }
    }
}
