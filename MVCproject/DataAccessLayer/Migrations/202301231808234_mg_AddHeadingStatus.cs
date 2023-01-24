namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg_AddHeadingStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "HeadingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contents", "HeadingStatus");
        }
    }
}
