using OnfidoLib.Entities;
using OnfidoLib.Http;
using OnfidoLib.Utilities;
using System.IO;
using System.Net.Http;

namespace OnfidoLib.Resources
{
    public class LivePhotos : OnfidoResource
    {
        private readonly IRequestor _requestor;

        public LivePhotos() : this(new Requestor())
        {
        }

        public LivePhotos(IRequestor requestor)
        {
            _requestor = requestor;
        }

        public LivePhoto Create(string applicantId, Stream fileStream, string fileName, bool? advancedValidation = null)
        {
            string mimeType = MimeTypes.MimeTypeMap.GetMimeType(fileName);

            using (MultipartFormDataContent formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent(applicantId), "applicant_id");

                if (advancedValidation != null)
                {
                    formData.Add(new StringContent(advancedValidation.ToString()), "\"advanced_validation\"");
                }

                formData.Add(FileHelper.CreateFileContent(fileStream, "file", mimeType));

                return _requestor.Post<LivePhoto>("live_photos", formData);
            }
        }
    }
}
