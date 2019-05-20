using DesignPatterns.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DataAccess.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
