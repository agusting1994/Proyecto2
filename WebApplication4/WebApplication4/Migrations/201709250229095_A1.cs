namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Apellido", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Apellido");
        }
    }
}
