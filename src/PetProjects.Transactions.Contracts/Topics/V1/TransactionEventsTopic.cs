namespace PetProjects.Transactions.Contracts.Topics.V1
{
    using Events;
    using Framework.Kafka.Contracts.Topics;

    public class TransactionEventsTopic : ITopic<TransactionEvents>
    {
        public string TopicFullName => this.SetTopicName().TopicFullName;

        public TopicBuilder SetTopicName()
        {
            return new TopicBuilder("transaction", MessageType.Events)
                .WithApplication("transactions-api");
        }
    }
}