namespace FMLeikmenn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leikmadurs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateStamp = c.DateTime(nullable: false),
                        Position = c.String(),
                        Corners = c.Int(nullable: false),
                        Crossing = c.Int(nullable: false),
                        Dribbling = c.Int(nullable: false),
                        Finishing = c.Int(nullable: false),
                        FirstTouch = c.Int(nullable: false),
                        FreeKickTaking = c.Int(nullable: false),
                        Heading = c.Int(nullable: false),
                        LongShots = c.Int(nullable: false),
                        LongThrows = c.Int(nullable: false),
                        Marking = c.Int(nullable: false),
                        Passing = c.Int(nullable: false),
                        PenaltyTaking = c.Int(nullable: false),
                        Tackling = c.Int(nullable: false),
                        Technique = c.Int(nullable: false),
                        Aggression = c.Int(nullable: false),
                        Anticipation = c.Int(nullable: false),
                        Bravery = c.Int(nullable: false),
                        Composure = c.Int(nullable: false),
                        Concentration = c.Int(nullable: false),
                        Decisions = c.Int(nullable: false),
                        Determination = c.Int(nullable: false),
                        Flair = c.Int(nullable: false),
                        Leadership = c.Int(nullable: false),
                        OffTheBall = c.Int(nullable: false),
                        Positioning = c.Int(nullable: false),
                        Teamwork = c.Int(nullable: false),
                        Vision = c.Int(nullable: false),
                        WorkRate = c.Int(nullable: false),
                        Acceleration = c.Int(nullable: false),
                        Agility = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        JumpingReach = c.Int(nullable: false),
                        NatuaralFitnes = c.Int(nullable: false),
                        Pace = c.Int(nullable: false),
                        Stamina = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        GoalkeeperRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leikmadurs");
        }
    }
}
