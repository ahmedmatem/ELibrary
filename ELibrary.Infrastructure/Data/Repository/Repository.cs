using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace ELibrary.Infrastructure.Data.Repository
{
    /// <summary>
    /// Generic repository implementation of <see cref="IRepository"/> 
    /// that uses Entity Framework Core to perform CRUD operations.
    /// </summary>
    /// <remarks>
    /// This repository centralizes data access operations (querying, adding, 
    /// updating, deleting, and saving changes) for all entity types in the 
    /// application. It relies on <see cref="DbContext"/> to interact with 
    /// the underlying database.
    /// </remarks>
    public class Repository : IRepository
    {
        private readonly DbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class
        /// using the specified application database context.
        /// </summary>
        /// <param name="_context">The application's database context.</param>
        public Repository(ApplicationDbContext _context)
        {
            context = _context;
        }

        /// <summary>
        /// Returns the <see cref="DbSet{TEntity}"/> for the specified entity type.
        /// </summary>
        private DbSet<T> DbSet<T>() where T : class => context.Set<T>();

        /// <inheritdoc/>
        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        /// <inheritdoc/>
        public IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class
        {
            return this.DbSet<T>().Where(search);
        }

        /// <inheritdoc/>
        public IQueryable<T> AllReadonly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        /// <inheritdoc/>
        public IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class
        {
            return this.DbSet<T>()
                .Where(search)
                .AsNoTracking();
        }

        /// <inheritdoc/>
        public async Task AddAsync<T>(T entity) where T : class
        {
            await context.AddAsync<T>(entity);
        }

        /// <inheritdoc/>
        public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            await DbSet<T>().AddRangeAsync(entities);
        }

        /// <inheritdoc/>
        public void Update<T>(T entity) where T : class
        {
            this.DbSet<T>().Update(entity);
        }

        /// <inheritdoc/>
        public void UpdateRange<T>(IEnumerable<T> entities) where T : class
        {
            this.DbSet<T>().UpdateRange(entities);
        }

        /// <inheritdoc/>
        public async Task DeleteAsync<T>(object id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);
            if (entity != null)
            {
                Delete<T>(entity);
            }
        }

        /// <inheritdoc/>
        public void Delete<T>(T entity) where T : class
        {
            EntityEntry entry = context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.DbSet<T>().Attach(entity);
            }

            entry.State = EntityState.Deleted;
        }

        public void DeleteRange<T>(IEnumerable<T> entities) where T : class
        {
            this.DbSet<T>().RemoveRange(entities);
        }

        public void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class
        {
            var entities = All<T>(deleteWhereClause);
            DeleteRange(entities);
        }

        /// <summary>
        /// Detaches given entity from the context
        /// </summary>
        /// <param name="entity">Entity to be detached</param>
        public void Detach<T>(T entity) where T : class
        {
            EntityEntry entry = context.Entry(entity);

            entry.State = EntityState.Detached;
        }

        /// <summary>
        /// Disposing the context when it is not neede
        /// Don't have to call this method explicitely
        /// Leave it to the IoC container
        /// </summary>
        public void Dispose()
        {
            context.Dispose();
        }

        /// <summary>
        /// Saves all made changes in trasaction
        /// </summary>
        /// <returns>Error code</returns>
        public async Task<int> SaveChangesAsync<T>() where T : class
        {
            return await context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets specific record from database by primary key
        /// </summary>
        /// <param name="id">record identificator</param>
        /// <returns>Single record</returns>
        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public async Task<T?> GetByIdAsync<T>(object[] id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }
    }
}
