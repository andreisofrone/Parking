using System;
using System.Collections.Generic;

namespace Infrastructure.Models
{
    public partial class UserRolles
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }

        public virtual Rolles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
