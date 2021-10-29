using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnfidoLib.Utilities;
using Newtonsoft.Json;
using OnfidoLib.Errors;

namespace OnfidoLib.Resources.InternalEntities
{
    public class OnfidoExceptionResponse
    {
        [JsonProperty("error")]
        public OnfidoApiError Error;
    }
}
