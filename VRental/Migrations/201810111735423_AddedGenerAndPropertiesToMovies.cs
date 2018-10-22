namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenerAndPropertiesToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumbersInStock", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "GenerId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenerId");
            DropColumn("dbo.Movies", "NumbersInStock");
            DropColumn("dbo.Movies", "AddedDate");
            DropColumn("dbo.Movies", "ReleasedDate");
        }
    }
}
