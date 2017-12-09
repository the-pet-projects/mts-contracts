namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using System;

    public class CreateTransaction : TransactionCommand
    {
        public CreateTransaction(Guid transactionId, Guid itemId, int quantity, Guid userId) 
            : base(userId)
        {
            this.TransactionId = transactionId;
            this.ItemId = itemId;
            this.Quantity = quantity;
        }

        public Guid TransactionId { get; set; }

        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}