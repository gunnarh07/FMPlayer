namespace FMLeikmenn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Leikmadur : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Leikmadurs", "TeamPlayerContractedTo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Leikmadurs", "TeamPlayerContractedTo");
        }
    }
}
