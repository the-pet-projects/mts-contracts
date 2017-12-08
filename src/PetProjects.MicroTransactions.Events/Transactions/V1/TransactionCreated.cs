namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using System;
    using Framework.Kafka.Contracts.Utils;

    public class TransactionCreated : TransactionEvent
    {
        public TransactionCreated(Guid transactionId, Guid itemId, int quantity, Guid userId, DateTime dateTime)
            : base(userId, dateTime)
        {
            this.TransactionId = transactionId;
            this.ItemId = itemId;
            this.Quantity = quantity;
        }

        public TransactionCreated(Guid transactionId, Guid itemId, int quantity, Guid userId, Timestamp timestamp)
            : base(userId, timestamp)
        {
            this.TransactionId = transactionId;
            this.ItemId = itemId;
            this.Quantity = quantity;
        }

        public TransactionCreated(Guid transactionId, Guid itemId, int quantity, Guid userId)
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