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
        //public string NameOfTeamThatPlayerIsContractedTo { get; set; }
        [DataType(DataType.Date)]
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

        public double LiberoSupport
        {
            get
            {
                return (Dribbling + Heading + Marking + Passing + Tackling + Anticipation + Bravery + Composure + Concentration + 
                    Decisions + Determination + Positioning + Teamwork + Vision + Acceleration + Agility + Balance + JumpingReach +
                    Strength) / 19;
            }
        }

        public double BallPlayingDefender
        {
            get
            {
                return (FirstTouch + Heading + Marking + Passing + Tackling + Technique + Anticipation + Bravery + Composure + Concentration + Decisions + 
                    Determination + Positioning + Vision + Acceleration + JumpingReach + Strength) / 17;
            }
        }

        public double CentralDefender
        {
            get
            {
                return (Heading + Marking + Tackling + Aggression + Anticipation + Bravery + Concentration + Decisions +
                    Determination + Positioning + JumpingReach + Strength) / 12;
            }
        }

        public double LimitedCentralDefender
        {
            get
            {
                return (Heading + Marking + Tackling + Determination + Positioning + JumpingReach + Strength) / 7;
            }
        }

        public double CompleteWingBack
        {
            get
            {
                return (Crossing + Dribbling + FirstTouch+ + Marking + Passing + Tackling + Technique + 
                    Anticipation + Composure + Concentration + Decisions + Flair + OffTheBall + Positioning + Teamwork + WorkRate +
                    Acceleration + Agility + Balance + Pace + Stamina) / 21;
            }
        }

        public double FullBackDefend
        {
            get
            {
                return (Marking + Tackling +
                    Anticipation  + Concentration + Positioning + Teamwork +
                    Acceleration + Stamina) / 8;
            }
        }

        public double FullBackSuport
        {
            get
            {
                return (Crossing + Marking + Passing + Tackling +
                    Anticipation + Concentration + Positioning + Teamwork + WorkRate +
                    Acceleration + Stamina) / 11;
            }
        }

        public double FullBackAttack
        {
            get
            {
                return (Crossing + Dribbling + FirstTouch + Marking + Tackling +
                    Anticipation + Concentration + OffTheBall + Positioning + Teamwork + WorkRate +
                    Acceleration + Pace + Stamina) / 14;
            }
        }

        public double LimitedFullBack
        {
            get
            {
                return (Marking + Tackling +
                    Anticipation + Concentration + Decisions + Positioning + Teamwork + 
                    Stamina) / 8;
            }
        }

        public double AnchorManDefend
        {
            get
            {
                return (Heading + Marking + Passing + Tackling +
                    Anticipation + Composure + Concentration + Decisions + Determination + Positioning +
                    Strength) / 11;
            }
        }

        public double BallWinningMidfielder
        {
            get
            {
                return (Marking + Tackling +
                    Aggression + Bravery + Determination + Positioning + Teamwork + WorkRate +
                    Acceleration + Stamina + Strength) / 12;
            }
        }

        public double BoxToBoxMidfielderSupport
        {
            get
            {
                return (Finishing + FirstTouch + LongShots + Passing + Tackling +
                    Anticipation + Bravery + Composure + Concentration + Decisions + Determination + OffTheBall + Positioning + WorkRate +
                    Acceleration + Balance + NatuaralFitnes + Stamina + Strength) / 19;
            }
        }

        public double DeepLyingPlaymakerDefender
        {
            get
            {
                return (FirstTouch + Passing + Technique +
                    Composure + Decisions + Positioning + Teamwork + Vision +
                    Balance) / 9;
            }
        }

        public double DeepLyingPlaymakerSupport
        {
            get
            {
                return (FirstTouch + LongShots + Passing + Technique +
                    Composure + Decisions + OffTheBall + Teamwork + Vision +
                    Balance) / 10;
            }
        }

        public double AdvancedPlaymakerSupport
        {
            get
            {
                return (FirstTouch + Passing + Technique +
                    Composure + Decisions + Flair + Teamwork + Vision) / 8;
            }
        }

        public double AdvancedPlaymakerAttack
        {
            get
            {
                return (Dribbling + FirstTouch + Passing + Technique +
                    Anticipation + Composure + Decisions + Flair + OffTheBall + Teamwork + Vision) / 11;
            }
        }

        public double AttackingMidfielderSupport
        {
            get
            {
                return (FirstTouch + LongShots + Passing + Technique +
                    Anticipation + Composure + Decisions + OffTheBall +  Positioning + Teamwork + Vision
                    ) / 11;
            }
        }

        public double AttackingMidfielderAttack
        {
            get
            {
                return (Finishing + FirstTouch + LongShots + Passing + Technique +
                    Anticipation + Composure + Concentration + Decisions + OffTheBall + Teamwork + Vision
                    ) / 12;
            }
        }

        public double WingerSupport
        {
            get
            {
                return (Crossing + Dribbling + FirstTouch + Passing + Technique +
                    WorkRate +
                    Acceleration + Pace + Stamina) / 9;
            }
        }

        public double WingerAttack
        {
            get
            {
                return (Crossing + Dribbling + FirstTouch + Passing + Technique +
                    Flair + OffTheBall + WorkRate +
                    Acceleration + Pace + Stamina) / 11;
            }
        }

        public double PoacherAttributes
        {
            get
            {
                return (Finishing + FirstTouch + Anticipation + Composure + Concentration + OffTheBall + Acceleration + Agility) / 8;
            }
        }
        //public IEnumerable<SelectListItem> Positions { get; set; }
    }
    

    public class LeikmadurDBContext : DbContext
    {
        public DbSet<Leikmadur> Leikmenn { get; set; }
    }
}