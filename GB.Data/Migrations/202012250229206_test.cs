﻿namespace GB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bibliotheques", "g", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bibliotheques", "g");
        }
    }
}
