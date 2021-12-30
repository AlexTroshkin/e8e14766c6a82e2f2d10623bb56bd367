using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Представляет собой вызванный контракт в процессе исполнения транзакции
    /// </summary>
    public class TronContractItem
    {
        /// <summary>
        /// Данные
        /// </summary>
        [JsonProperty("parameter")]
        public TronContractParameter? Parameter { get; set; }
        
        /// <summary>
        /// Тип контракта (к примеру TransferContract)
        /// </summary>
        [JsonProperty("type")]
        public string? RawType { get; set; }

        /// <summary>
        /// Тип контракта
        /// </summary>
        [JsonIgnore]
        public TronContractType Type =>
            RawType switch
            {
                "TransferContract" => TronContractType.TrxTransfer,
                "TriggerSmartContract" => TronContractType.TriggerSmartContract,
                _ => TronContractType.Unknown
            };
    }
}