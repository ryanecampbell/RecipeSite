namespace RecipeSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstruction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructions",
                c => new
                    {
                        InstructionID = c.Int(nullable: false, identity: true),
                        RecipeID = c.Int(nullable: false),
                        Sequence = c.Int(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.InstructionID)
                .ForeignKey("dbo.Recipes", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructions", "RecipeID", "dbo.Recipes");
            DropIndex("dbo.Instructions", new[] { "RecipeID" });
            DropTable("dbo.Instructions");
        }
    }
}
