namespace EmpresaInformatica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItensCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Itens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Itens");
        }
    }
}
