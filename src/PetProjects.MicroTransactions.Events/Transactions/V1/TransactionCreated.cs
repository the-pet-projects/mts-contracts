namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using System;

    public class TransactionCreated : TransactionEvent
    {
        public Guid TransactionId { get; set; }

        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}