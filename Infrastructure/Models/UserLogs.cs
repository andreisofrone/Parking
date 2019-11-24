using System;
using System.Collections.Generic;

namespace Infrastructure.Models
{
    public partial class UserLogs
    {
        public int IdUser { get; set; }
        public bool? IsBlocked { get; set; }
        public string Reason { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateCompletion { get; set; }
        public int Id { get; set; }

        public virtual Users IdUserNavigation { get; set; }
    }
}
