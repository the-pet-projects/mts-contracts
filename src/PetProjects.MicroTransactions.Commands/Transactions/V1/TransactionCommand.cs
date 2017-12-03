namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;
    using PetProjects.Framework.Kafka.Contracts.Utils;

    public class TransactionCommand : IMessage
    {
        public TransactionCommand(Guid userId, DateTime dateTime)
        {
            this.UserId = userId;
            this.Timestamp = new Timestamp(dateTime);
        }

        public TransactionCommand(Guid userId, Timestamp timestamp)
        {
            this.UserId = userId;
            this.Timestamp = timestamp;
        }

        public TransactionCommand(Guid userId)
        {
            this.UserId = userId;
            this.Timestamp = new Timestamp();
        }

        public Guid UserId { get; set; }

        public Timestamp Timestamp { get; set; }

        public string GetPartitionKey() => $"{this.UserId}";
    }
}