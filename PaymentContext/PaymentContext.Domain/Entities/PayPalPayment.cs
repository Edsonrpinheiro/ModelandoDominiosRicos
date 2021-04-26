using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string lastTransactionNumber, 
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
            LastTransactionNumber = lastTransactionNumber;
        }

        public string LastTransactionNumber { get; private set; }
    }
}