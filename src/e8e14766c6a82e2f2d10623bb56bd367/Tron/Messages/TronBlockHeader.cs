using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Заголовок блока
    /// </summary>
    public class TronBlockHeader
    {
        /// <summary>
        /// Подробная информация
        /// </summary>
        [JsonProperty("raw_data")]
        public TronBlockHeaderInfo? Info { get; set; }
        
        /// <summary>
        /// Подпись свидетеля (майнера?) (?)
        /// </summary>
        [JsonProperty("witness_signature")]
        public string? WitnessSignature { get; set; }
    }
}