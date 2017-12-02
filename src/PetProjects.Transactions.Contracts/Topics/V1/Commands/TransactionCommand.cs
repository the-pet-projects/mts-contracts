namespace PetProjects.Transactions.Contracts.Topics.V1.Commands
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionCommand : IMessage
    {
        public Guid AggregateId { get; set; }

        public string GetPartitionKey() => $"{this.AggregateId}";
    }
}