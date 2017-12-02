namespace PetProjects.MicroTransactions.Events.Transactions.V1
{
    using PetProjects.Framework.Kafka.Contracts.Topics;

    public class TransactionEventsTopic : ITopic<TransactionEvent>
    {
        public string TopicFullName => this.SetTopicName().TopicFullName;

        public TopicBuilder SetTopicName()
        {
            return new TopicBuilder(new Transaction().Name, MessageType.Events)
                .WithApplication(new MicroTransactionSystem().Name);
        }
    }
}