using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class PageData
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }
}