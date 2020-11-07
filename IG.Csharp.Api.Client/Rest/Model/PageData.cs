using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class PageData
    {
        [JsonProperty("pageSize")]
        public int PageSize;

        [JsonProperty("pageNumber")]
        public int PageNumber;

        [JsonProperty("totalPages")]
        public int TotalPages;
    }
}