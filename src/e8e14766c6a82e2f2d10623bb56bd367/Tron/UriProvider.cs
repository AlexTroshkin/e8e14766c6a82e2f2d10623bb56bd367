namespace e8e14766c6a82e2f2d10623bb56bd367.Tron
{
    public class UriProvider
    {
        private readonly string tronGridUri;
        private readonly string fullNodeUri;

        public UriProvider(string tronGridUri, string fullNodeUri)
        {
            this.tronGridUri = tronGridUri;
            this.fullNodeUri = fullNodeUri;
        }

        /// <summary>
        /// Получение аккаунта
        /// </summary>
        public string GetAccountUri => WithFullNodeUri("getaccount");

        /// <summary>
        /// Создание транзакции (без публикации в сеть)
        /// </summary>
        public string CreateTransactionUri => WithFullNodeUri("createtransaction");

        /// <summary>
        /// Получение общей информации транзакции по ID
        /// </summary>
        public string GetTransactionInfoByIdUri => WithFullNodeUri("gettransactioninfobyid");

        /// <summary>
        /// Получение полной информации о транзакции по ID
        /// </summary>
        public string GetTransactionByIdUri => WithFullNodeUri("gettransactionbyid");

        /// <summary>
        /// Валидация адреса
        /// </summary>
        public string ValidateAddressUri => WithFullNodeUri("validateaddress");

        /// <summary>
        /// Публикация подписанной транзакции в сеть
        /// </summary>
        public string BroadcastTransactionUri => WithFullNodeUri("broadcasttransaction");

        /// <summary>
        /// Получение текущего блока
        /// </summary>
        public string GetNowBlockUri => WithFullNodeUri("getnowblock");

        /// <summary>
        /// Вызов метода у смарт-контракта
        /// </summary>
        public string TriggerSmartContract => WithFullNodeUri("triggersmartcontract");

        /// <summary>
        /// Вызов pure/view метода у смарт-контракта
        /// </summary>
        public string TriggerConstantContract => WithFullNodeUri("triggerconstantcontract");

        /// <summary>
        /// Деплой смарт-контракта
        /// </summary>
        public string DeployContract => WithFullNodeUri("deploycontract");

        /// <summary>
        /// Получение всех параметров, которые может установить блокчейн-комитет
        /// </summary>
        public string GetChainParameters => WithFullNodeUri("getchainparameters");

        /// <summary>
        /// Получение блока по номеру
        /// </summary>
        public string GetBlockByNumber => WithFullNodeUri("getblockbynum");

        /// <summary>
        /// Получение транзакций по номеру блока
        /// </summary>
        public string GetTransactionInfoByBlockNumber => WithFullNodeUri("gettransactioninfobyblocknum");

        /// <summary>
        /// Получение баланса по адресу и блоку
        /// </summary>
        public string GetAccountBalance => WithFullNodeUri("getaccountbalance");

        /// <summary>
        /// Получение транзакций по аккаунту (адресу)
        /// </summary>
        /// <param name="account">Адрес аккаунта</param>
        /// <returns>URI</returns>
        public string GetAccountTransactionsUri(string account)
        {
            return $"{tronGridUri}/v1/accounts/{account}/transactions";
        }

        private string WithFullNodeUri(string segment)
        {
            var baseUri = fullNodeUri.TrimEnd('/');
            segment = segment.TrimStart('/');

            return $"{baseUri}/{segment}";
        }
    }
}
