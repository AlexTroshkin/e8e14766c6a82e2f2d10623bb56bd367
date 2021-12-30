using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    public class GetTransactionInfoByBlockNumberRequest : ITronRequest
    {
        /// <summary>
        /// Номер блока
        /// </summary>
        [JsonProperty("num")]
        public long BlockNumber { get; set; }
    }
}