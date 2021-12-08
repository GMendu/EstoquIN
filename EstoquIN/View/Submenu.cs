using EstoquIN.ConfigDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoquIN.View
{
    public partial class Submenu : Form
    {
        private EstoqDBContext context;
        public Submenu(string nomeusuario)
        {
            InitializeComponent();
            context = new EstoqDBContext();
            RefreshGrid();
            lblBemVindo.Text = "Bem Vindo, " + nomeusuario;
            for (int i = 1; i < 4; i++)
            {
                if (File.Exists(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu" + i + ".jpg"))
                {
                    picLogo.Image = Image.FromFile(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu" + i + ".jpg");
                }
            }
        }
        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            txtMenuRelogio.Text = (DateTime.Now.TimeOfDay.ToString()).Substring(0, 8);
        }
        public Submenu(int id)
        {
            InitializeComponent();
            picLogo.Image = Image.FromFile(@"C:\Users\bielm\source\repos\GMendu\abbbbbb\EstoquIN\Images\logo_menu"+id+".jpg");
        }
        private void RefreshGrid()
        {
            BindingSource bivendas = new BindingSource();
            var queryvendas = from e in context.DBvendas
                        from f in context.DBclientes
                        from g in context.DBprodutos
                        orderby e.Id descending
                        where f.Id == e.DadosClienteId & g.Id == e.DadosProdutosId & e.Status == false
                        select new {e.Data, e.FormPag, e.Quant, e.ValorTotal, e.cliente, e.produto, };
            bivendas.DataSource = queryvendas.ToList();
            dataNotifVendas.DataSource = bivendas;
            dataNotifVendas.Refresh();

            BindingSource bicompras = new BindingSource();
            var querycompras = from e in context.DBcompras
                        from f in context.DBfornec
                        from g in context.DBinsumos
                        orderby e.Id descending
                        where f.Id == e.DadosFornecId & g.Id == e.DadosInsumosId & e.Status == false
                        select new {e.Data, e.FormPag, e.Quant, e.ValorTotal, e.Insumos, e.Fornec, };
            bicompras.DataSource = querycompras.ToList();
            dataNotifCompras.DataSource = bicompras;
            dataNotifCompras.Refresh();
        }
    }
}
