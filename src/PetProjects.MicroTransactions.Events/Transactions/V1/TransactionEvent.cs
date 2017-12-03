namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;
    using PetProjects.Framework.Kafka.Contracts.Utils;

    public class TransactionEvent : IMessage
    {
        public TransactionEvent(Guid userId, DateTime dateTime)
        {
            this.UserId = userId;
            this.Timestamp = new Timestamp(dateTime);
        }

        public TransactionEvent(Guid userId, Timestamp timestamp)
        {
            this.UserId = userId;
            this.Timestamp = timestamp;
        }

        public TransactionEvent(Guid userId)
        {
            this.UserId = userId;
            this.Timestamp = new Timestamp();
        }

        public Guid UserId { get; set; }

        public Timestamp Timestamp { get; set; }

        public string GetPartitionKey() => $"{this.UserId}";
    }
}