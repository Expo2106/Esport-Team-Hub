using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    public enum Region
    {
        EU, NA, OCE, SAM, MENA, APAC, SSA
    }
    internal class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string TeamTag { get; set; }
        public Region Region { get; set; }
        public string Description { get; set; }
        public string LogoURL { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Team()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Team(int id, string teamName, string teamTag, Region region, string description, string logoURL, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            TeamName = teamName;
            TeamTag = teamTag;
            Region = region;
            Description = description;
            LogoURL = logoURL;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

    }
}
