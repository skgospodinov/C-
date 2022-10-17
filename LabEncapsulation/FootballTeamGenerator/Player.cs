using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int MinStats = 0;
        private const int MaxStats = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name 
        {
            get => this.name;
            set 
            {
                Validator.ThrowIfStringIsNullOrWhiteSapce(value, GlobalConstants.InvalidNameExeptionName);
                this.name = value;
            }
        }
        public int Endurance 
        {
            get => this.endurance;
            private set 
            {
                Validator.IfIsValidRange(MinStats, MaxStats, value, $"Endurance should be between 0 and 100.");
                this.endurance = value;
            } 
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                Validator.IfIsValidRange(MinStats, MaxStats, value, $"Sprint should be between 0 and 100.");
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                Validator.IfIsValidRange(MinStats, MaxStats, value, $"Dribble should be between 0 and 100.");
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                Validator.IfIsValidRange(MinStats, MaxStats, value, $"Passing should be between 0 and 100.");
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                Validator.IfIsValidRange(MinStats, MaxStats, value, $"Shooting should be between 0 and 100.");
                this.shooting = value;
            }
        }
        public double AverageSkillLevel => Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);
    }
}
