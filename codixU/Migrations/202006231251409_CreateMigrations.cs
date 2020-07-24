namespace codixU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        xml = c.String(),
                        tags = c.String(),
                        creaateDate = c.DateTime(nullable: false),
                        Interactive_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Interactive", t => t.Interactive_ID)
                .Index(t => t.Interactive_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 20),
                        algorithm = c.Boolean(nullable: false),
                        score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Interactive",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Quizzes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Interactive_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Interactive", t => t.Interactive_ID)
                .Index(t => t.Interactive_ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        question = c.String(),
                        Image = c.String(),
                        optionA = c.String(),
                        optionB = c.String(),
                        optionC = c.String(),
                        optionD = c.String(),
                        answer = c.String(),
                        Quizzes_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Quizzes", t => t.Quizzes_ID)
                .Index(t => t.Quizzes_ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UsersInteractive",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Interactive_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Interactive_ID })
                .ForeignKey("dbo.Interactive", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Interactive_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Interactive_ID);
            
            CreateTable(
                "dbo.UsersRoles",
                c => new
                    {
                        UserRefID = c.Int(nullable: false),
                        RoleRefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserRefID, t.RoleRefID })
                .ForeignKey("dbo.Users", t => t.UserRefID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleRefID, cascadeDelete: true)
                .Index(t => t.UserRefID)
                .Index(t => t.RoleRefID);
            
            CreateTable(
                "dbo.UsersCourses",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Courses_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Courses_ID })
                .ForeignKey("dbo.Courses", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Courses_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Courses_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersCourses", "Courses_ID", "dbo.Users");
            DropForeignKey("dbo.UsersCourses", "User_ID", "dbo.Courses");
            DropForeignKey("dbo.UsersRoles", "RoleRefID", "dbo.Roles");
            DropForeignKey("dbo.UsersRoles", "UserRefID", "dbo.Users");
            DropForeignKey("dbo.UsersInteractive", "Interactive_ID", "dbo.Users");
            DropForeignKey("dbo.UsersInteractive", "User_ID", "dbo.Interactive");
            DropForeignKey("dbo.Quizzes", "Interactive_ID", "dbo.Interactive");
            DropForeignKey("dbo.Questions", "Quizzes_ID", "dbo.Quizzes");
            DropForeignKey("dbo.Courses", "Interactive_ID", "dbo.Interactive");
            DropIndex("dbo.UsersCourses", new[] { "Courses_ID" });
            DropIndex("dbo.UsersCourses", new[] { "User_ID" });
            DropIndex("dbo.UsersRoles", new[] { "RoleRefID" });
            DropIndex("dbo.UsersRoles", new[] { "UserRefID" });
            DropIndex("dbo.UsersInteractive", new[] { "Interactive_ID" });
            DropIndex("dbo.UsersInteractive", new[] { "User_ID" });
            DropIndex("dbo.Questions", new[] { "Quizzes_ID" });
            DropIndex("dbo.Quizzes", new[] { "Interactive_ID" });
            DropIndex("dbo.Courses", new[] { "Interactive_ID" });
            DropTable("dbo.UsersCourses");
            DropTable("dbo.UsersRoles");
            DropTable("dbo.UsersInteractive");
            DropTable("dbo.Roles");
            DropTable("dbo.Questions");
            DropTable("dbo.Quizzes");
            DropTable("dbo.Interactive");
            DropTable("dbo.Users");
            DropTable("dbo.Courses");
        }
    }
}
