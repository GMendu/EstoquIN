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
using System.Runtime.InteropServices;

namespace EstoquIN.View
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private EstoqDBContext context;
        public FormLogin()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
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
                        FormMainMenu fmm = new FormMainMenu(user.Login, user.TipoUsuarioId);
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

        private void txtLoginSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginLogin_Click(this, new EventArgs());
            }
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
