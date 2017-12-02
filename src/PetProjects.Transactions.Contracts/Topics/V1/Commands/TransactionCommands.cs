namespace PetProjects.Transactions.Contracts.Topics.V1.Commands
{
    using System;
    using Framework.Kafka.Contracts.Topics;

    public class TransactionCommands : IMessage
    {
        public Guid AggregateId { get; set; }

        public string GetPartitionKey() => $"{this.AggregateId}";
    }
}