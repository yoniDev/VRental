namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropertiesToMovies : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "GenerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenerId", c => c.Byte(nullable: false));
        }
    }
}
