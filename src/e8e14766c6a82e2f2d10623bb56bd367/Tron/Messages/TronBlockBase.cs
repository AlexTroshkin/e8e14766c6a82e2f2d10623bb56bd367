using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Базовая информация о блоке в Tron
    /// </summary>
    public abstract class TronBlockBase : TronResponseBase
    {
        /// <summary>
        /// ID блока в формате 00000000000080f82038aa301eda07eb27906589dd849d1c9ba5d84af94cf038
        /// </summary>
        [JsonProperty("blockID")]
        public string? Id { get; set; }
        
        /// <summary>
        /// Header блока (информация)
        /// </summary>
        [JsonProperty("block_header")]
        public TronBlockHeader? Header { get; set; }
    }
}