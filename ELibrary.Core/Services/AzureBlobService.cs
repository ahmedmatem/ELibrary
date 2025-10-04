using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using ELibrary.Core.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace ELibrary.Core.Services
{
    public class AzureBlobService : IAzureBlobService
    {
        public string BlobContainerUrl { get; set; }

        private readonly BlobServiceClient blobServiceClient;
        private readonly BlobContainerClient blobContainerClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureBlobService"/> class, configuring it to interact with an
        /// Azure Blob Storage container.
        /// </summary>
        /// <remarks>This constructor retrieves the container URL and container name from the
        /// application's configuration settings. Ensure that the "AzureBlobStorage:ContainerURL" and
        /// "AzureBlobStorage:ContainerName" keys are properly configured in the application's configuration file (e.g.,
        /// appsettings.json or secrets.json).</remarks>
        /// <param name="client">The <see cref="BlobServiceClient"/> used to interact with the Azure Blob Storage service.</param>
        /// <param name="configuration">The application configuration object used to retrieve Azure Blob Storage settings.</param>
        /// <exception cref="ArgumentNullException">Thrown if the "AzureBlobStorage:ContainerURL" or "AzureBlobStorage:ContainerName" configuration values are
        /// not provided.</exception>
        public AzureBlobService(BlobServiceClient client, IConfiguration configuration)
        {
            BlobContainerUrl = configuration.GetValue<string>("AzureBlobStorage:ContainerURL")
                ?? throw new ArgumentNullException("AzureBlobStorage:ContainerURL is not configured in appsettings.json or in secrets.json");
            string containerName = configuration.GetValue<string>("AzureBlobStorage:ContainerName")
                ?? throw new ArgumentNullException("AzureBlobStorage: ContainerName is not configured in appsettings.json or in secrets.json");

            blobContainerClient = client.GetBlobContainerClient(containerName);
        }

        /// <inheritdoc/>
        public async Task<Response<BlobContentInfo>> UploadFileAsync(IFormFile file, string blobName)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                memoryStream.Position = 0;
                return await blobContainerClient.UploadBlobAsync(blobName, memoryStream, default);
            }
        }

        /// <inheritdoc/>
        public async Task<List<BlobItem>> GetBlobsAsync()
        {
            var items = new List<BlobItem>();
            var uploadedFiles = blobContainerClient.GetBlobsAsync();
            await foreach (BlobItem file in uploadedFiles)
            {
                 items.Add(file);
            }

            return items;
        }

        /// <inheritdoc/>
        public async Task<Response<bool>> DeleteAsync(string blobName)
        {
            return await blobContainerClient
                .DeleteBlobIfExistsAsync(blobName, DeleteSnapshotsOption.IncludeSnapshots);
        }

        /// <summary>
        /// Opens a read-only, seekable stream for the specified blob in the configured container.
        /// </summary>
        /// <param name="fileName">
        /// The blob name (optionally including virtual folders), e.g. <c>"docs/algebra.pdf"</c>.
        /// </param>
        /// <returns>
        /// A <see cref="System.IO.Stream"/> positioned at the start of the blob if it exists; otherwise <c>null</c>.
        /// The caller is responsible for disposing the returned stream.
        /// </returns>
        /// <remarks>
        /// The stream is created with <c>AllowModifications = false</c> to ensure a consistent read.
        /// Because the stream supports seeking and HTTP range requests, it is suitable for returning from
        /// ASP.NET Core using <c>File(stream, "application/pdf", enableRangeProcessing: true)</c> for
        /// efficient, partial loading of large files.
        /// </remarks>
        /// <exception cref="Azure.RequestFailedException">
        /// Thrown if the underlying Storage request fails.
        /// </exception>
        public async Task<Stream> OpenReadAsync(string fileName)
        {
            var blob = blobContainerClient.GetBlobClient(fileName);
            if(!await blob.ExistsAsync())
            {
                return null;
            }

            return await blob.OpenReadAsync(new BlobOpenReadOptions(false));
        }
    }
}
