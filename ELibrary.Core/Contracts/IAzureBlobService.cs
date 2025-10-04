using Azure;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace ELibrary.Core.Contracts
{
    public interface IAzureBlobService
    {
        public string BlobContainerUrl { get; }

        /// <summary>
        /// Uploading a file to Azure Blob Storage
        /// </summary>
        Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName);

        /// <summary>
        /// Asynchronously retrieves a list of blob items from the storage container.
        /// </summary>
        /// <remarks>This method performs an asynchronous operation to fetch all blobs from the storage
        /// container.  The caller is responsible for awaiting the returned task to ensure the operation
        /// completes.</remarks>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of  <see
        /// cref="BlobItem"/> objects representing the blobs in the container. If no blobs are found,  the list will be
        /// empty.</returns>
        Task<List<BlobItem>> GetBlobsAsync();

        /// <summary>
        /// Deleting a file from Azure Blob Storage
        /// </summary>
        Task<Response<bool>> DeleteAsync(string blobName);

        Task<Stream> OpenReadAsync(string fileName);
    }
}
