using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string lastTransactionNumber,
            DateTime paiDate,
            DateTime expiredDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) : base(
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