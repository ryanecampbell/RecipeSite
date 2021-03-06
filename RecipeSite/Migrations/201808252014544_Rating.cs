namespace RecipeSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "Rating");
        }
    }
}
