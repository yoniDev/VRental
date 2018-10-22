namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipType SET Name = Pay as you go, SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 WHERE Id = 1");
            Sql("UPDATE MembershipType SET Name = Monthly, SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10 WHERE Id = 2");
            Sql("UPDATE MembershipType SET Name = Quarterly, SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15 WHERE Id = 3");
            Sql("UPDATE MembershipType SET Name = Yearly, SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
