namespace JoeMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Membershiptypes SET Name = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE Membershiptypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE Membershiptypes SET Name = 'Quaterly' WHERE Id = 3");
            Sql("UPDATE Membershiptypes SET Name = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
