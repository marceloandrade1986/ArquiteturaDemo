namespace ArquiteturaDemo.Infra.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estadoes", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        UF = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrevisaoClimas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Clima = c.Int(nullable: false),
                        TemperaturaMinima = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TemperaturaMaxima = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataPrevisao = c.DateTime(nullable: false),
                        CidadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cidades", t => t.CidadeId, cascadeDelete: true)
                .Index(t => t.CidadeId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Decimal(nullable: false, precision: 10, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrevisaoClimas", "CidadeId", "dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadoId", "dbo.Estadoes");
            DropIndex("dbo.PrevisaoClimas", new[] { "CidadeId" });
            DropIndex("dbo.Cidades", new[] { "EstadoId" });
            DropTable("dbo.Products");
            DropTable("dbo.PrevisaoClimas");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
        }
    }
}
