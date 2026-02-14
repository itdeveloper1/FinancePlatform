public interface ITransactionService
{
    Transaction CreateTransaction(Guid merchantId);
    void AddItem(Guid transactionId, string description, decimal amount);
    void SubmitTransaction(Guid transactionId);
    void CancelTransaction(Guid transactionId, bool isMerchant);
}
