using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    
    public enum Status
    {
        ACTIVE,
        INACTIVE,
        BENCHED,
        SUBSTITUDE,
        FREEAGENT
    }
    internal class UserRole
    {
        public int Id {  get; set; }   
        public Role Role { get; set; }
        public Status Status { get; set; }
        public DateTime RoleAddedAt { get; set; }
        public DateTime LastUpdatedAt {  get; set; }

        public UserRole()
        {
            RoleAddedAt = DateTime.Now;
            LastUpdatedAt = DateTime.Now;
        }

        public UserRole(int id, Role role, Status status, DateTime roleAddedAt, DateTime lastUpdatedAt) 
        {
            Id = id;
            Role = role;
            Status = status;
            RoleAddedAt = roleAddedAt;
            LastUpdatedAt = lastUpdatedAt;
        }
    }
}
