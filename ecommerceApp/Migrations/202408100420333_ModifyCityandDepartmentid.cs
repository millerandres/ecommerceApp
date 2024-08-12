namespace ecommerceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCityandDepartmentid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Cities", new[] { "DepartmentId" });
            AddColumn("dbo.Cities", "Department_DepartmentId", c => c.Int());
            AlterColumn("dbo.Cities", "DepartmentId", c => c.String(nullable: false));
            CreateIndex("dbo.Cities", "Department_DepartmentId");
            AddForeignKey("dbo.Cities", "Department_DepartmentId", "dbo.Departments", "DepartmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Cities", new[] { "Department_DepartmentId" });
            AlterColumn("dbo.Cities", "DepartmentId", c => c.Int(nullable: false));
            DropColumn("dbo.Cities", "Department_DepartmentId");
            CreateIndex("dbo.Cities", "DepartmentId");
            AddForeignKey("dbo.Cities", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: true);
        }
    }
}
