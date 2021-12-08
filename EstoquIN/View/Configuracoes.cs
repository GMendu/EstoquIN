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
    public partial class Configuracoes : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public Configuracoes()
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
            for(int i = 1; i<5; i++)
            {
                if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu"+ i +".jpg"))
                {
                    picLogoMenu.Image = Image.FromFile(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu"+i+".jpg");
                }
            }
            
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
            if (cbTipos.SelectedItem != null && txtConfigUsuario.Text != null && txtConfigSenha.Text != null) // tentar context.DBTipo.Contains(cbTipos.SelectedItem)
            {
                bool repetido = false;
                var logins = context.DBusuario.ToList();
                foreach(DadosUsuario log in logins)
                {
                    if(log.Login == txtConfigUsuario.Text)
                    {
                        repetido = true;
                        MessageBox.Show("Este nome de usuário já está sendo utilizado");
                    }
                }
                if (!repetido)
                {
                    if (txtConfigSenha.Text == txtConfigSenhaRep.Text)
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
                        btnConfigAdicionar.Text = "Adicionar";
                        btnConfigEditar.Text = "Editar";
                    }
                    else
                    {
                        MessageBox.Show("a senha não confere");
                    }
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


                btnConfigAdicionar.Text = "Duplicar";
                btnConfigEditar.Text = "Salvar";
            }
            else if (btnConfigEditar.Text == "Salvar")
            {
                if (cbTipos.SelectedItem != null && txtConfigUsuario.Text != null && txtConfigSenha.Text != null)
                { 
                    if (txtConfigSenha.Text == txtConfigSenhaRep.Text)
                    {
                        var editarUsuario = context.DBusuario.Find((int)dataConfigUsuario.SelectedCells[0].Value);
                        editarUsuario.TipoUsuarioId = ((TiposUsuario)cbTipos.SelectedItem).Id;
                        editarUsuario.Login = txtConfigUsuario.Text;
                        editarUsuario.Senha = txtConfigSenha.Text;
                        context.SaveChanges();
                        RefreshGrid();
                        btnConfigAdicionar.Text = "Adicionar";
                        btnConfigEditar.Text = "Editar";
                        ClearBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Senha não confere");
                    }
                    
                }
                else
                {
                    MessageBox.Show("preencha todos os campos");
                }
            }
        }
        // adicionar btnClienteAdicionar.Text = "Adicionar"; ao botão cancelar, adicionar e salvar
        // adicionar btnConfigEditar.Text = "Editar"; ao botão adicionar
        // adicionar btnClienteAdicionar.Text = "Duplicar"; ao botão editar

        private void btnConfigCancelar_Click(object sender, EventArgs e)
        {
            btnConfigAdicionar.Text = "Adicionar";
            btnConfigEditar.Text = "Editar";
            ClearBoxes();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picLogoMenu.Image = new Bitmap(opnfd.FileName);
            }
            if (picLogoMenu.Image != null)
            {
                int id = 4;
                string pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu4.jpg";
                if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu1.jpg"))
                {
                    if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu2.jpg"))
                    {
                        pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu3.jpg";
                        id = 3;
                    }
                    else
                    {
                        pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu2.jpg";
                        id = 2;
                    }
                        
                }else if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu2.jpg"))
                {
                    if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu1.jpg"))
                    {
                        pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu3.jpg";
                        id = 3;
                    }
                    else
                    {
                        pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu1.jpg";
                        id = 1;
                    }
                }else if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu3.jpg"))
                {
                        if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu2.jpg"))
                        {
                            pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu1.jpg";
                            id = 1;
                        }
                        else
                        {
                            pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu2.jpg";
                            id = 2;
                        }
                }
                else
                {
                    id = 1;
                    pathstring = @"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu1.jpg";
                }
                Image a = picLogoMenu.Image;
                a.Save(pathstring);
                for (int i = 1; i < 4; i++)
                {
                    if (i != id && File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu" + i + ".jpg"))
                    {
                        // precisamos encontrar uma forma de deletar o arquivo, mas ele está sendo executado então não pode ser deletado
                        //File.Delete(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu" + i + ".jpg");
                    }
                }
                Submenu sm = new Submenu(id);
            }
            else
            {
                MessageBox.Show("É necessario incluir uma imagem");
            }
        }
    }
}
