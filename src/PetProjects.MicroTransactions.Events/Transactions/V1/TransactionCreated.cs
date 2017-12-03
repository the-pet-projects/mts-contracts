namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using System;
    using Framework.Kafka.Contracts.Utils;

    public class TransactionCreated : TransactionEvent
    {
        public TransactionCreated(Guid transactionId, Guid userId, DateTime dateTime)
            : base(userId, dateTime)
        {
            this.TransactionId = transactionId;
        }

        public TransactionCreated(Guid transactionId, Guid userId, Timestamp timestamp)
            : base(userId, timestamp)
        {
            this.TransactionId = transactionId;
        }

        public TransactionCreated(Guid transactionId, Guid userId)
            : base(userId)
        {
            this.TransactionId = transactionId;
        }

        public Guid TransactionId { get; set; }
    }
}