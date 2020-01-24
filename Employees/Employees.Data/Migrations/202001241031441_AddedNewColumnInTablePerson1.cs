namespace Employees.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumnInTablePerson1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "PhoneNumber");
        }
    }
}
