namespace Ektra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotification1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserNotifications", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.UserNotifications", "NotificationType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserNotifications", "NotificationType", c => c.Int(nullable: false));
            DropColumn("dbo.UserNotifications", "Type");
        }
    }
}
