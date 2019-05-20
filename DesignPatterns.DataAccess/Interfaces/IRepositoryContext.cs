using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DataAccess.Interfaces
{
    internal interface IRepositoryContext
    {
        DbSet<T> GetDbSet<T>() where T : class;
            
        DbContext DbContext { get; }

        /// <summary>
        /// Save all changes to all repositories
        /// </summary>
        /// <returns>Integer with number of objects affected</returns>
        int SaveChanges();

        /// <summary>
        /// Save all changes to all repositories async
        /// </summary>
        /// <returns>Integer with number of object
        Task<int> SaveChangesAsync();
    }
}
