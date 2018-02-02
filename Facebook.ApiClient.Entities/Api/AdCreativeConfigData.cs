using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <summary>
    /// The specification for template configs, like app FB ID.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-config-data/</para>
    /// </summary>
    public class AdCreativeConfigData : BaseEntity
    {
        /// <summary>
        /// The id of the Facebook App where the deep-link information is stored
        /// </summary>
        [DeserializeAs(Name = "app_id")]
        [JsonProperty(PropertyName = "app_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppId { get; set; }
    }
}
