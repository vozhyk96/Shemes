namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "tags", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "tags");
        }
    }
}
