namespace e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages
{
    /// <summary>
    /// Тип исполняемого в транзакции контракта TRON 
    /// </summary>
    public enum TronContractType
    {
        Unknown = 0,
        TrxTransfer = 1,
        TriggerSmartContract = 2
    }
}