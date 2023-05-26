
    namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Kullanici", c => c.String());
            DropColumn("dbo.Admins", "Kullanıcı");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Kullanıcı", c => c.String());
            DropColumn("dbo.Admins", "Kullanici");
        }
    }
}
