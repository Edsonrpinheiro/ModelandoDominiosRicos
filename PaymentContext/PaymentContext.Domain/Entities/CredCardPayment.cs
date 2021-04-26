using System;

namespace PaymentContext.Domain.Entities {
    public class CredCardPayment : Payment
    {
        public CredCardPayment(string cardHolderName, 
            string cardNumer, 
            string lastTransactionNumber, 
            DateTime paiDate, 
            DateTime expiredDate,
            decimal total, 
            string totalPaid, 
            string payer, 
            string document, 
            string address, 
            string email) : base(
                paiDate, 
                expiredDate, 
                total, 
                totalPaid, 
                payer, 
                document, 
                address, 
                email)
        {
            CardHolderName = cardHolderName;
            CardNumer = cardNumer;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumer { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}