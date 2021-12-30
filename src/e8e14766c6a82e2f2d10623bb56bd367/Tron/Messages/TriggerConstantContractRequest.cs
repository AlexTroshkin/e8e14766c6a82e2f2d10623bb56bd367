using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Вызывает pure/view метод у смарт-контракта
    /// </summary>
    public class TriggerConstantContractRequest : ITronRequest
    {
        /// <summary>
        /// Адрес вызывающего смарт-контракт
        /// </summary>
        [JsonProperty("owner_address")]
        public string? FromAddress { get; set; }
        
        /// <summary>
        /// Адрес контракта
        /// </summary>
        [JsonProperty("contract_address")]
        public string? ContractAddress { get; set; }
        
        /// <summary>
        /// Название и сигнатура вызываемого метода (формата sweep(uint256[],bytes abi))
        /// </summary>
        [JsonProperty("function_selector")]
        public string? MethodSelector { get; set; }
        
        /// <summary>
        /// Аргументы метода закодированные ABIEncoder
        /// </summary>
        [JsonProperty("parameter")]
        public string? MethodArguments { get; set; }

        /// <summary>
        /// Переданные адреса находятся в base58 формате
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }
    }
}