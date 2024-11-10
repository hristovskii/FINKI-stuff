namespace Pregledi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_Id" });
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Hospital_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Hospitals", "Image", c => c.Binary(nullable: false));
            AlterColumn("dbo.Hospitals", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Hospitals", "Address", c => c.String(nullable: false));
            CreateIndex("dbo.Doctors", "Hospital_Id");
            AddForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_Id" });
            AlterColumn("dbo.Hospitals", "Address", c => c.String());
            AlterColumn("dbo.Hospitals", "Name", c => c.String());
            AlterColumn("dbo.Hospitals", "Image", c => c.Binary());
            AlterColumn("dbo.Doctors", "Hospital_Id", c => c.Int());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
            CreateIndex("dbo.Doctors", "Hospital_Id");
            AddForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals", "Id");
        }
    }
}
