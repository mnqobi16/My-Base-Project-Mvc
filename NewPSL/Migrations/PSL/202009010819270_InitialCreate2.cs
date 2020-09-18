namespace NewPSL.Migrations.PSL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClubName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customer_Purchase",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        TotalPrice = c.Decimal(precision: 18, scale: 2),
                        LoyaltyPoints = c.Decimal(precision: 18, scale: 2),
                        Date = c.DateTime(),
                        RecieptNo = c.String(),
                        RecieptDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Employee_No = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        GenderID = c.Int(),
                        ID_No = c.String(),
                        Password = c.String(),
                        Username = c.String(),
                        RoleID = c.Int(),
                        Email = c.String(),
                        CellPhone = c.String(),
                        ClubName = c.String(),
                        IsDeleted = c.Boolean(),
                        EmployeeRole_EmployeeRoleId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EmployeeRoles", t => t.EmployeeRole_EmployeeRoleId)
                .ForeignKey("dbo.Genders", t => t.GenderID)
                .Index(t => t.GenderID)
                .Index(t => t.EmployeeRole_EmployeeRoleId);
            
            CreateTable(
                "dbo.EmployeeRoles",
                c => new
                    {
                        EmployeeRoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeRoleId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        GenderID = c.Int(),
                        ID_No = c.String(),
                        Email = c.String(),
                        Cell_No = c.String(),
                        Loyalty_Points = c.Decimal(precision: 18, scale: 2),
                        DateCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genders", t => t.GenderID)
                .Index(t => t.GenderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Customers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.Employees", "EmployeeRole_EmployeeRoleId", "dbo.EmployeeRoles");
            DropForeignKey("dbo.Customer_Purchase", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "GenderID" });
            DropIndex("dbo.Employees", new[] { "EmployeeRole_EmployeeRoleId" });
            DropIndex("dbo.Employees", new[] { "GenderID" });
            DropIndex("dbo.Customer_Purchase", new[] { "EmployeeID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Genders");
            DropTable("dbo.EmployeeRoles");
            DropTable("dbo.Employees");
            DropTable("dbo.Customer_Purchase");
            DropTable("dbo.Clubs");
        }
    }
}
