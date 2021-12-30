using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на деплой смарт-контракта
    /// </summary>
    public class DeployContractRequest : ITronRequest
    {
        /// <summary>
        /// ABI смарт-контракта
        /// </summary>
        [JsonProperty("abi")]
        public string? ContractAbi { get; set; }
        
        [JsonProperty("bytecode")]
        public string? ContractByteCode { get; set; }
        
        /// <summary>
        /// Сколько максимум разрешено сжечь TRX за транзакцию (в SUN)
        /// </summary>
        [JsonProperty("fee_limit")]
        public long? FeeLimit { get; set; } = 10000000000;
        
        /// <summary>
        /// Аргументы которые нужно передать в конструктор (ABIEncoded)
        /// </summary>
        [JsonProperty("parameter", NullValueHandling = NullValueHandling.Ignore)]
        public string? ConstructorArguments { get; set; }

        /// <summary>
        /// Сколько максимум разрешено потратить Energy за транзакцию
        /// </summary>
        [JsonProperty("origin_energy_limit")]
        public long? EnergyLimit { get; set; } = 10000000;
        
        /// <summary>
        /// От кого создается смарт-контракт
        /// </summary>
        [JsonProperty("owner_address")]
        public string? FromAddress { get; set; }
        
        /// <summary>
        /// Имя смарт-контракта
        /// </summary>
        [JsonProperty("name")]
        public string? ContractName { get; set; }
        
        /// <summary>
        /// Сколько средств нужно отправить на смарт-контракт (в SUN)
        /// </summary>
        [JsonProperty("call_value")] 
        public long? TransferAmount { get; set; } = 0;

        /// <summary>
        /// The same as User Pay Ratio. The percentage of resources specified for users who use this contract. This field accepts integers between [0, 100]. If it is 0, it means the user does not consume resources until the developer resources are exhausted. However, it is strongly recommended to set the value between 1 and 99 (inclusive). This is prevent the contract developer from potential malicious infinite loop time out attacks.
        /// </summary>
        [JsonProperty("consume_user_resource_percent")]
        public long? ConsumeUserResourcePercentage { get; set; } = 0;
        
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