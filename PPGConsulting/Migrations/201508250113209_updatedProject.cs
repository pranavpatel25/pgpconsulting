namespace PPGConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedProject : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "EmployeeID", "dbo.Employee");
            DropIndex("dbo.Project", new[] { "EmployeeID" });
            RenameColumn(table: "dbo.Project", name: "EmployeeID", newName: "Employee_ID");
            AlterColumn("dbo.Project", "Employee_ID", c => c.Int());
            CreateIndex("dbo.Project", "Employee_ID");
            AddForeignKey("dbo.Project", "Employee_ID", "dbo.Employee", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "Employee_ID", "dbo.Employee");
            DropIndex("dbo.Project", new[] { "Employee_ID" });
            AlterColumn("dbo.Project", "Employee_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Project", name: "Employee_ID", newName: "EmployeeID");
            CreateIndex("dbo.Project", "EmployeeID");
            AddForeignKey("dbo.Project", "EmployeeID", "dbo.Employee", "ID", cascadeDelete: true);
        }
    }
}
