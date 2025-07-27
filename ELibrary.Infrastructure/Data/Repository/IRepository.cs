using System.Linq.Expressions;

namespace ELibrary.Infrastructure.Data.Repository
{
    /// <summary>
    /// Defines a generic repository pattern interface for performing 
    /// data access operations on entities within a data store.
    ///
    /// This interface abstracts common CRUD (Create, Read, Update, Delete)
    /// operations and provides both tracked and untracked querying options 
    /// for any entity class. It is typically used in combination with an 
    /// ORM (e.g., Entity Framework) to enforce a consistent data access 
    /// approach throughout an application.
    ///
    /// Key features:
    /// - Retrieve all or filtered records, with or without tracking.
    /// - Add, update, and delete entities or collections of entities.
    /// - Retrieve entities by their primary key.
    /// - Detach entities from the current context.
    /// - Save pending changes as a single transaction.
    /// 
    /// Methods in this interface are generic and constrained to classes,
    /// ensuring type safety and flexibility across different domain models.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// All records in a table
        /// </summary>
        /// <returns>Queryable expression tree</returns>
        IQueryable<T> All<T>() where T : class;

        /// <summary>
        /// All records in a table
        /// </summary>
        /// <returns>Queryable expression tree</returns>
        IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class;

        /// <summary>
        /// The result collection won't be tracked by the context
        /// </summary>
        /// <returns>Expression tree</returns>
        IQueryable<T> AllReadonly<T>() where T : class;

        /// <summary>
        /// The result collection won't be tracked by the context
        /// </summary>
        /// <returns>Expression tree</returns>
        IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// Updates a record in database
        /// </summary>
        /// <param name="entity">Entity for record to be updated</param>
        void Update<T>(T entity) where T : class;

        /// <summary>
        /// Updates set of records in the database
        /// </summary>
        /// <param name="entities">Enumerable collection of entities to be updated</param>
        void UpdateRange<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// Deletes a record from database
        /// </summary>
        /// <param name="id">Identificator of record to be deleted</param>
        Task DeleteAsync<T>(object id) where T : class;

        /// <summary>
        /// Deletes a record from database
        /// </summary>
        /// <param name="entity">Entity representing record to be deleted</param>
        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(IEnumerable<T> entities) where T : class;

        void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class;

        /// <summary>
        /// Gets specific record from database by primary key
        /// </summary>
        /// <param name="id">record identificator</param>
        /// <returns>Single record</returns>
        Task<T?> GetByIdAsync<T>(object id) where T : class;

        Task<T?> GetByIdAsync<T>(object[] id) where T : class;

        /// <summary>
        /// Detaches given entity from the context
        /// </summary>
        /// <param name="entity">Entity to be detached</param>
        void Detach<T>(T entity) where T : class;

        /// <summary>
        /// Saves all made changes in trasaction
        /// </summary>
        /// <returns>Error code</returns>
        Task<int> SaveChangesAsync<T>() where T : class;
    }
}
