using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Результат TriggerSmartContract
    /// </summary>
    public class TriggerSmartContractResult
    {
        /// <summary>
        /// Успешен ли вызов
        /// </summary>
        [JsonProperty("result")]
        public bool IsSuccess { get; set; }
    }
}