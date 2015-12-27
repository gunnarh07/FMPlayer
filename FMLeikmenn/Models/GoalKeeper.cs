using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FMLeikmenn.Models
{
    public class GoalKeeper
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TeamPlayerContractedTo { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Scouting")]
        public DateTime DateStamp { get; set; }        
        public string Position { get; set; }
        public int AerialAbility { get; set; }
        public int CommanOfArea { get; set; }
        public int Communication { get; set; }
        public int Eccentricity { get; set; }
        public int FirstTouch { get; set; }
        public int FreeKickTaking { get; set; }
        public int Handling { get; set; }
        public int Kicking { get; set; }
        public int OneOnOne { get; set; }
        public int PeanaltyTacking { get; set; }
        public int Reflexes { get; set; }
        public int RushingOut { get; set; }
        public int TendencyToPunch { get; set; }
        public int Throwing { get; set; }
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
        public int NaturalFitnesss { get; set; }
        public int Pace { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Technique { get; set; }
        public int OutfieldRating { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public double AverageGoalKeeperRating
        {
            get
            {
                double AllAttributes = 37;
                double Sum = 0;

                return Sum = (AerialAbility + CommanOfArea + Communication + Eccentricity + FirstTouch + FreeKickTaking + Handling + Kicking + OneOnOne + PeanaltyTacking + Reflexes + RushingOut + Technique + TendencyToPunch + Throwing + 
                    Aggression + Anticipation + Bravery + Composure + Concentration + Decisions + Determination + Flair + Leadership + OffTheBall + Positioning + Teamwork + Vision + WorkRate +
                    Acceleration + Agility + Balance + JumpingReach + NaturalFitnesss + Pace + Stamina + Strength) / AllAttributes;
            }
        }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public double GKDefend
        {
            get
            {
                double AllAttributes = 13;
                double Sum = 0;

                return Sum = (AerialAbility + CommanOfArea + Communication + FirstTouch + Handling + Kicking + OneOnOne + Reflexes + Throwing +
                    Anticipation + Decisions + Positioning +
                    Agility) / AllAttributes;
            }
        }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public double SGKDefend
        {
            get
            {
                double AllAttributes = 14;
                double Sum = 0;

                return Sum = (AerialAbility + CommanOfArea + FirstTouch + Handling + Kicking + OneOnOne + Reflexes + Throwing +
                    Anticipation + Composure + Concentration + Decisions + Positioning +
                    Agility) / AllAttributes;
            }
        }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public double SGKSupport
        {
            get
            {
                double AllAttributes = 15;
                double Sum = 0;

                return Sum = (AerialAbility + CommanOfArea + FirstTouch + Handling + Kicking + OneOnOne + Reflexes + RushingOut + Throwing +
                    Anticipation + Composure + Concentration + Decisions + Positioning +
                    Acceleration + Agility) / AllAttributes;
            }
        }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public double SGKAttac
        {
            get
            {
                double AllAttributes = 16;
                double Sum = 0;

                return Sum = (AerialAbility + CommanOfArea + Communication + FirstTouch + Handling + Kicking + OneOnOne + Reflexes + RushingOut + Throwing +
                    Anticipation + Composure + Concentration + Decisions + Positioning +
                    Acceleration + Agility) / AllAttributes;
            }
        }

    }
    public class GoalKeeperDBContext : DbContext
    {
        public DbSet<GoalKeeper> GoalKeepers { get; set; }
    }
}