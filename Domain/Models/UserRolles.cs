using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class UserRolles
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }

        public virtual Rolles Role { get; set; }
        public virtual User User { get; set; }
    }
}
