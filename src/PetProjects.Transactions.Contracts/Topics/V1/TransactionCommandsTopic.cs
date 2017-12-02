namespace PetProjects.Transactions.Contracts.Topics.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;
    using PetProjects.Transactions.Contracts.Topics.V1.Commands;

    public class TransactionCommandsTopic : ITopic<TransactionCommand>
    {
        public string TopicFullName => this.SetTopicName().TopicFullName;

        public TopicBuilder SetTopicName()
        {
            return new TopicBuilder(Constants.Transaction, MessageType.Commands)
                .WithApplication(Constants.MicroTransactionSystem);
        }
    }
}