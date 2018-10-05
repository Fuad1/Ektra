namespace Ektra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotification1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Notifications", "NotificationType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "NotificationType", c => c.Int(nullable: false));
            DropColumn("dbo.Notifications", "Type");
        }
    }
}
