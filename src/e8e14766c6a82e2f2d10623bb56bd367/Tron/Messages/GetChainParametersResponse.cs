using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    public class GetChainParametersResponse : TronResponseBase
    {
        [JsonProperty("chainParameter")]
        public IEnumerable<TronChainParameter>? ChainParameters { get; set; }
    }
}