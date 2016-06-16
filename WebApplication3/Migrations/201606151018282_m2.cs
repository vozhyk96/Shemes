namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
