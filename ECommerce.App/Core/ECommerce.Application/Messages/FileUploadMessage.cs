

namespace ECommerce.Application.Messages
{
    public static class FileUploadMessage
    {
        public static string FileNotFound()
            => $"File is not notfound";

        public static string InValidExtension(string[] allowedFileExtensions)
             => $"Only {string.Join(",", allowedFileExtensions)} are allowed.";
      

    }
}
