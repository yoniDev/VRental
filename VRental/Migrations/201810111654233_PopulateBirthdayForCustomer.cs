namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayForCustomer : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE Customers SET Birthdate = CAST('1998-12-03' AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
