using System.Collections.Generic;
using OnfidoLib.Entities;
using OnfidoLib.Http;
using OnfidoLib.Resources.InternalEntities;

namespace OnfidoLib.Resources
{
    public class Reports
    {
        private IRequestor _requestor;

        public Reports() : this(new Requestor())
        {
        }

        public Reports(IRequestor requestor)
        {
            _requestor = requestor;
        }

        public Report Find(string checkId, string reportId)
        {
            const string pathFormat = "checks/{0}/reports/{1}";

            return _requestor.Get<Report>(string.Format(pathFormat, checkId, reportId));           
        }

        public IEnumerable<Report> All(string checkId)
        {
            const string pathFormat = "checks/{0}/reports";

            var reports = _requestor.Get<ReportsResponse>(string.Format(pathFormat, checkId));

            return reports.reports;
        }
    }
}
