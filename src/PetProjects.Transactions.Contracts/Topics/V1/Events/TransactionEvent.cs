namespace PetProjects.Transactions.Contracts.Topics.V1.Events
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionEvent : IMessage
    {
        public Guid AggregateId { get; set; }

        public string GetPartitionKey() => $"{this.AggregateId}";
    }
}