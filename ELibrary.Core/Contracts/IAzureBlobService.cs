using Azure;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace ELibrary.Core.Contracts
{
    public interface IAzureBlobService
    {
        Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName);

        Task<Response<bool>> DeleteAsync(string blobName);
    }
}
