using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    public enum MatchFormat
    {
        Bo3, Bo5, Bo7
    }

    public enum MatchStatus
    {
        SCHEDULED, LIVE, COMPLETED, POSTPONED, CANCELLED
    }
    internal class Matches
    {
        public int Id {  get; set; }
        public string CompName { get; set; }
        public DateTime MatchDate { get; set; }
        public MatchFormat MatchFormat { get; set; }
        public int Team1ID { get; set; } 
        public int Team2ID { get; set; }
        public int ScoreTeam1 {  get; set; }
        public int ScoreTeam2 { get; set; }
        public MatchStatus MatchStatus { get; set; }//NOT NULL DEFAULT ("Scheduled")
        public string VodURL { get; set; }

        public Matches(int id, string compName, DateTime matchDate, MatchFormat matchFormat, int team1ID, int team2ID, int scoreTeam1, int scoreTeam2, MatchStatus matchStatus, string vodURL)
        {
            Id = id;
            CompName = compName;
            MatchDate = matchDate;
            MatchFormat = matchFormat;
            Team1ID = team1ID;
            Team2ID = team2ID;
            ScoreTeam1 = scoreTeam1;
            ScoreTeam2 = scoreTeam2;
            MatchStatus = matchStatus;
            VodURL = vodURL;

        }


    }
}
