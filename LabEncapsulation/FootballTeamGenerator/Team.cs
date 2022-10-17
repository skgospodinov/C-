using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string,Player> playersByNames;

        public Team(string name)
        {

            this.Name = name;
            this.playersByNames = new Dictionary<string, Player>();
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

        public double AverageRating 
        {
            get  
            {
                if (this.playersByNames.Count == 0)
                {
                    return 0;
                }
                return Math.Round(this.playersByNames.Values.Average(p => p.AverageSkillLevel));
            }
        }
        public void AddPlayer(Player player) 
        {
            
            this.playersByNames.Add(player.Name,player);
        }

        public void RemovePlayer(string playerName) 
        {
            if(!this.playersByNames.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
            this.playersByNames.Remove(playerName);
        }
    }
}
