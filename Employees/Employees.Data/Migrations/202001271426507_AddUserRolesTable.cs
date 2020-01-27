namespace Employees.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserRolesTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserRoles", name: "User_UserId", newName: "UserId");
            RenameColumn(table: "dbo.UserRoles", name: "Role_RoleId", newName: "RoleId");
            RenameIndex(table: "dbo.UserRoles", name: "IX_User_UserId", newName: "IX_UserId");
            RenameIndex(table: "dbo.UserRoles", name: "IX_Role_RoleId", newName: "IX_RoleId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserRoles", name: "IX_RoleId", newName: "IX_Role_RoleId");
            RenameIndex(table: "dbo.UserRoles", name: "IX_UserId", newName: "IX_User_UserId");
            RenameColumn(table: "dbo.UserRoles", name: "RoleId", newName: "Role_RoleId");
            RenameColumn(table: "dbo.UserRoles", name: "UserId", newName: "User_UserId");
        }
    }
}
