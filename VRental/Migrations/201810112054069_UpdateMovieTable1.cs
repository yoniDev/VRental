namespace VRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleasedDate = CAST('09-08-1999' AS DATETIME), AddedDate = CAST('09-11-2001' AS DATETIME), NumbersInStock= '3', GenreId = '2'   WHERE Id = 1");
            Sql("UPDATE Movies SET ReleasedDate = CAST('12-10-2004' AS DATETIME), AddedDate = CAST('12-06-2012' AS DATETIME), NumbersInStock= '12', GenreId = '4'   WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
