namespace AddressBook.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Base_User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        SysVersion = c.Int(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Con_Contact", "Base_User_Id", c => c.Guid());
            CreateIndex("dbo.Con_Contact", "Base_User_Id");
            AddForeignKey("dbo.Con_Contact", "Base_User_Id", "dbo.Base_User", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Con_Contact", "Base_User_Id", "dbo.Base_User");
            DropIndex("dbo.Con_Contact", new[] { "Base_User_Id" });
            DropColumn("dbo.Con_Contact", "Base_User_Id");
            DropTable("dbo.Base_User");
        }
    }
}
