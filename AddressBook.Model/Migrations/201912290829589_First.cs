namespace AddressBook.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Con_Contact",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Company = c.String(),
                        Tel = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        QQ = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        SysVersion = c.Int(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                        Groups_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Con_Group", t => t.Groups_Id)
                .Index(t => t.Groups_Id);
            
            CreateTable(
                "dbo.Con_Group",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        SysVersion = c.Int(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Con_Contact", "Groups_Id", "dbo.Con_Group");
            DropIndex("dbo.Con_Contact", new[] { "Groups_Id" });
            DropTable("dbo.Con_Group");
            DropTable("dbo.Con_Contact");
        }
    }
}
