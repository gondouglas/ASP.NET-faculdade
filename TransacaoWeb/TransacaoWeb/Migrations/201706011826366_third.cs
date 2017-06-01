namespace TransacaoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transacaos", "ContaDestino_Id", "dbo.Contas");
            DropIndex("dbo.Transacaos", new[] { "ContaDestino_Id" });
            AddColumn("dbo.Transacaos", "ContaOrigemId", c => c.Int(nullable: false));
            AddColumn("dbo.Transacaos", "ContaDestinoId", c => c.Int(nullable: false));
            AddColumn("dbo.Transacaos", "Data", c => c.DateTime(nullable: false));
            DropColumn("dbo.Transacaos", "ContaDestino_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transacaos", "ContaDestino_Id", c => c.Int());
            DropColumn("dbo.Transacaos", "Data");
            DropColumn("dbo.Transacaos", "ContaDestinoId");
            DropColumn("dbo.Transacaos", "ContaOrigemId");
            CreateIndex("dbo.Transacaos", "ContaDestino_Id");
            AddForeignKey("dbo.Transacaos", "ContaDestino_Id", "dbo.Contas", "Id");
        }
    }
}
