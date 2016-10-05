using System;

namespace ConsoleApplication
{
    public class Payment
    {
        public decimal Amount{get;set;}
        
        public virtual string MakePayment()
        {
            return $"You paid ${this.Amount} in cash";
        }
    }
}