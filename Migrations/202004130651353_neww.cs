namespace TimeSheetWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class neww : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.MyTimesheets", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.ProjectTasks", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.Projects", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.Tasks", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.ProjectUsers", "IsDeleted", c => c.Boolean());
            AlterColumn("dbo.UserRoles", "IsDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserRoles", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ProjectUsers", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Tasks", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Projects", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ProjectTasks", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.MyTimesheets", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "IsDeleted", c => c.Boolean(nullable: false));
        }
    }
}
