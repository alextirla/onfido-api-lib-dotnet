using System.IO;
using System.Net.Http;
using OnfidoLib.Entities;
using OnfidoLib.Http;
using System.Text;
using OnfidoLib.Utilities;

namespace OnfidoLib.Resources
{
    public class Documents : OnfidoResource
    {
        private IRequestor _requestor;

        public Documents() : this(new Requestor())
        {
        }

        public Documents(IRequestor requestor)
        {
            _requestor = requestor;
        }

        public Document Create(string applicantId, Stream fileStream, string fileName, DocumentType type)
        {
            return Create(applicantId, fileStream, fileName, type, null);
        }

        public Document Create(string applicantId, Stream fileStream, string fileName, DocumentType type, DocumentSide? side)
        {
            var mimeType = MimeTypes.MimeTypeMap.GetMimeType(fileName);

            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent(applicantId), "applicant_id");
                formData.Add(new StringContent(EnumHelper.GetDescription(type)), "\"type\"");

                if (side != null)
                {
                    formData.Add(new StringContent(EnumHelper.GetDescription(side.Value), Encoding.UTF8), "\"side\"");
                }

                formData.Add(FileHelper.CreateFileContent(fileStream, "file", mimeType));

                return _requestor.Post<Document>("documents", formData);
            }
        }
    }
}