using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode,
            string boletoNumber,
            DateTime paiDate,
            DateTime expiredDate,
            decimal total,
            string totalPaid,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}