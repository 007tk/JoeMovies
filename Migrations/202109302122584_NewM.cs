namespace JoeMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewM : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
