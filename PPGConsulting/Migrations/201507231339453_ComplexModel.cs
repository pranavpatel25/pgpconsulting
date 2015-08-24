namespace PPGConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(nullable: false, maxLength: 50),
                        ClientContactName = c.String(nullable: false, maxLength: 50),
                        OnBoardDate = c.DateTime(nullable: false),
                        Study_StudyID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Study", t => t.Study_StudyID)
                .Index(t => t.Study_StudyID);
            
            CreateTable(
                "dbo.OfficeAssignment",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        Location = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            AddColumn("dbo.Project", "Client_ID", c => c.Int());
            CreateIndex("dbo.Project", "Client_ID");
            AddForeignKey("dbo.Project", "Client_ID", "dbo.Client", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "Client_ID", "dbo.Client");
            DropForeignKey("dbo.Client", "Study_StudyID", "dbo.Study");
            DropForeignKey("dbo.OfficeAssignment", "EmployeeID", "dbo.Employee");
            DropIndex("dbo.OfficeAssignment", new[] { "EmployeeID" });
            DropIndex("dbo.Project", new[] { "Client_ID" });
            DropIndex("dbo.Client", new[] { "Study_StudyID" });
            DropColumn("dbo.Project", "Client_ID");
            DropTable("dbo.OfficeAssignment");
            DropTable("dbo.Client");
        }
    }
}
