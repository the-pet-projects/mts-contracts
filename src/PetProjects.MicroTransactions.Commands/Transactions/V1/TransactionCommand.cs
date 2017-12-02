namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionCommand : IMessage
    {
        public Guid AggregateId { get; set; }

        public string GetPartitionKey() => $"{this.AggregateId}";
    }
}