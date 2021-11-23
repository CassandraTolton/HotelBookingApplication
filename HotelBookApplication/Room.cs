using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookApplication
{
    public abstract class Room
    {
        public int RoomNumber { get; set; }
        public bool Balcony {get; set;}
        public bool DownForRepair { get; set; }
        public int NumberOfBeds { get; set; }
    }
}
