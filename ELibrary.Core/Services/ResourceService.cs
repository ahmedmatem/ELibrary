using AutoMapper;
using AutoMapper.QueryableExtensions;
using ELibrary.Core.Contracts;
using ELibrary.Core.DTOs;
using ELibrary.Infrastructure.Data.Models;
using ELibrary.Infrastructure.Data.Repository;

namespace ELibrary.Core.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IMapper _mapper;
        private readonly IRepository _repository;

        public ResourceService(IMapper mapper, IRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        /// <inheritdoc/>
        public async Task AddAsync(ResourceDto resourceDto)
        {
            // Map DTO -> Entity
            var resource = _mapper.Map<Resource>(resourceDto);
            // Generate random Guid for Id
            resource.Id = Guid.NewGuid().ToString();

            // Save entity in repository
            await _repository.AddAsync(resource);
        }

        /// <inheritdoc/>
        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IQueryable<ResourceDto> GetAll()
        {
            return _repository.AllReadonly<Resource>()
                .ProjectTo<ResourceDto>(_mapper.ConfigurationProvider);
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
