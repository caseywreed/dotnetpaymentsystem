using System;

namespace ConsoleApplication
{
    // :Payment gives CreditCardPayment access to everything in the Payment class
    public class CreditCardPayment:Payment
    {
        public string CreditCardNumber {get;set;}
        public override string MakePayment()
        {
            string message = string.Empty;
            if(this.Amount > 0 && this.CreditCardNumber != null)
            {
                message = $"Your payment of {this.Amount} has been processed onto your credit card";
            }
            return message;
        }
    }
}