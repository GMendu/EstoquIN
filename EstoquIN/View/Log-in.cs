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
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public FormLogin()
        {
            context = new EstoqDBContext();
            InitializeComponent();
            if (context.DBTipo.Count() == 0)
            {
                var gerente = new TiposUsuario()
                {
                    Id = 1,
                    Nome = "Gerente"
                };
                context.DBTipo.Add(gerente);
                context.SaveChanges();
                var func = new TiposUsuario()
                {
                    Id = 2,
                    Nome = "Funcionário"
                };
                context.DBTipo.Add(func);
                context.SaveChanges();
            }
            if (context.DBusuario.Count() == 0)
            {
                var adm = new DadosUsuario()
                {
                    TipoUsuarioId = 1,
                    Login = "admin",
                    Senha = "admin",
                };
                context.DBusuario.Add(adm);
                context.SaveChanges();
            }
        }
        
        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            int check = 0;
            

            var users = context.DBusuario.ToList();
            foreach (DadosUsuario user in users)
            {
                if(user.Login == txtLoginUser.Text)
                {
                    if (user.Senha == txtLoginSenha.Text)
                    {
                        //MessageBox.Show("Login efetuado com sucesso");
                        FormMainMenu fmm = new FormMainMenu(user.Login);
                        this.Hide();
                        fmm.Show();
                        check = 1;
                    }
                }
            }
            if (check == 0)
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }              
        }
    }
}
