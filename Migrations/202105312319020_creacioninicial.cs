namespace ParcialLPPA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacioninicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afiliado",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        email = c.String(),
                        telefono = c.Int(nullable: false),
                        cuil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Afiliado");
        }
    }
}
