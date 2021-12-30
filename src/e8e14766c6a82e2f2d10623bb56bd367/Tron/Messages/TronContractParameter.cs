using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Представляет собой данные вызванного контракта в процессе исполнения транзакции
    /// </summary>
    public class TronContractParameter
    {
        /// <summary>
        /// Значение параметра
        /// </summary>
        [JsonProperty("value")]
        public object? RawValue { get; set; }
        
        /// <summary>
        /// Ссылка на схему
        /// </summary>
        [JsonProperty("type_url")]
        public string? SchemeUrl { get; set; }

        /// <summary>
        /// Значение Value в случае если это TransferContract
        /// </summary>
        [JsonIgnore]
        public TronTransferContractParameterValue? TransferContractValue => SafeCastValue<TronTransferContractParameterValue>();

        /// <summary>
        /// Значение Value в случае если это TriggerSmartContract
        /// </summary>
        [JsonIgnore]
        public TronTriggerSmartContractParameterValue? TriggerSmartContractValue => SafeCastValue<TronTriggerSmartContractParameterValue>();
        
        private T? SafeCastValue<T>() where T : class
        {
            try
            {
                if (RawValue is JObject rawValueJObject)
                {
                    return rawValueJObject.ToObject<T?>();
                }

                return null;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}