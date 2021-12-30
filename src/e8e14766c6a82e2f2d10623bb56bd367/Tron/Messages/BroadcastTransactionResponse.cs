using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос отправки транзакции в сеть
    /// </summary>
    public class BroadcastTransactionResponse : TronResponseBase
    {
        /// <summary>
        /// Отправлена ли транзакция в сеть
        /// </summary>
        [JsonProperty("result")]
        public bool IsBroadcasted { get; set; }
        
        /// <summary>
        /// Сообщение об ошибке при отправке транзакции
        /// </summary>
        [JsonProperty("message")]
        public string? ErrorMessage { get; set; }
        
        /// <summary>
        /// Код ошибки при отправке транзакции
        /// </summary>
        [JsonProperty("code")]
        public string? ErrorCode { get; set; }
    }
}