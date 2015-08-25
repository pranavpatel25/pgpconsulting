namespace PPGConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmployeesInProj : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "Employee_ID", "dbo.Employee");
            DropIndex("dbo.Project", new[] { "Employee_ID" });
            CreateTable(
                "dbo.EmployeeProject",
                c => new
                    {
                        Employee_ID = c.Int(nullable: false),
                        Project_ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_ID, t.Project_ProjectID })
                .ForeignKey("dbo.Employee", t => t.Employee_ID, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.Project_ProjectID, cascadeDelete: true)
                .Index(t => t.Employee_ID)
                .Index(t => t.Project_ProjectID);
            
            DropColumn("dbo.Project", "Employee_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "Employee_ID", c => c.Int());
            DropForeignKey("dbo.EmployeeProject", "Project_ProjectID", "dbo.Project");
            DropForeignKey("dbo.EmployeeProject", "Employee_ID", "dbo.Employee");
            DropIndex("dbo.EmployeeProject", new[] { "Project_ProjectID" });
            DropIndex("dbo.EmployeeProject", new[] { "Employee_ID" });
            DropTable("dbo.EmployeeProject");
            CreateIndex("dbo.Project", "Employee_ID");
            AddForeignKey("dbo.Project", "Employee_ID", "dbo.Employee", "ID");
        }
    }
}
