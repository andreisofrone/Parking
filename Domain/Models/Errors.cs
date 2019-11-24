using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Errors
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
    }
}
