using EstoquIN.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoquIN.ConfigDB
{
    class EstoqDBContext:DbContext
    {
        public DbSet<DadosCliente> dbcliente { get; set; }
        public DbSet<DadosCompras> dbcompras { get; set; }
        public DbSet<DadosVendas> dbvendas { get; set; }
        public DbSet<DadosFornec> dbfornec { get; set; }
        public DbSet<DadosInsumos> dbinsumos { get; set; }
        public DbSet<DadosProdutos> dbprodutos { get; set; }
        public DbSet<DadosUsuario> dbusuario { get; set; }
        public DbSet<DadosInsumosFornec> dbinsumosfornec { get; set; }
        public DbSet<DadosProdInsumos> dbprodinsumos { get; set; }
    }
}
