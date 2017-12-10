namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionCommandsTopicV1 : TopicBase<TransactionCommandV1>
    {
        private const int Version = 1;

        public TransactionCommandsTopicV1(string environment)
            : base(new TopicConfig(new Transaction().Name, MessageType.Commands, new TransactionsApi().Name, environment, Version))
        {
        }
    }
}