namespace TransacaoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cartaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                        CodigoSeguranca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Double(nullable: false),
                        ContaDestino_Id = c.Int(),
                        Cartao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contas", t => t.ContaDestino_Id)
                .ForeignKey("dbo.Cartaos", t => t.Cartao_Id)
                .Index(t => t.ContaDestino_Id)
                .Index(t => t.Cartao_Id);
            
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Agencia = c.String(),
                        Numero = c.String(),
                        Saldo = c.Double(nullable: false),
                        Cartao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cartaos", t => t.Cartao_Id)
                .Index(t => t.Cartao_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transacaos", "Cartao_Id", "dbo.Cartaos");
            DropForeignKey("dbo.Transacaos", "ContaDestino_Id", "dbo.Contas");
            DropForeignKey("dbo.Contas", "Cartao_Id", "dbo.Cartaos");
            DropIndex("dbo.Contas", new[] { "Cartao_Id" });
            DropIndex("dbo.Transacaos", new[] { "Cartao_Id" });
            DropIndex("dbo.Transacaos", new[] { "ContaDestino_Id" });
            DropTable("dbo.Contas");
            DropTable("dbo.Transacaos");
            DropTable("dbo.Cartaos");
        }
    }
}
