using System.Collections.Generic;
using OnfidoLib.Entities;

namespace OnfidoLib.Resources.InternalEntities
{
    /* Applicants list service returns { applicants: IEnumerable<Applicant> } and I want to 
       return an IEnumerable<Applicant> to user, so created a simple class to allow quick workaround
       */
    public class ApplicantResponse
    {
        public IEnumerable<Applicant> applicants;
    }
}
