namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionCommandsTopicV1 : TopicBase<TransactionCommandV1>
    {
        private const int Version = 1;

        private readonly string environment;

        public TransactionCommandsTopicV1(string environment)
        {
            this.environment = environment;
        }
        
        public override TopicBuilder SetupTopicBuilder()
        {
            return new TopicBuilder(new TopicConfig(new Transaction().Name, MessageType.Commands, new TransactionsApi().Name, this.environment, Version));
        }
    }
}