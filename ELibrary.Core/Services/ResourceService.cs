using ELibrary.Core.Contracts;
using ELibrary.Core.DTOs;

namespace ELibrary.Core.Services
{
    public class ResourceService : IResourceService
    {
        /// <inheritdoc/>
        public Task<ResourceDto> AddAsync(ResourceDto resourceDto)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<IEnumerable<ResourceDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ResourceDto?> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<IEnumerable<ResourceDto>> SearchAsync(string keyword)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<bool> UpdateAsync(ResourceDto resourceDto)
        {
            throw new NotImplementedException();
        }
    }
}
