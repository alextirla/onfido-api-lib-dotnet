using System.Collections.Generic;
using OnfidoLib.Resources.InternalEntities;
using OnfidoLib.Entities;
using OnfidoLib.Http;
using System.Collections.Specialized;
using System.Web;

namespace OnfidoLib.Resources
{
    public class Applicants : OnfidoResource
    {
        private IRequestor _requestor;

        public Applicants() : this(new Requestor())
        {
        }

        public Applicants(IRequestor requestor)
        {
            _requestor = requestor;
        }

        public Applicant Create(Applicant applicant)
        {
            var payload = SerializeEntity(applicant);

            return _requestor.Post<Applicant>("applicants", payload);
        }
    }
}