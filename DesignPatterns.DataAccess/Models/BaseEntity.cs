using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DataAccess.Models
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime Creared { get; set; }
        public DateTime Modified { get; set; }
        public long CrearedBy { get; set; }
        public long ModifiedBy { get; set; }
    }
}
