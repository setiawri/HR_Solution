namespace HRWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DOB", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "Height", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Weight", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Phone1", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone2", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address1", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address2", c => c.String());
            AddColumn("dbo.AspNetUsers", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Notes");
            DropColumn("dbo.AspNetUsers", "Address2");
            DropColumn("dbo.AspNetUsers", "Address1");
            DropColumn("dbo.AspNetUsers", "Phone2");
            DropColumn("dbo.AspNetUsers", "Phone1");
            DropColumn("dbo.AspNetUsers", "Weight");
            DropColumn("dbo.AspNetUsers", "Height");
            DropColumn("dbo.AspNetUsers", "DOB");
        }
    }
}
