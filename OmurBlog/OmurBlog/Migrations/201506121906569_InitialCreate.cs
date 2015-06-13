namespace OmurBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makalelers",
                c => new
                    {
                        MakalelerId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Author = c.String(nullable: false, maxLength: 80),
                        Date = c.DateTime(nullable: false),
                        ArticleContent = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MakalelerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Makalelers");
        }
    }
}
