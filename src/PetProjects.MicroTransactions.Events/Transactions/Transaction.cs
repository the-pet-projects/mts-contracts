namespace PetProjects.MicroTransactions.Events.Transactions
{
    public class Transaction
    {
        public Transaction()
        {
            this.Name = "transaction";
        }

        public string Name { get; }
    }
}