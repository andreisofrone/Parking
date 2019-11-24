using System;
using System.Collections.Generic;

namespace Infrastructure.Models
{
    public partial class Reservations
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? UserId { get; set; }
        public int? ParkingSlotId { get; set; }
        public DateTime? DateCompletion { get; set; }

        public virtual ParkingSlots ParkingSlot { get; set; }
        public virtual Users User { get; set; }
    }
}
