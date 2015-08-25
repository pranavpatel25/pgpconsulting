namespace PPGConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedProjectEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Project", t => t.ProjectId, cascadeDelete: false)
                .Index(t => t.ProjectId)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectEmployees", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.ProjectEmployees", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.ProjectEmployees", new[] { "EmployeeId" });
            DropIndex("dbo.ProjectEmployees", new[] { "ProjectId" });
            DropTable("dbo.ProjectEmployees");
        }
    }
}
