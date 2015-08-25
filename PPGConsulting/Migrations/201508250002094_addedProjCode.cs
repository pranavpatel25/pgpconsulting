namespace PPGConsulting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedProjCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "ProjectCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "ProjectCode");
        }
    }
}
