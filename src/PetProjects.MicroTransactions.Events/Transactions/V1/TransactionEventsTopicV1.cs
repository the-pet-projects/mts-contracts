namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionEventsTopicV1 : TopicBase<TransactionEventV1>
    {
        private const int Version = 1;

        public TransactionEventsTopicV1(string environment)
            : base(new TopicConfig(new Transaction().Name, MessageType.Events, new TransactionsApi().Name, environment, Version))
        {
        }
    }
}