

using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using ECommerce.Application.Abstraction.Service.Storage.Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Infrastructure.Service.Storage.Azure
{
    public class AzureStorage:IAzureStorage
    {
        private readonly BlobServiceClient _blobServiceClient;
        BlobContainerClient _blobContainerClient;

        public AzureStorage(IConfiguration configuration)
        {
            _blobServiceClient = new(configuration["Azure:Storage"]);
        }

        public Task<string> CopyFileAsync(string path, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(string folderName, string fileName)
        {
            this._blobContainerClient = _blobServiceClient.GetBlobContainerClient(folderName);
            BlobClient blobClient = this._blobContainerClient.GetBlobClient(fileName);
            blobClient.Delete();

        }

        public List<string> GetFiles(string folderName)
        {
            this._blobContainerClient = _blobServiceClient.GetBlobContainerClient(folderName);
            return this._blobContainerClient.GetBlobs().Select(x => x.Name).ToList();

        }

        public async Task<List<(string fileName, string path)>> UplaodFileAsync(string path, string[] allowedFileExtensionss, IFormFileCollection files)
        {
            this._blobContainerClient = _blobServiceClient.GetBlobContainerClient(path);
            await this._blobContainerClient.CreateIfNotExistsAsync(); ;
            await this._blobContainerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

            List<(string fileName, string path)> datas = new();
            foreach (IFormFile item in files)
            {
                BlobClient blobClient = this._blobContainerClient.GetBlobClient(item.Name);
                datas.Add((item.Name, path));

            }
            return datas;

        }
    }
}
