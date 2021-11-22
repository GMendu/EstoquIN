namespace EstoquIN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arroz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DadosClientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(),
                        Razao = c.String(),
                        Inscricao = c.String(),
                        NomeFantasia = c.String(),
                        Obs = c.String(),
                        ContatoNome = c.String(),
                        ContatoEmail = c.String(),
                        ContatoTelefone = c.String(),
                        endereco = c.String(),
                        freq_compra = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DadosCompras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        FormPag = c.String(),
                        Quant = c.Int(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        ValorUnit = c.Double(nullable: false),
                        Status = c.Boolean(nullable: false),
                        NotaFiscal = c.String(),
                        DadosInsumosId = c.Int(nullable: false),
                        DadosFornecId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DadosFornecs", t => t.DadosFornecId, cascadeDelete: true)
                .ForeignKey("dbo.DadosInsumos", t => t.DadosInsumosId, cascadeDelete: true)
                .Index(t => t.DadosInsumosId)
                .Index(t => t.DadosFornecId);
            
            CreateTable(
                "dbo.DadosFornecs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(),
                        Razao = c.String(),
                        Inscricao = c.String(),
                        NomeFantasia = c.String(),
                        Observ = c.String(),
                        ContatoNome = c.String(),
                        ContatoEmail = c.String(),
                        ContatoTelefone = c.String(),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DadosInsumos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DadosInsumosFornecs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DadosFornecId = c.Int(nullable: false),
                        DadosInsumosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DadosFornecs", t => t.DadosFornecId, cascadeDelete: true)
                .ForeignKey("dbo.DadosInsumos", t => t.DadosInsumosId, cascadeDelete: true)
                .Index(t => t.DadosFornecId)
                .Index(t => t.DadosInsumosId);
            
            CreateTable(
                "dbo.DadosProdInsumos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DadosInsumosId = c.Int(nullable: false),
                        DadosProdutosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DadosInsumos", t => t.DadosInsumosId, cascadeDelete: true)
                .ForeignKey("dbo.DadosProdutos", t => t.DadosProdutosId, cascadeDelete: true)
                .Index(t => t.DadosInsumosId)
                .Index(t => t.DadosProdutosId);
            
            CreateTable(
                "dbo.DadosProdutos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Peso = c.Double(nullable: false),
                        ValorVarejo = c.Double(nullable: false),
                        ValorAtacado = c.Double(nullable: false),
                        CodBarras = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DadosUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DadosVendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        FormPag = c.String(),
                        Quant = c.Int(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        ValorUnit = c.Double(nullable: false),
                        Status = c.Boolean(nullable: false),
                        NotaFiscal = c.String(),
                        DadosProdutosId = c.Int(nullable: false),
                        DadosClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DadosClientes", t => t.DadosClienteId, cascadeDelete: true)
                .ForeignKey("dbo.DadosProdutos", t => t.DadosProdutosId, cascadeDelete: true)
                .Index(t => t.DadosProdutosId)
                .Index(t => t.DadosClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DadosVendas", "DadosProdutosId", "dbo.DadosProdutos");
            DropForeignKey("dbo.DadosVendas", "DadosClienteId", "dbo.DadosClientes");
            DropForeignKey("dbo.DadosProdInsumos", "DadosProdutosId", "dbo.DadosProdutos");
            DropForeignKey("dbo.DadosProdInsumos", "DadosInsumosId", "dbo.DadosInsumos");
            DropForeignKey("dbo.DadosInsumosFornecs", "DadosInsumosId", "dbo.DadosInsumos");
            DropForeignKey("dbo.DadosInsumosFornecs", "DadosFornecId", "dbo.DadosFornecs");
            DropForeignKey("dbo.DadosCompras", "DadosInsumosId", "dbo.DadosInsumos");
            DropForeignKey("dbo.DadosCompras", "DadosFornecId", "dbo.DadosFornecs");
            DropIndex("dbo.DadosVendas", new[] { "DadosClienteId" });
            DropIndex("dbo.DadosVendas", new[] { "DadosProdutosId" });
            DropIndex("dbo.DadosProdInsumos", new[] { "DadosProdutosId" });
            DropIndex("dbo.DadosProdInsumos", new[] { "DadosInsumosId" });
            DropIndex("dbo.DadosInsumosFornecs", new[] { "DadosInsumosId" });
            DropIndex("dbo.DadosInsumosFornecs", new[] { "DadosFornecId" });
            DropIndex("dbo.DadosCompras", new[] { "DadosFornecId" });
            DropIndex("dbo.DadosCompras", new[] { "DadosInsumosId" });
            DropTable("dbo.DadosVendas");
            DropTable("dbo.DadosUsuarios");
            DropTable("dbo.DadosProdutos");
            DropTable("dbo.DadosProdInsumos");
            DropTable("dbo.DadosInsumosFornecs");
            DropTable("dbo.DadosInsumos");
            DropTable("dbo.DadosFornecs");
            DropTable("dbo.DadosCompras");
            DropTable("dbo.DadosClientes");
        }
    }
}
