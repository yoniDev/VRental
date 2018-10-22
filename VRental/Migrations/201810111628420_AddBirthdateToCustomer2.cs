namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1998-11-09' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = null WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
