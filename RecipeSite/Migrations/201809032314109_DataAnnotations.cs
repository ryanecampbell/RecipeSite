namespace RecipeSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Recipes", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Recipes", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Recipes", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Recipes", "Rating", c => c.String());
            AlterColumn("dbo.Recipes", "Genre", c => c.String());
            AlterColumn("dbo.Recipes", "Title", c => c.String());
        }
    }
}
