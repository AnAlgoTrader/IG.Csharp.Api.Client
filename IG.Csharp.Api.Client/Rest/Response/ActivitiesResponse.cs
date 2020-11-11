using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class ActivitiesResponse
    {
        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }
    }
}