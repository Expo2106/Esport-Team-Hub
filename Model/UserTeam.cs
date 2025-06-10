using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    internal class UserTeam
    {
        public int UserID { get; set; }
        public int TeamID { get; set; }
        public DateTime JoinedAt { get; set; }

        public UserTeam ()
        {
            JoinedAt = DateTime.Now;
        }

        public UserTeam (int userID, int teamID, DateTime joinedAt)
        {
            UserID = userID;
            TeamID = teamID;
            JoinedAt = joinedAt;
        }
    }
}
