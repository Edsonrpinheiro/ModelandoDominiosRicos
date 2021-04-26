using System;

namespace PaymentContext.Domain.Entities {
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, 
            string boletoNumber, 
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}