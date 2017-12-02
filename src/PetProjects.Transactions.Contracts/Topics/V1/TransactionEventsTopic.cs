namespace PetProjects.Transactions.Contracts.Topics.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;
    using PetProjects.Transactions.Contracts.Topics.V1.Events;

    public class TransactionEventsTopic : ITopic<TransactionEvent>
    {
        public string TopicFullName => this.SetTopicName().TopicFullName;

        public TopicBuilder SetTopicName()
        {
            return new TopicBuilder(Constants.Transaction, MessageType.Events)
                .WithApplication(Constants.MicroTransactionSystem);
        }
    }
}