using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    public abstract class TronResponseBase : ITronResponse
    {
        /// <summary>
        /// Ошибка от API Tron
        /// </summary>
        [JsonProperty("Error")]
        public string? Error { get; set; }
    }
}