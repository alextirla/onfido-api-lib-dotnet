using Newtonsoft.Json;

namespace OnfidoLib.Resources
{
    public abstract class OnfidoResource
    {
        protected string SerializeEntity(object toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
