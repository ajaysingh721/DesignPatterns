using DesignPatterns.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DataAccess.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>
    {
        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
