using Newtonsoft.Json;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Ресурсы аккаунта
    /// </summary>
    public class TronAccountResource
    {
        //private readonly UnixDateTimeConverter _unixDateTimeConverter = new UnixDateTimeConverter();
        
        /// <summary>
        /// Когда последний раз была получена энергия
        /// </summary>
        //[JsonIgnore]
        //public DateTime LatestConsumeTimeForEnergyAt => _unixDateTimeConverter.FromUnixTimestampMilliseconds(LatestConsumeTimeForEnergy);
        
        /// <summary>
        /// Когда последний раз была получена энергия (timestamp)
        /// </summary>
        [JsonProperty("latest_consume_time_for_energy")]
        public long LatestConsumeTimeForEnergy { get; set; }
    }
}