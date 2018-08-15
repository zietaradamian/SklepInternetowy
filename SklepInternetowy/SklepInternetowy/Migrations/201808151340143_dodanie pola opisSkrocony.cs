namespace SklepInternetowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniepolaopisSkrocony : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kurs", "OpisSkrocony", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kurs", "OpisSkrocony");
        }
    }
}
