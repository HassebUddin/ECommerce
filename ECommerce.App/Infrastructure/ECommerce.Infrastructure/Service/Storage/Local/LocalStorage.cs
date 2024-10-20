
using ECommerce.Application.Abstraction.Service.Storage.Local;
using ECommerce.Application.Messages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ECommerce.Infrastructure.Service.Storage.Local
{
    public class LocalStorage:ILocalStorage
    {
        private readonly IWebHostEnvironment _environment;

        public LocalStorage(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<List<(string fileName, string path)>> UplaodFileAsync(string folderName, string[] allowedFileExtensions, IFormFileCollection files)
        {
            if (files == null)
                throw new Exception(FileUploadMessage.FileNotFound());


            //"resource/product-image"
            var fullPath = Path.Combine(_environment.WebRootPath, folderName);
            // path = "c://projects/ImageManipulation.Ap/uploads" ,not exactly, but something like that

            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);


            List<(string fileName, string path)> datas = new();
            foreach (IFormFile file in files)
            {
                // Check the allowed extenstions
                var ext = Path.GetExtension(file.FileName);
                if (!allowedFileExtensions.Contains(ext))
                    throw new Exception(FileUploadMessage.InValidExtension(allowedFileExtensions));


                // generate a unique filename
                var newFileName = await CopyFileAsync(fullPath, file);

                datas.Add((newFileName, $"{folderName}"));
            }

            return datas;
        }

        public async Task<string> CopyFileAsync(string fullPath, IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);
            var newFilename = $"{Guid.NewGuid().ToString()}{extension}";
            using var stream = new FileStream($"{fullPath}\\{newFilename}", FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, false);
            await file.CopyToAsync(stream);
            await stream.FlushAsync();
            return newFilename;
        }

        public List<string> GetFiles(string folderName)
        {
            DirectoryInfo directory = new(folderName);
            return directory.GetFiles().Select(f => f.Name).ToList();
        }

        public void DeleteFile(string folderName, string fileName)
        {
            var path = Path.Combine(_environment.WebRootPath, $"{folderName}\\{fileName}");
            if (!File.Exists(path))
                throw new Exception(FileUploadMessage.FileNotFound());

            File.Delete(path);
        }
    }
}
