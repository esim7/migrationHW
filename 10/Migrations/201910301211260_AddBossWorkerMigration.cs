namespace _10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBossWorkerMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "Boss_Id", c => c.Int());
            CreateIndex("dbo.Workers", "Boss_Id");
            AddForeignKey("dbo.Workers", "Boss_Id", "dbo.Bosses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "Boss_Id", "dbo.Bosses");
            DropIndex("dbo.Workers", new[] { "Boss_Id" });
            DropColumn("dbo.Workers", "Boss_Id");
        }
    }
}
