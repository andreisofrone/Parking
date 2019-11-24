using System;
using System.Collections.Generic;

namespace Infrastructure.Models
{
    public partial class Users
    {
        public Users()
        {
            Reservations = new HashSet<Reservations>();
            UserLogs = new HashSet<UserLogs>();
            UserRolles = new HashSet<UserRolles>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RefreshToken { get; set; }
        public bool? IsBlocked { get; set; }
        public string CarNumber { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual ICollection<UserLogs> UserLogs { get; set; }
        public virtual ICollection<UserRolles> UserRolles { get; set; }
    }
}
