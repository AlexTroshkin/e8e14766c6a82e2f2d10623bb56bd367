using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ответ на запрос создания неподписанной транзакции
    /// </summary>
    public class CreateTransactionResponse : TronTransaction, ITronResponse
    {
        /// <summary>
        /// Указывает, находится ли переданные адреса в формате base58
        /// </summary>
        [JsonProperty("visible")]
        public bool IsBase58Addresses { get; set; }

        /// <summary>
        /// Ошибка от API Tron
        /// </summary>
        [JsonProperty("Error")]
        public string? Error { get; set; }
    }
}