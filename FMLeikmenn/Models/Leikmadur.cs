using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
///using System.Web.Mvc;

namespace FMLeikmenn.Models
{
    public class Leikmadur
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime DateStamp { get; set; }
        public string Position { get; set; }
        public int Corners { get; set; }
        public int Crossing { get; set; }
        public int Dribbling { get; set; }
        public int Finishing { get; set; }
        public int FirstTouch { get; set; }
        public int FreeKickTaking { get; set; }
        public int Heading { get; set; }
        public int LongShots { get; set; }
        public int LongThrows { get; set; }
        public int Marking { get; set; }
        public int Passing { get; set; }
        public int PenaltyTaking { get; set; }
        public int Tackling { get; set; }
        public int Technique { get; set; }
        public int Aggression { get; set; }
        public int Anticipation { get; set; }
        public int Bravery { get; set; }
        public int Composure { get; set; }
        public int Concentration { get; set; }
        public int Decisions { get; set; }
        public int Determination { get; set; }
        public int Flair { get; set; }
        public int Leadership { get; set; }
        public int OffTheBall { get; set; }
        public int Positioning { get; set; }
        public int Teamwork { get; set; }
        public int Vision { get; set; }
        public int WorkRate { get; set; }
        public int Acceleration { get; set; }
        public int Agility { get; set; }
        public int Balance { get; set; }
        public int JumpingReach { get; set; }
        public int NatuaralFitnes { get; set; }
        public int Pace { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int GoalkeeperRating { get; set; }
        //public int AverageOverall = Position + crossing;//{ get; set; }

        public double AveragePlayerRating
        {
            get
            {
                return (Corners + Crossing + Dribbling + Finishing + FirstTouch + FreeKickTaking + Heading + LongShots +
                    LongThrows + Marking + Passing + PenaltyTaking +  Tackling + Technique + Aggression + Anticipation +
                    Bravery + Composure + Concentration + Decisions + Determination + Flair + Leadership + OffTheBall +
                    Positioning + Teamwork + Vision + WorkRate + Acceleration + Agility + Balance + JumpingReach + 
                    NatuaralFitnes + Pace + Stamina + Strength)/36;
            }
}
        //public IEnumerable<SelectListItem> Positions { get; set; }
    }
    

    public class LeikmadurDBContext : DbContext
    {
        public DbSet<Leikmadur> Leikmenn { get; set; }
    }
}