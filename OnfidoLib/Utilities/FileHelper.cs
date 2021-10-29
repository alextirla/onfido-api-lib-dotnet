using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OnfidoLib.Utilities
{
    public static class FileHelper
    {
        public static StreamContent CreateFileContent(Stream stream, string fileName, string contentType)
        {
            var fileContent = new StreamContent(stream);

            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "file",
                FileName = fileName
            };
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);

            return fileContent;
        }
    }
}
