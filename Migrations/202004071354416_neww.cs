namespace TimeSheetWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class neww : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.MyTimesheets", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.ProjectTasks", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.Projects", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.Tasks", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.ProjectUsers", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.UserRoles", "IsDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRoles", "IsDeleted");
            DropColumn("dbo.ProjectUsers", "IsDeleted");
            DropColumn("dbo.Users", "IsDeleted");
            DropColumn("dbo.Tasks", "IsDeleted");
            DropColumn("dbo.Projects", "IsDeleted");
            DropColumn("dbo.ProjectTasks", "IsDeleted");
            DropColumn("dbo.MyTimesheets", "IsDeleted");
            DropColumn("dbo.Customers", "IsDeleted");
        }
    }
}
