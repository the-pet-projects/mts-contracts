namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionEventsTopicV1 : TopicBase<TransactionEventV1>
    {
        private const int Version = 1;

        private readonly string environment;

        public TransactionEventsTopicV1(string environment)
        {
            this.environment = environment;
        }
        
        public override TopicBuilder SetupTopicBuilder()
        {
            return new TopicBuilder(new TopicConfig(new Transaction().Name, MessageType.Events, new TransactionsApi().Name, this.environment, Version));
        }
    }
}