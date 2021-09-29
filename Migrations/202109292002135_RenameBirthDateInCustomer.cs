namespace JoeMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameBirthDateInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birhtdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Birhtdate", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
