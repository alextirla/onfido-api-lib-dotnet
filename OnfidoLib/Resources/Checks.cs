using Newtonsoft.Json;
using OnfidoLib.Entities;
using OnfidoLib.Http;
using OnfidoLib.Utilities;
using System.Collections.Generic;
using System.Net.Http;

namespace OnfidoLib.Resources
{
    public class Checks : OnfidoResource
    {
        private readonly IRequestor _requestor;

        public Checks() : this(new Requestor())
        {
        }

        public Checks(IRequestor requestor)
        {
            _requestor = requestor;
        }

        public Check Create(string applicantId, IEnumerable<ReportsType> reports)
        {
            List<string> reportsList = new List<string>();
            foreach (ReportsType report in reports)
            {
                reportsList.Add(EnumHelper.GetDescription(report));
            }

            var payload = SerializeEntity(new Check() { ApplicantId = applicantId, ReportNames = reportsList } );

            //using (MultipartFormDataContent formData = new MultipartFormDataContent())
            //{
               

            //    formData.Add(new StringContent(applicantId), "applicant_id");
            //    formData.Add(new StringContent(JsonConvert.SerializeObject(reportsList.ToArray())), "report_names");

                return _requestor.Post<Check>("checks", payload);
            //}
        }
    }
}
