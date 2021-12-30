using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Параметры TriggerSmartContract в TRON
    /// </summary>
    public class TronTriggerSmartContractParameterValue
    {
        /// <summary>
        /// HEX-адрес вызывающего контракта (41...)
        /// </summary>
        [JsonProperty("owner_address")]
        public string? From { get; set; }
        
        /// <summary>
        /// HEX-адрес вызываемого контракта (41...)
        /// </summary>
        [JsonProperty("contract_address")]
        public string? ContractAddress { get; set; }
        
        /// <summary>
        /// abi-encoded параметры с которыми был вызван контракт (HEX)
        /// </summary>
        [JsonProperty("data")]
        public string? Data { get; set; }
        
        /// <summary>
        /// Сколько SUN было передано в смарт-контракт при вызове
        /// </summary>
        [JsonProperty("call_value")]
        public long CallValue { get; set; }
    }
}