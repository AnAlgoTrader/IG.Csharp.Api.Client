using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class Allowance
    {
        [JsonProperty("remainingAllowance")]
        public int RemainingAllowance { get; set; }

        [JsonProperty("totalAllowance")]
        public int TotalAllowance { get; set; }

        [JsonProperty("allowanceExpiry")]
        public int AllowanceExpiry { get; set; }
    }
}