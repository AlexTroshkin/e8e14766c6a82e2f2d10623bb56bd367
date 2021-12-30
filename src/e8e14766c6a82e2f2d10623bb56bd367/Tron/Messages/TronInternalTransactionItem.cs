using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Внутренняя транзакция
    /// </summary>
    public class TronInternalTransactionItem
    {
        /// <summary>
        /// Адрес контракта который сгенерировал эту internal transaction
        /// </summary>
        [JsonProperty("caller_address")]
        public string? CallerAddress { get; set; }
        
        /// <summary>
        /// Записка к транзакции (тип)
        /// </summary>
        [JsonProperty("note")]
        public string? RawNote { get; set; }
        
        /// <summary>
        /// Адрес To у internal transaction
        /// </summary>
        [JsonProperty("transferTo_address")]
        public string? TransferToAddress { get; set; }
        
        /// <summary>
        /// Уникальный hash у internal transaction
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Информация о amount internal transaction
        /// </summary>
        [JsonProperty("callValueInfo")]
        private IEnumerable<TronInternalTransactionCallValueItem> _callValueInfo = new List<TronInternalTransactionCallValueItem>();

        /// <summary>
        /// Записка к транзакции (тип)
        /// </summary>
        [JsonIgnore]
        public TronInternalTransactionNote Note =>
            RawNote switch
            {
                "637265617465" => TronInternalTransactionNote.Create,
                "63616c6c" => TronInternalTransactionNote.Call,
                "73756963696465" => TronInternalTransactionNote.Suicide,
                _ => TronInternalTransactionNote.Unknown
            };

        /// <summary>
        /// Информация о amount internal transaction
        /// </summary>
        [JsonIgnore]
        public IEnumerable<TronInternalTransactionCallValueItem> CallValueInfo =>
            _callValueInfo?.Where(x => x.CallValue > 0)
            ?? new List<TronInternalTransactionCallValueItem>();
    }
}