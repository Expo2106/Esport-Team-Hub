using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    public enum Platform
    {
        PC, PlayStation, Xbox
    }
    internal class Player
    {
        public int Id { get; set; }
        public Platform Platform { get; set; }
        
        public Player (int id, Platform platform)
        {
            Id = id;
            Platform = platform;
        }
    }
}
