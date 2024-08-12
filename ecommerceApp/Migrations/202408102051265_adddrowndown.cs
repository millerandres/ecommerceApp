namespace ecommerceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddrowndown : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Cities", new[] { "Department_DepartmentId" });
            DropColumn("dbo.Cities", "DepartmentId");
            RenameColumn(table: "dbo.Cities", name: "Department_DepartmentId", newName: "DepartmentId");
            AlterColumn("dbo.Cities", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "DepartmentId");
            AddForeignKey("dbo.Cities", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Cities", new[] { "DepartmentId" });
            AlterColumn("dbo.Cities", "DepartmentId", c => c.Int());
            AlterColumn("dbo.Cities", "DepartmentId", c => c.String(nullable: false));
            RenameColumn(table: "dbo.Cities", name: "DepartmentId", newName: "Department_DepartmentId");
            AddColumn("dbo.Cities", "DepartmentId", c => c.String(nullable: false));
            CreateIndex("dbo.Cities", "Department_DepartmentId");
            AddForeignKey("dbo.Cities", "Department_DepartmentId", "dbo.Departments", "DepartmentId");
        }
    }
}
