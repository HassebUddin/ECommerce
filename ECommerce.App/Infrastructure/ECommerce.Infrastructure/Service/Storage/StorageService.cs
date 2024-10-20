
using ECommerce.Application.Abstraction.Service.Storage;
using Microsoft.AspNetCore.Http;

namespace ECommerce.Infrastructure.Service.Storage
{
    public class StorageService : IStorageService
    {
        private readonly IStorage _storage;

        public string StorageName { get => _storage.GetType().Name; }


        public StorageService(IStorage storage)
         => _storage = storage;


        public async Task<List<(string fileName, string path)>> UplaodFileAsync(string folderName, string[] allowedFileExtensions, IFormFileCollection files)
                   => await _storage.UplaodFileAsync(folderName, allowedFileExtensions, files);

        public async Task<string> CopyFileAsync(string fullPath, IFormFile file)
                            => await _storage.CopyFileAsync(fullPath, file);

        public List<string> GetFiles(string folderName)
                   => _storage.GetFiles(folderName);

        public void DeleteFile(string folderName, string fileName)
                 => _storage.DeleteFile(folderName, fileName);

    }
}
