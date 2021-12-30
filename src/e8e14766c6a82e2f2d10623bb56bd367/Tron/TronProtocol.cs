using e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron
{
    public class TronProtocol
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UriProvider _uriProvider;
        
        public TronProtocol(IHttpClientFactory httpClientFactory, string tronGridUri, string fullNodeUri)
        {
            _httpClientFactory = httpClientFactory;
            _uriProvider = new UriProvider(tronGridUri, fullNodeUri);
        }

        /// <summary>
        /// Получение аккаунта
        /// </summary>
        public Task<GetAccountResponse> SendAsync(GetAccountRequest request)
        {
            return PostAsync<GetAccountRequest, GetAccountResponse>(_uriProvider.GetAccountUri, request);
        }

        /// <summary>
        /// Создание транзакции (без публикации в сеть)
        /// </summary>
        public Task<CreateTransactionResponse> SendAsync(CreateTransactionRequest request)
        {
            return PostAsync<CreateTransactionRequest, CreateTransactionResponse>(_uriProvider.CreateTransactionUri, request);
        }

        /// <summary>
        /// Получение общей информации транзакции по ID
        /// </summary>
        public Task<GetTransactionInfoByIdResponse> SendAsync(GetTransactionInfoByIdRequest request)
        {
            return PostAsync<GetTransactionInfoByIdRequest, GetTransactionInfoByIdResponse>(_uriProvider.GetTransactionInfoByIdUri, request);
        }

        /// <summary>
        /// Получение полной информации о транзакции по ID
        /// </summary>
        public Task<GetTransactionByIdResponse> SendAsync(GetTransactionByIdRequest request)
        {
            return PostAsync<GetTransactionByIdRequest, GetTransactionByIdResponse>(_uriProvider.GetTransactionByIdUri, request);
        }

        /// <summary>
        /// Валидация адреса
        /// </summary>
        public Task<ValidateAddressResponse> SendAsync(ValidateAddressRequest request)
        {
            return PostAsync<ValidateAddressRequest, ValidateAddressResponse>(_uriProvider.ValidateAddressUri, request);
        }

        /// <summary>
        /// Публикация подписанной транзакции в сеть
        /// </summary>
        public Task<BroadcastTransactionResponse> SendAsync(BroadcastTransactionRequest request)
        {
            return PostAsync<BroadcastTransactionRequest, BroadcastTransactionResponse>(_uriProvider.BroadcastTransactionUri, request);
        }

        /// <summary>
        /// Получение текущего блока
        /// </summary>
        public Task<GetNowBlockResponse> SendAsync(GetNowBlockRequest request)
        {
            return PostAsync<GetNowBlockRequest, GetNowBlockResponse>(_uriProvider.GetNowBlockUri, request);
        }

        /// <summary>
        /// Вызов метода у смарт-контракта
        /// </summary>
        public Task<TriggerSmartContractResponse> SendAsync(TriggerSmartContractRequest request)
        {
            return PostAsync<TriggerSmartContractRequest, TriggerSmartContractResponse>(_uriProvider.TriggerSmartContract, request);
        }

        /// <summary>
        /// Вызов pure/view метода у смарт-контракта
        /// </summary>
        public Task<TriggerConstantContractResponse> SendAsync(TriggerConstantContractRequest request)
        {
            return PostAsync<TriggerConstantContractRequest, TriggerConstantContractResponse>(_uriProvider.TriggerConstantContract, request);
        }

        /// <summary>
        /// Деплой смарт-контракта
        /// </summary>
        public Task<DeployContractResponse> SendAsync(DeployContractRequest request)
        {
            return PostAsync<DeployContractRequest, DeployContractResponse>(_uriProvider.DeployContract, request);
        }

        /// <summary>
        /// Получение всех параметров, которые может установить блокчейн-комитет
        /// </summary>
        public Task<GetChainParametersResponse> SendAsync(GetChainParametersRequest request)
        {
            return PostAsync<GetChainParametersRequest, GetChainParametersResponse>(_uriProvider.GetChainParameters, request);
        }

        /// <summary>
        /// Получение блока по номеру
        /// </summary>
        public Task<GetBlockByNumberResponse> SendAsync(GetBlockByNumberRequest request)
        {
            return PostAsync<GetBlockByNumberRequest, GetBlockByNumberResponse>(_uriProvider.GetBlockByNumber, request);
        }

        /// <summary>
        /// Получение транзакций по номеру блока
        /// </summary>
        public async Task<IEnumerable<TronTransactionExtendedItem>> SendAsync(GetTransactionInfoByBlockNumberRequest request)
        {
            var rawResponse = await PostRawAsync(_uriProvider.GetTransactionInfoByBlockNumber, request);

            var response = JsonConvert.DeserializeObject<IEnumerable<TronTransactionExtendedItem>>(rawResponse, new JsonSerializerSettings
            {
                Error = (e, args) =>
                {
                    args.ErrorContext.Handled = true;
                }
            });

            return response ?? new List<TronTransactionExtendedItem>();
        }

        public Task<GetAccountBalanceResponse> SendAsync(GetAccountBalanceRequest request)
        {
            return PostAsync<GetAccountBalanceRequest, GetAccountBalanceResponse>(_uriProvider.GetAccountBalance, request);
        }

        /// <summary>
        /// Получение транзакций по аккаунту (адресу)
        /// </summary>
        public Task<GetAccountTransactionsResponse> SendAsync(GetAccountTransactionsRequest request)
        {
            return GetAsync<GetAccountTransactionsRequest, GetAccountTransactionsResponse>(_uriProvider.GetAccountTransactionsUri(request.Account), request);
        }

        private async Task<TResponse> GetAsync<TRequest, TResponse>(string uri, TRequest request)
            where TRequest : ITronQueryParamMessage
            where TResponse : ITronResponse
        {
            var queryParams = MessageConverter.ConvertToText(request);
            var http = _httpClientFactory.CreateClient("tron-http-client");
            var response = await http.GetStringAsync($"{uri}?{queryParams}");

            return MessageConverter.ConvertToMessage<TResponse>(response)!;
        }

        private async Task<TResponse> PostAsync<TRequest, TResponse>(string uri, TRequest request)
            where TRequest : ITronRequest
            where TResponse : ITronResponse
        {
            var response = await PostRawAsync(uri, request);
            return MessageConverter.ConvertToMessage<TResponse>(response)!;
        }

        private async Task<string> PostRawAsync<TRequest>(string uri, TRequest request) where TRequest : ITronRequest
        {
            var requestBody = MessageConverter.ConvertToText(request);
            var http = _httpClientFactory.CreateClient("tron-http-client");

            var content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");
            var resposne = await http.PostAsync(uri, content);

            resposne.EnsureSuccessStatusCode();

            return await resposne.Content.ReadAsStringAsync();
        }
    }
}
