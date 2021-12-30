using System.Collections.Generic;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на вызов pure/view метода у смарт-контракта
    /// </summary>
    public class TriggerConstantContractResponse : TronResponseBase
    {
        /// <summary>
        /// Результат вызова смарт-контракта
        /// </summary>
        [JsonProperty("result")]
        public TriggerSmartContractResult? Result { get; set; }
        
        /// <summary>
        /// Возвращаемые значение из вызванного метода ABIEncoded
        /// </summary>
        [JsonProperty("constant_result")]
        public IEnumerable<string>? Constant { get; set; }
    }
}