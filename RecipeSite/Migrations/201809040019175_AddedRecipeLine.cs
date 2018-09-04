namespace RecipeSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRecipeLine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecipeLines",
                c => new
                    {
                        RecipeLineID = c.Int(nullable: false, identity: true),
                        RecipeID = c.Int(nullable: false),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Measurement = c.Int(nullable: false),
                        Ingredient = c.String(),
                    })
                .PrimaryKey(t => t.RecipeLineID)
                .ForeignKey("dbo.Recipes", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID);
            
            AddColumn("dbo.Recipes", "PrepTime", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Recipes", "CookTime", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Recipes", "MealType", c => c.Int(nullable: false));
            RenameColumn("dbo.Recipes", "ID", "RecipeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeLines", "RecipeID", "dbo.Recipes");
            DropColumn("dbo.Recipes", "MealType");
            DropColumn("dbo.Recipes", "CookTime");
            DropColumn("dbo.Recipes", "PrepTime");
            DropTable("dbo.RecipeLines");
            RenameColumn("dbo.Recipes", "RecipeID", "ID");
        }
    }
}
