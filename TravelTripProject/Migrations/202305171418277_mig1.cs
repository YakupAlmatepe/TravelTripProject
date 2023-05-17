﻿namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdresBlogs", "Baslik", c => c.String());
            DropColumn("dbo.AdresBlogs", "Başlık");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdresBlogs", "Başlık", c => c.String());
            DropColumn("dbo.AdresBlogs", "Baslik");
        }
    }
}
