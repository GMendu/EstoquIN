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
    public partial class Configuracoes : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public Configuracoes()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();
            var query = from e in context.DBusuario
                        from g in context.DBTipo
                        orderby e.Id descending
                        where e.TipoUsuarioId == g.Id
                        select new { e.Id, e.Login, e.Senha, g.Nome};
            bi.DataSource = query.ToList();
            dataConfigUsuario.DataSource = bi;
            dataConfigUsuario.Refresh();
            RefreshCombo();
        }
        public void RefreshCombo()
        {
            cbTipos.Items.Clear();
            var users = context.DBTipo.ToList();
            foreach (TiposUsuario user in users)
            {
                cbTipos.Items.Add(user);
            }
        }
            private void ClearBoxes()
        {
            txtConfigUsuario.Text = null;
            txtConfigSenha.Text = null;
            txtConfigSenhaRep.Text = null;
            cbTipos.ResetText();
        }

        private void btnConfigExcluir_Click(object sender, EventArgs e)
        {
            var t = context.DBusuario.Find((int)dataConfigUsuario.SelectedCells[0].Value);
            context.DBusuario.Remove(t);
            context.SaveChanges();
            RefreshGrid();
            ClearBoxes();
        }

        private void btnConfigAdicionar_Click(object sender, EventArgs e)
        {
            if (cbTipos.SelectedItem != null & txtConfigUsuario.Text != null || txtConfigSenha.Text != null)
            {
                if(txtConfigSenha.Text == txtConfigSenhaRep.Text)
                {
                    var usuario = new DadosUsuario()
                    {
                        TipoUsuarioId = ((TiposUsuario)cbTipos.SelectedItem).Id,
                        Login = txtConfigUsuario.Text,
                        Senha = txtConfigSenha.Text,
                    };
                    context.DBusuario.Add(usuario);
                    context.SaveChanges();
                    RefreshGrid();
                    ClearBoxes();
                }
                else
                {
                    MessageBox.Show("a senha não confere");
                }
            }
            else
            {
                MessageBox.Show("preencha todos os campos");
            }  
        }

        private void btnConfigEditar_Click(object sender, EventArgs e)
        {
            if (btnConfigEditar.Text == "Editar")
            {
                txtConfigUsuario.Text = dataConfigUsuario.SelectedCells[1].Value.ToString();
                txtConfigSenha.Text = dataConfigUsuario.SelectedCells[2].Value.ToString();
                txtConfigSenhaRep.Text = dataConfigUsuario.SelectedCells[2].Value.ToString();
                cbTipos.Text = dataConfigUsuario.SelectedCells[3].Value.ToString();

                

                btnConfigEditar.Text = "Salvar";
            }
            else if (btnConfigEditar.Text == "Salvar")
            {
                if (txtConfigSenha == txtConfigSenhaRep)
                {
                    var editarUsuario = context.DBusuario.Find((int)dataConfigUsuario.SelectedCells[0].Value);
                    editarUsuario.TipoUsuarioId = ((TiposUsuario)cbTipos.SelectedItem).Id;
                    editarUsuario.Login = txtConfigUsuario.Text;
                    editarUsuario.Senha = txtConfigSenha.Text;
                    context.SaveChanges();
                    RefreshGrid();
                    btnConfigEditar.Text = "Editar";
                    ClearBoxes();
                }
                else
                {
                    MessageBox.Show("preencha todos os campos");
                }
            }
        }

        private void btnConfigCancelar_Click(object sender, EventArgs e)
        {
            btnConfigEditar.Text = "Editar";
            ClearBoxes();
        }
    }
}
