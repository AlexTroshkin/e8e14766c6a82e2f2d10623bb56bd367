using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Параметры TransferContract TRON
    /// </summary>
    public class TronTransferContractParameterValue
    {
        /// <summary>
        /// HEX-адрес отправителя (41...)
        /// </summary>
        [JsonProperty("owner_address")]
        public string? From { get; set; }
        
        /// <summary>
        /// HEX-адрес получателя (41...)
        /// </summary>
        /// <returns></returns>
        [JsonProperty("to_address")]
        public string? To { get; set; }
        
        /// <summary>
        /// Сумма перевода в SUN
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }
    }
}