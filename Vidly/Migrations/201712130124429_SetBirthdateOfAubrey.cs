namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateOfAubrey : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = 12/18/1990 WHERE Name = 'Aubrey Mills'");
        }
        
        public override void Down()
        {
        }
    }
}
