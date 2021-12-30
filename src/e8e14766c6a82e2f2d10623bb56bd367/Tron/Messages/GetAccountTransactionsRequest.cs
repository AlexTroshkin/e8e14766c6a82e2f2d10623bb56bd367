namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Запрос на получение транзакций по адресу (аккаунту)
    /// Доступно только в прод сети
    /// </summary>
    public class GetAccountTransactionsRequest : ITronRequest, ITronQueryParamMessage
    {
        /// <summary>
        /// Адрес по которому мы хотим получить транзакции
        /// </summary>
        public string? Account { get; set; }

        ///// <summary>
        ///// Вернуть только подтвержденные транзакции
        ///// </summary>
        //[FormElement("only_confirmed")]
        //public bool? OnlyConfirmed { get; set; }
        //public bool ShouldSeriazeOnlyConfirmed => OnlyConfirmed.HasValue;

        ///// <summary>
        ///// Вернуть только неподтвержденные транзакции
        ///// </summary>
        //[FormElement("only_unconfirmed")]
        //public bool? OnlyUnconfirmed { get; set; }
        //public bool ShouldSerializeOnlyUnconfirmed => OnlyUnconfirmed.HasValue;

        ///// <summary>
        ///// Вернуть транзакции только к этому адресу
        ///// </summary>
        //[FormElement("only_to")]
        //public bool? OnlyTo { get; set; }
        //public bool ShouldSerializeOnlyTo => OnlyTo.HasValue;

        ///// <summary>
        ///// Вернуть транзакции только от этого адреса
        ///// </summary>
        //[FormElement("only_from")]
        //public bool? OnlyFrom { get; set; }
        //public bool ShouldSerializeOnlyFrom => OnlyFrom.HasValue;

        ///// <summary>
        ///// Количество транзакций на страницу
        ///// </summary>
        //[FormElement("limit")]
        //public int? Limit { get; set; }
        //public bool ShouldSerializeLimit => Limit.HasValue;

        ///// <summary>
        ///// Fingerprint c предыдущей страницы
        ///// Используется при запросе следующей страницы
        ///// Параметры должны быть идентичны
        ///// </summary>
        //[FormElement("fingerprint")]
        //public string Fingerprint { get; set; }
        //public bool ShouldSerializeFingerprint => Fingerprint != null;

        ///// <summary>
        ///// Сортировать по
        ///// block_timestamp,asc | block_timestamp,desc 
        ///// </summary>
        //[FormElement("order_by")]
        //public string OrderBy { get; set; }
        //public bool ShouldSerializeOrderBy => OrderBy != null;

        ///// <summary>
        ///// Минимальный timestamp блока
        ///// </summary>
        //[FormElement("min_timestamp")]
        //public long? MinTimestamp { get; set; }
        //public bool ShouldSerializeMinTimestamp => MinTimestamp.HasValue;

        ///// <summary>
        ///// Максимальный timestamp блока
        ///// </summary>
        //[FormElement("max_timestamp")]
        //public long? MaxTimestamp { get; set; }
        //public bool ShouldSerializeMaxTimestamp => MaxTimestamp.HasValue;

        ///// <summary>
        ///// Вернуть нормальные и внутренние транзакции
        ///// false - возвращаются только нормальные
        ///// </summary>
        //[FormElement("search_internal")]
        //public bool? SearchInternal { get; set; }
        //public bool ShouldSerializeSearchInternal => SearchInternal.HasValue;
    }
}