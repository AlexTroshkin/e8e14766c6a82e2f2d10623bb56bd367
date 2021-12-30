using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на деплой смарт-контракта
    /// </summary>
    public class DeployContractResponse : TronTransaction, ITronResponse
    {
        /// <summary>
        /// Указывает находятся ли переданные адреса в формате base58
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }
        
        /// <summary>
        /// Адрес созданного смарт-контракта
        /// </summary>
        [JsonProperty("contract_address")]
        public string? ContractAddress { get; set; }

        /// <summary>
        /// Ошибка от API Tron
        /// </summary>
        [JsonProperty("Error")]
        public string? Error { get; set; }
    }
}