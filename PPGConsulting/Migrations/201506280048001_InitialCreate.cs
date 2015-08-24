namespace PPGConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        Title = c.String(),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        StudyID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Study", t => t.StudyID, cascadeDelete: true)
                .Index(t => t.StudyID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Study",
                c => new
                    {
                        StudyID = c.Int(nullable: false, identity: true),
                        ProjectCode = c.String(),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.StudyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "StudyID", "dbo.Study");
            DropForeignKey("dbo.Project", "EmployeeID", "dbo.Employee");
            DropIndex("dbo.Project", new[] { "EmployeeID" });
            DropIndex("dbo.Project", new[] { "StudyID" });
            DropTable("dbo.Study");
            DropTable("dbo.Project");
            DropTable("dbo.Employee");
        }
    }
}
