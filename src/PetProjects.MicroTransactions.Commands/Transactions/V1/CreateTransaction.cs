namespace PetProjects.MicroTransactions.Commands.Transactions.V1
{
    using System;

    public class CreateTransaction : TransactionCommand
    {
        public Guid TransactionId { get; set; }

        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}