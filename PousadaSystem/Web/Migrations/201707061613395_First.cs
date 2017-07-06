namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estadias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(nullable: false),
                        Final = c.DateTime(nullable: false),
                        QuantidadeDias = c.Int(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        QuartoID = c.Int(nullable: false),
                        HospedeID = c.Int(nullable: false),
                        Deletado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hospedes", t => t.HospedeID, cascadeDelete: true)
                .ForeignKey("dbo.Quartos", t => t.QuartoID, cascadeDelete: true)
                .Index(t => t.QuartoID)
                .Index(t => t.HospedeID);
            
            CreateTable(
                "dbo.Hospedes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Email = c.String(),
                        Deletado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Quartos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                        Andar = c.String(),
                        ValorDiaria = c.Double(nullable: false),
                        Ocupado = c.Boolean(nullable: false),
                        Deletado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estadias", "QuartoID", "dbo.Quartos");
            DropForeignKey("dbo.Estadias", "HospedeID", "dbo.Hospedes");
            DropIndex("dbo.Estadias", new[] { "HospedeID" });
            DropIndex("dbo.Estadias", new[] { "QuartoID" });
            DropTable("dbo.Quartos");
            DropTable("dbo.Hospedes");
            DropTable("dbo.Estadias");
        }
    }
}
