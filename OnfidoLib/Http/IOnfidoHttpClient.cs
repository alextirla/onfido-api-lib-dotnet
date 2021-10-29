using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OnfidoLib.Http
{
    public interface IOnfidoHttpClient
    {
        HttpResponseMessage Get(Uri uri);

        HttpResponseMessage Post(Uri uri, HttpContent payload);
    }
}
