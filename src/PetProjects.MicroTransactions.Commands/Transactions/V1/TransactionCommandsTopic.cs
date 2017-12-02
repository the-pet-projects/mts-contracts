namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionCommandsTopic : ITopic<TransactionCommand>
    {
        public string TopicFullName => this.SetTopicName().TopicFullName;

        public TopicBuilder SetTopicName()
        {
            return new TopicBuilder(new Transaction().Name, MessageType.Commands)
                .WithApplication(new MicroTransactionSystem().Name);
        }
    }
}