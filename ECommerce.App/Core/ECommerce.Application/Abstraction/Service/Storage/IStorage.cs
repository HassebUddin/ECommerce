using Microsoft.AspNetCore.Http;

namespace ECommerce.Application.Abstraction.Service.Storage
{
    public interface IStorage
    {
        List<string> GetFiles(string folderName);
        void DeleteFile(string folderName, string fileName);
        Task<string> CopyFileAsync(string path, IFormFile file);
        Task<List<(string fileName, string path)>> UplaodFileAsync(string path, string[] allowedFileExtensionss, IFormFileCollection files);
    }
}
