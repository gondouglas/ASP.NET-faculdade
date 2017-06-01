namespace TransacaoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contas", "Cartao_Id", "dbo.Cartaos");
            DropIndex("dbo.Contas", new[] { "Cartao_Id" });
            AddColumn("dbo.Cartaos", "ContaId", c => c.Int(nullable: false));
            AddColumn("dbo.Contas", "CartaoId", c => c.Int(nullable: false));
            DropColumn("dbo.Contas", "Cartao_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contas", "Cartao_Id", c => c.Int());
            DropColumn("dbo.Contas", "CartaoId");
            DropColumn("dbo.Cartaos", "ContaId");
            CreateIndex("dbo.Contas", "Cartao_Id");
            AddForeignKey("dbo.Contas", "Cartao_Id", "dbo.Cartaos", "Id");
        }
    }
}
