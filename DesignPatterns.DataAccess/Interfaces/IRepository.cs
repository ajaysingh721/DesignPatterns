using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Get a selected extiry by the object primary key
        /// </summary>
        /// <param name="Id">Primary key ID</param>
        T GetSingle(long id);

        /// <summary>
        /// Get all the element of this repository
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary> 
        /// Add entity to the repository 
        /// </summary> 
        /// <param name="entity">the entity to add</param> 
        void Add(T entity);

        /// <summary> 
        /// Mark entity to be deleted within the repository 
        /// </summary> 
        /// <param name="entity">The entity to delete</param> 
        void Delete(T entity);

        /// <summary> 
        /// Updates entity within the the repository 
        /// </summary> 
        /// <param name="entity">the entity to update</param>
        void Update(T entity);

        /// <summary> 
        /// Query entities from the repository that match the linq expression selection criteria
        /// </summary> 
        /// <returns>the loaded entity</returns> 
        IQueryable<T> GetQueryable();
    }
}
