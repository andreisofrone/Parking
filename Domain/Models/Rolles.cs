using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Rolles
    {
        public Rolles()
        {
            UserRolles = new HashSet<UserRolles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserRolles> UserRolles { get; set; }
    }
}
