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
        public DbSet<DadosCliente> DBclientes { get; set; }
        public DbSet<DadosCompras> DBcompras { get; set; }
        public DbSet<DadosVendas> DBvendas { get; set; }
        public DbSet<DadosFornec> DBfornec { get; set; }
        public DbSet<DadosInsumos> DBinsumos { get; set; }
        public DbSet<DadosProdutos> DBprodutos { get; set; }
        public DbSet<DadosUsuario> DBusuario { get; set; }
        public DbSet<DadosInsumosFornec> DBinsumosfornec { get; set; }
        public DbSet<DadosProdInsumos> DBprodinsumos { get; set; }
        public DbSet<TiposUsuario> DBTipo { get; set; }
        
    }
}
