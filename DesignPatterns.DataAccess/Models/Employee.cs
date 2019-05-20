using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DataAccess.Models
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
    }
}
