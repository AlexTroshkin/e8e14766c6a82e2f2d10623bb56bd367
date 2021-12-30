using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на вызов метода смарт-контракта (неподписанная транзакция)
    /// </summary>
    public class TriggerSmartContractResponse : TronResponseBase
    {
        /// <summary>
        /// Результат вызова смарт-контракта
        /// </summary>
        [JsonProperty("result")]
        public TriggerSmartContractResult? Result { get; set; }
        
        /// <summary>
        /// Указывает, находится ли переданные адреса в формате base58
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }
        
        /// <summary>
        /// Данные о транзакции
        /// </summary>
        [JsonProperty("transaction")]
        public TronTransaction? Transaction { get; set; }
    }
}