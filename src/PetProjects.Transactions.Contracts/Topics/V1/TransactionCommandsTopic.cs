namespace PetProjects.Transactions.Contracts.Topics.V1
{
    using Framework.Kafka.Contracts.Topics;
    using PetProjects.Transactions.Contracts.Topics.V1.Commands;

    public class TransactionCommandsTopic : ITopic<TransactionCommands>
    {
        public string TopicFullName => this.SetTopicName().TopicFullName;

        public TopicBuilder SetTopicName()
        {
            return new TopicBuilder("transaction", MessageType.Commands)
                .WithApplication("transactions-api");
        }
    }
}