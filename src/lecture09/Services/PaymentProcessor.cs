namespace Lecture09.Services;

using Lecture09.Models;
using Lecture09.Extensions;
using Lecture09.Exceptions;

sealed class PaymentProcessor
{
   public void ProcessPayment(Order order, Money payment) 
    {
        decimal orderTotal = order.CalculateTotal();
        
        if (payment.Currency != Currency.USD)  
            throw new PaymentFailedException($"We only accept USD, not {payment.Currency}");
            
        if (orderTotal > payment.Amount)
            throw new PaymentFailedException($"Paid amount {payment.Amount} is less than order's total {orderTotal}");

        Console.WriteLine("Payment Processed Successfully.");
    }
}

//sealed classes cannot be inherited.
/*
The main reasons for sealing are:
* Design intent (this class shouldn't be extended)
* Performance (virtual calls can be optimized away)
* Security through preventing malicious overrides
*/

//We seal PaymentProcessor to prevent inheritance, ensuring the payment logic cannot be altered through subclassing.
