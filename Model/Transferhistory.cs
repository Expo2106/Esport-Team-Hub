using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    internal class Transferhistory
    {
        public int Id { get; set; }
        public int ListingID { get; set; } //Unique ??
        public int UserID { get; set; }
        public int FromTeamID { get; set; }
        public int ToTeamID { get; set; }
        public decimal TransferFee { get; set; }
        public DateTime TransferDate { get; set; }

        public Transferhistory()
        {
            TransferDate = DateTime.UtcNow.Date;
        }

        public Transferhistory(int id, int listingID, int userID, int fromTeam,  int toTeam, decimal transferFee, DateTime transferDate)
        {
            Id = id;
            ListingID = listingID;
            UserID = userID;
            FromTeamID = fromTeam;
            ToTeamID = toTeam;
            TransferFee = transferFee;
            TransferDate = transferDate;
        }
    }
}
