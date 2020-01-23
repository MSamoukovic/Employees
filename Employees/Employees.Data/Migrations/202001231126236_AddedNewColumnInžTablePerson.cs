namespace Employees.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumnInTablePerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "EmployeeId");
            AddForeignKey("dbo.People", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.People", new[] { "EmployeeId" });
            DropColumn("dbo.People", "EmployeeId");
        }
    }
}
