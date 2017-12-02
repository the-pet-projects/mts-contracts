namespace PetProjects.Transactions.Contracts.Topics.V1.Events
{
    using System;
    using Framework.Kafka.Contracts.Topics;

    public class TransactionEvents : IMessage
    {
        public Guid AggregateId { get; set; }

        public string GetPartitionKey() => $"{this.AggregateId}";
    }
}