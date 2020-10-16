using IG.Csharp.Api.Client.Rest.Model;
using System.Collections.Generic;

namespace IG.Csharp.Api.Client.Rest.Response
{
    public class PositionsResponse
    {
        ///<Summary>
        ///List of positions
        ///</Summary>
        public List<OpenPosition> positions { get; set; }
    }
}
