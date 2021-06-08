namespace Feedback_Information.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        blogid = c.Int(nullable: false, identity: true),
                        blogdescrip = c.String(),
                        blogentrydate = c.DateTime(nullable: false),
                        userid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.blogid);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        commentid = c.Int(nullable: false, identity: true),
                        commentdescrip = c.String(),
                        commententrydate = c.DateTime(nullable: false),
                        feedback = c.String(),
                        userid = c.Int(nullable: false),
                        blogid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.commentid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.userid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Blogs");
        }
    }
}
