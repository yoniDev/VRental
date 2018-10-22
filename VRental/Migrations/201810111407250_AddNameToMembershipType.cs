namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            Sql("UPDATE MembershipTypes SET Name = Pay as you go WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = Monthly WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = Quarterly WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = Yearly WHERE Id = 4");

        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
