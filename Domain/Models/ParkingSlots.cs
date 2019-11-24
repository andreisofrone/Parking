using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class ParkingSlots
    {
        public ParkingSlots()
        {
            Reservations = new HashSet<Reservations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsResevable { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}
