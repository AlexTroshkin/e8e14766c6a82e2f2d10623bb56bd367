using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Данные страницы с транзакциями от аккаунта
    /// </summary>
    public class TronTransactionsPageInfo
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// Когда была запрошена страница
        /// </summary>
        [JsonIgnore]
        //public DateTime ReceivedAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(At);
        
        /// <summary>
        /// Когда была запрошена страница (timestamp)
        /// </summary>
        [JsonProperty("at")]
        public long At { get; set; }
        
        /// <summary>
        /// Количество элементов на странице
        /// </summary>
        [JsonProperty("page_size")]
        public int Size { get; set; }
        
        /// <summary>
        /// Отпечаток полученной страницы
        /// Можно использовать для получения следующей
        /// </summary>
        [JsonProperty("fingerprint")]
        public string? Fingerprint { get; set; }
        
        /// <summary>
        /// Ссылки текущей страницы
        /// </summary>
        [JsonProperty("links")]
        public TronTransactionPageInfoLinks? Links { get; set; }
    }
}