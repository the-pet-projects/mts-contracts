namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;
    using PetProjects.Framework.Kafka.Contracts.Utils;

    public class TransactionEventV1 : IMessage
    {
        public Guid UserId { get; set; }

        public Timestamp Timestamp { get; set; } = new Timestamp();

        public string GetPartitionKey() => $"{this.UserId}";
    }
}