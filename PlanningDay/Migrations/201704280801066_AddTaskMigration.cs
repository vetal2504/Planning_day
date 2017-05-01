namespace PlanningDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TableTasks", "EveryDay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TableTasks", "EveryDay");
        }
    }
}
