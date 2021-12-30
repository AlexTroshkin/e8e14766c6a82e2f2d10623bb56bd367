using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Статус контракта TRON транзакции
    /// </summary>
    public class TronTransactionContractStatusItem
    {
        [JsonIgnore] 
        public bool IsContractCodeSuccess => ContractCode == "SUCCESS";
        
        /// <summary>
        /// Статус код смарт-контракта
        /// </summary>
        [JsonProperty("contractRet")]
        public string? ContractCode { get; set; }
    }
}