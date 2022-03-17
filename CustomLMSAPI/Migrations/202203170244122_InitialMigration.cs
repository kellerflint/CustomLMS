namespace CustomLMSAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Badges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BadgeSetID = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BadgeSets", t => t.BadgeSetID, cascadeDelete: true)
                .Index(t => t.BadgeSetID);
            
            CreateTable(
                "dbo.BadgeSets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GroupBadgeSets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BadgeSetID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BadgeSets", t => t.BadgeSetID, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.BadgeSetID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.GroupID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.EnrollmentBadges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EnrollmentID = c.Int(nullable: false),
                        BadgeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Badges", t => t.BadgeID, cascadeDelete: true)
                .ForeignKey("dbo.Enrollments", t => t.EnrollmentID, cascadeDelete: true)
                .Index(t => t.EnrollmentID)
                .Index(t => t.BadgeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupBadgeSets", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.Enrollments", "UserID", "dbo.Users");
            DropForeignKey("dbo.Enrollments", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.EnrollmentBadges", "EnrollmentID", "dbo.Enrollments");
            DropForeignKey("dbo.EnrollmentBadges", "BadgeID", "dbo.Badges");
            DropForeignKey("dbo.GroupBadgeSets", "BadgeSetID", "dbo.BadgeSets");
            DropForeignKey("dbo.Badges", "BadgeSetID", "dbo.BadgeSets");
            DropIndex("dbo.EnrollmentBadges", new[] { "BadgeID" });
            DropIndex("dbo.EnrollmentBadges", new[] { "EnrollmentID" });
            DropIndex("dbo.Enrollments", new[] { "GroupID" });
            DropIndex("dbo.Enrollments", new[] { "UserID" });
            DropIndex("dbo.GroupBadgeSets", new[] { "GroupID" });
            DropIndex("dbo.GroupBadgeSets", new[] { "BadgeSetID" });
            DropIndex("dbo.Badges", new[] { "BadgeSetID" });
            DropTable("dbo.Users");
            DropTable("dbo.EnrollmentBadges");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupBadgeSets");
            DropTable("dbo.BadgeSets");
            DropTable("dbo.Badges");
        }
    }
}
