using DesignPatterns.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DataAccess.Helpers
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            new Employee()
            {
                FirstName = "Ajay",
                LastName = "Singh"
            };
        }
    }
}
