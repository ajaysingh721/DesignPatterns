using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatterns.DataAccess.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public Collection<Employee> Employees { get; set; }
    }
}
