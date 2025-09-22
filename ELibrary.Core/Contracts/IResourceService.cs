using ELibrary.Core.DTOs;

namespace ELibrary.Core.Contracts
{
    /// <summary>
    /// Defines operations for managing resources in the virtual library.
    /// </summary>
    public interface IResourceService
    {
        /// <summary>
        /// Retrieves all resources as a queryable collection.
        /// </summary>
        /// <remarks>
        /// Use this method when you need to apply additional LINQ operations (such as filtering, sorting, or paging) 
        /// before materializing the results. The returned <see cref="IQueryable{T}"/> allows for deferred execution, 
        /// meaning that the query is not executed until it is enumerated.
        /// </remarks>
        /// <returns>
        /// An <see cref="IQueryable{T}"/> of <see cref="ResourceDto"/> objects representing all available resources. 
        /// The collection may be empty if no resources exist.
        /// </returns>
        IQueryable<ResourceDto> GetAll();

        /// <summary>
        /// Asynchronously adds a new resource based on the provided data transfer object (DTO).
        /// </summary>
        /// <remarks>The method performs the addition operation asynchronously and returns the resulting
        /// resource. Ensure that the provided <paramref name="resourceDto"/> contains all required fields for the
        /// resource.</remarks>
        /// <param name="resourceDto">The data transfer object containing the details of the resource to add. Cannot be null.</param>
        Task AddAsync(ResourceDto resourceDto);

        /// <summary>
        /// Retrieves a resource by its unique identifier.
        /// </summary>
        /// <remarks>Use this method to fetch a specific resource when its unique identifier is known. If
        /// the resource does not exist, the method returns <see langword="null"/>.</remarks>
        /// <param name="id">The unique identifier of the resource to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the resource as a <see
        /// cref="ResourceDto"/> if found; otherwise, <see langword="null"/>.</returns>
        Task<ResourceDto?> GetByIdAsync(string id);

        /// <summary>
        /// Asynchronously retrieves all resources.
        /// </summary>
        /// <remarks>The returned collection may be empty if no resources are available.</remarks>
        /// <returns>A task that represents the asynchronous operation. The task result contains an  IEnumerable{T} of
        /// ResourceDto objects representing the resources.</returns>
        Task<IEnumerable<ResourceDto>> GetAllAsync();

        /// <summary>
        /// Searches for resources that match the specified keyword.
        /// </summary>
        /// <param name="keyword">The keyword to search for. Cannot be null or empty.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of  <see
        /// cref="ResourceDto"/> objects that match the search criteria. If no matches are found,  the collection will
        /// be empty.</returns>
        Task<IEnumerable<ResourceDto>> SearchAsync(string keyword);

        /// <summary>
        /// Updates the specified resource asynchronously.
        /// </summary>
        /// <param name="resourceDto">The data transfer object representing the resource to be updated. Must not be <see langword="null"/>.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the update
        /// was successful; otherwise, <see langword="false"/>.</returns>
        Task<bool> UpdateAsync(ResourceDto resourceDto);

        /// <summary>
        /// Deletes the entity with the specified identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to delete.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is <see langword="true"/> if the entity
        /// was successfully deleted;  otherwise, <see langword="false"/>.</returns>
        Task<bool> DeleteAsync(string id);
    }
}
