using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на вызов метода смарт-контракта (возвращает неподписанную транзакцию)
    /// </summary>
    public class TriggerSmartContractRequest : ITronRequest
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
        /// Сколько максимум разрешено сжечь TRX за транзакцию (в SUN)
        /// </summary>
        [JsonProperty("fee_limit")]
        public long? FeeLimit { get; set; } = 100000000;

        /// <summary>
        /// Сколько средств нужно отправить на смарт-контракт (в SUN)
        /// </summary>
        [JsonProperty("call_value")] 
        public long? TransferAmount { get; set; } = 0;
        
        /// <summary>
        /// Для мульти подписи
        /// </summary>
        [JsonProperty("permission_id")]
        public long? PermissionId { get; set; }

        /// <summary>
        /// Переданные адреса находятся в base58 формате
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }
    }
}