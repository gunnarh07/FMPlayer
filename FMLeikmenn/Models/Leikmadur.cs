using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
///using System.Web.Mvc;

namespace FMLeikmenn.Models
{
    public class Leikmadur
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Scouting")]
        public DateTime DateStamp { get; set; }
        public string Position { get; set; }
        public int Corners { get; set; }
        public int Crossing { get; set; }
        public int Dribbling { get; set; }
        public int Finishing { get; set; }
        [Display(Name = "First Touch")]
        public int FirstTouch { get; set; }
        [Display(Name = "Freekick Taking")]
        public int FreeKickTaking { get; set; }
        public int Heading { get; set; }
        [Display(Name = "Longshots")]
        public int LongShots { get; set; }
        [Display(Name = "Longthroes")]
        public int LongThrows { get; set; }
        public int Marking { get; set; }
        public int Passing { get; set; }
        [Display(Name = "Penalty Taking")]
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
        [Display(Name = "Off The Ball")]
        public int OffTheBall { get; set; }
        public int Positioning { get; set; }
        public int Teamwork { get; set; }
        public int Vision { get; set; }
        public int WorkRate { get; set; }
        public int Acceleration { get; set; }
        public int Agility { get; set; }
        public int Balance { get; set; }
        [Display(Name = "Jumping Reach")]
        public int JumpingReach { get; set; }
        [Display(Name = "Natural Fitnes")]
        public int NatuaralFitnes { get; set; }
        public int Pace { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        [Display(Name = "Goalkeeper Rating")]
        public int GoalkeeperRating { get; set; }
        [Display(Name = "Contracted to:")]
        public string TeamPlayerContractedTo { get; set; }

        [Display(Name = "Average Player Rating")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AveragePlayerRating
        {
            
            get
            {
                double AllAttributes = 36;
                double Sum = 0;

                return Sum = (Corners + Crossing + Dribbling + Finishing + FirstTouch + FreeKickTaking + Heading + LongShots +
                    LongThrows + Marking + Passing + PenaltyTaking +  Tackling + Technique + Aggression + Anticipation +
                    Bravery + Composure + Concentration + Decisions + Determination + Flair + Leadership + OffTheBall +
                    Positioning + Teamwork + Vision + WorkRate + Acceleration + Agility + Balance + JumpingReach + 
                    NatuaralFitnes + Pace + Stamina + Strength) / AllAttributes;
            }
        }

        [Display(Name = "Libero Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double LiberoSupport
        {
            get
            {
                double LiberoAttributes = 19;
                double Sum = 0;
                return Sum = (Dribbling + Heading + Marking + Passing + Tackling + Anticipation + Bravery + Composure + Concentration + 
                    Decisions + Determination + Positioning + Teamwork + Vision + Acceleration + Agility + Balance + JumpingReach +
                    Strength) / LiberoAttributes;
            }
        }

        [Display(Name = "Ballplaying Defender")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double BallPlayingDefender
        {
            get
            {
                double BallPlayingDefenderAttributes = 17;
                double Sum = 0;
                return Sum = (FirstTouch + Heading + Marking + Passing + Tackling + Technique + Anticipation + Bravery + Composure + Concentration + Decisions + 
                    Determination + Positioning + Vision + Acceleration + JumpingReach + Strength) / BallPlayingDefenderAttributes;
            }
        }

        [Display(Name = "Central Defender")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double CentralDefender
        {
            get
            {
                double CentralDefenderAttributes = 12;
                double Sum = 0;
                return Sum = (Heading + Marking + Tackling + Aggression + Anticipation + Bravery + Concentration + Decisions +
                    Determination + Positioning + JumpingReach + Strength) / CentralDefenderAttributes;
            }
        }

        [Display(Name = "Limited Central Defender")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double LimitedCentralDefender
        {
            get
            {
                double LimitedCentralDefender = 7;
                double Sum = 0;
                return Sum = (Heading + Marking + Tackling + Determination + Positioning + JumpingReach + Strength) / LimitedCentralDefender;
            }
        }

        [Display(Name = "Complete Wingback")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double CompleteWingBack
        {
            get
            {
                double LimitedCentralDefenderAttributes = 21;
                double Sum = 0;
                return Sum = (Crossing + Dribbling + FirstTouch+ + Marking + Passing + Tackling + Technique + 
                    Anticipation + Composure + Concentration + Decisions + Flair + OffTheBall + Positioning + Teamwork + WorkRate +
                    Acceleration + Agility + Balance + Pace + Stamina) / LimitedCentralDefenderAttributes;
            }
        }
        [Display(Name = "Fullback Defend")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double FullBackDefend
        {
            get
            {
                double FullBackDefendAttributes = 8;
                double Sum = 0;
                return Sum = (Marking + Tackling +
                    Anticipation  + Concentration + Positioning + Teamwork +
                    Acceleration + Stamina) / FullBackDefendAttributes;
            }
        }

        [Display(Name = "Fullback Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double FullBackSuport
        {
            get
            {
                double FullBackSuportAttributes = 11;
                double Sum = 0;
                return Sum = (Crossing + Marking + Passing + Tackling +
                    Anticipation + Concentration + Positioning + Teamwork + WorkRate +
                    Acceleration + Stamina) / FullBackSuportAttributes;
            }
        }

        [Display(Name = "Fullback Attack")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double FullBackAttack
        {
            get
            {
                double FullBackAttackAttributes = 14;
                double Sum = 0;
                return Sum = (Crossing + Dribbling + FirstTouch + Marking + Tackling +
                    Anticipation + Concentration + OffTheBall + Positioning + Teamwork + WorkRate +
                    Acceleration + Pace + Stamina) / FullBackAttackAttributes;
            }
        }

        [Display(Name = "Limited Fulback")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double LimitedFullBack
        {
            get
            {
                double LimitedFullBackAttributes = 8;
                double Sum = 0;
                return Sum = (Marking + Tackling +
                    Anticipation + Concentration + Decisions + Positioning + Teamwork + 
                    Stamina) / LimitedFullBackAttributes;
            }
        }

        [Display(Name = "Anchorman Defend")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AnchorManDefend
        {
            get
            {
                double AnchorManDefendAttributes = 11;
                double Sum = 0;
                return Sum = (Heading + Marking + Passing + Tackling +
                    Anticipation + Composure + Concentration + Decisions + Determination + Positioning +
                    Strength) / AnchorManDefendAttributes;
            }
        }

        [Display(Name = "Ballwinning Midfielder")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double BallWinningMidfielder
        {
            get
            {
                double BallWinningMidfielderAttributes = 12;
                double Sum = 0;
                return Sum = (Marking + Tackling +
                    Aggression + Bravery + Determination + Positioning + Teamwork + WorkRate +
                    Acceleration + Stamina + Strength) / BallWinningMidfielderAttributes;
            }
        }

        [Display(Name = "Box to Box Midfielder Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double BoxToBoxMidfielderSupport
        {
            get
            {
                double BoxToBoxMidfielderSupportAttributes = 19;
                double Sum = 0;
                return Sum = (Finishing + FirstTouch + LongShots + Passing + Tackling +
                    Anticipation + Bravery + Composure + Concentration + Decisions + Determination + OffTheBall + Positioning + WorkRate +
                    Acceleration + Balance + NatuaralFitnes + Stamina + Strength) / BoxToBoxMidfielderSupportAttributes;
            }
        }

        [Display(Name = "Deeplying Playmaker Defender")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double DeepLyingPlaymakerDefender
        {
            get
            {
                double DeepLyingPlaymakerDefenderAttributes = 9;
                double Sum = 0;
                return Sum = (FirstTouch + Passing + Technique +
                    Composure + Decisions + Positioning + Teamwork + Vision +
                    Balance) / DeepLyingPlaymakerDefenderAttributes;
            }
        }

        [Display(Name = "Deeplying Playmaker Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double DeepLyingPlaymakerSupport
        {
            get
            {
                double DeepLyingPlaymakerSupportAttributes = 10;
                double Sum = 0;
                return Sum = (FirstTouch + LongShots + Passing + Technique +
                    Composure + Decisions + OffTheBall + Teamwork + Vision +
                    Balance) / DeepLyingPlaymakerSupportAttributes;
            }
        }

        [Display(Name = "Advanced Playmaker Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AdvancedPlaymakerSupport
        {
            get
            {
                double AdvancedPlaymakerSupportAttributes = 8;
                double Sum = 0;
                return Sum = (FirstTouch + Passing + Technique +
                    Composure + Decisions + Flair + Teamwork + Vision) / AdvancedPlaymakerSupportAttributes;
            }
        }

        [Display(Name = "Advanced Playmaker Attack")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AdvancedPlaymakerAttack
        {
            get
            {
                double AdvancedPlaymakerAttackAttributes = 11;
                double Sum = 0;
                return Sum = (Dribbling + FirstTouch + Passing + Technique +
                    Anticipation + Composure + Decisions + Flair + OffTheBall + Teamwork + Vision) / AdvancedPlaymakerAttackAttributes;
            }
        }

        [Display(Name = "Attacking Midfielder Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AttackingMidfielderSupport
        {
            get
            {
                double AttackingMidfielderSupportAttributes = 11;
                double Sum = 0;
                return Sum = (FirstTouch + LongShots + Passing + Technique +
                    Anticipation + Composure + Decisions + OffTheBall +  Positioning + Teamwork + Vision
                    ) / AttackingMidfielderSupportAttributes;
            }
        }

        [Display(Name = "Attacking Midfielder Attack")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AttackingMidfielderAttack
        {
            get
            {
                double AttackingMidfielderAttackAttributes = 12;
                double Sum = 0;
                return Sum = (Finishing + FirstTouch + LongShots + Passing + Technique +
                    Anticipation + Composure + Concentration + Decisions + OffTheBall + Teamwork + Vision
                    ) / AttackingMidfielderAttackAttributes;
            }
        }

        [Display(Name = "Winger Support")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double WingerSupport
        {
            get
            {
                double WingerSupportAttributes = 9;
                double Sum = 0;
                return Sum = (Crossing + Dribbling + FirstTouch + Passing + Technique +
                    WorkRate +
                    Acceleration + Pace + Stamina) / WingerSupportAttributes;
            }
        }

        [Display(Name = "Winger Attack")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double WingerAttack
        {
            get
            {
                double WingerAttackAttributes = 11;
                double Sum = 0;
                return Sum = (Crossing + Dribbling + FirstTouch + Passing + Technique +
                    Flair + OffTheBall + WorkRate +
                    Acceleration + Pace + Stamina) / WingerAttackAttributes;
            }
        }

        [Display(Name = "Poacher")]
        [DisplayFormat(DataFormatString = "{0:N}")]
        public double PoacherAttributes
        {
            get
            {
                double PoacherAttributes = 8;
                double Sum = 0;
                return Sum = (Finishing + FirstTouch + Anticipation + Composure + Concentration + OffTheBall + Acceleration + Agility) / PoacherAttributes;
            }
        }
        //public IEnumerable<SelectListItem> Positions { get; set; }
        public class SearchViewModel
        {
            public bool checkbox { get; set; }
            public bool checkbox1 { get; set; }
            public bool checkbox2 { get; set; }
        }
    }
    
    

    public class LeikmadurDBContext : DbContext
    {
        public DbSet<Leikmadur> Leikmenn { get; set; }
    }
}