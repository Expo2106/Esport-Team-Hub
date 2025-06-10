using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    public enum TransferStatus
    {
        LISTED,
        PENDING,
        ACCEPTED,
        REJECTED,
        COMPLETED,
        WITHDRAWN

    }
    internal class Transfermarket
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OfferingTeamID { get; set; } //What is with the Players, who are free Agent????
        public decimal RequestedValue { get; set; }
        public TransferStatus TransferStatus { get; set; }
        public DateTime ListingDate { get; set; }
        public string Description { get; set; }

        public Transfermarket()
        {
            ListingDate = DateTime.UtcNow.Date; //Does this work too?

        }

        public Transfermarket(int id, int userID, int offeringTeamID, decimal requestedValue, TransferStatus transferStatus, DateTime listingDate, string description)
        {
            ID = id;
            UserID = userID;
            OfferingTeamID = offeringTeamID;
            RequestedValue = requestedValue;
            TransferStatus = transferStatus;
            ListingDate = listingDate;
            Description = description;

        }


    }
}
