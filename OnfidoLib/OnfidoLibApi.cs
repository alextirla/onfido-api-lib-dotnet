using OnfidoLib.Http;
using OnfidoLib.Resources;

namespace OnfidoLib
{
    public class OnfidoLibApi
    {
        public Applicants Applicants { get; set; }

        public Documents Documents { get; set; }

        public LivePhotos LivePhotos { get; set; }

        public Checks Checks { get; set; }

        public Reports Reports { get; set; }

        public OnfidoLibApi(string apiToken, string apiVersion, string apiUrl) :this(new Requestor())
        {
            Settings.SetApiToken(apiToken, apiVersion, apiUrl);
        }

        public OnfidoLibApi(IRequestor requestor)
        {
            Applicants = new Applicants(requestor);

            Documents = new Documents(requestor);

            LivePhotos = new LivePhotos(requestor);

            Checks = new Checks(requestor);

            Reports = new Reports(requestor);
        }
    }
}
