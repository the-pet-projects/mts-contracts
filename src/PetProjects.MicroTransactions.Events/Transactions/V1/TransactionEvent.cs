﻿namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using System;
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionEvent : IMessage
    {
        public Guid AggregateId { get; set; }

        public string GetPartitionKey() => $"{this.AggregateId}";
    }
}