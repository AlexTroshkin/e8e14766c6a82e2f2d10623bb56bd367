using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на получение блока по BlockNumber
    /// </summary>
    public class GetBlockByNumberRequest : ITronRequest
    {
        /// <summary>
        /// Номер блока
        /// </summary>
        [JsonProperty("num")]
        public long BlockNumber { get; set; }
    }
}