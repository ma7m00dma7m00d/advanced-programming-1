namespace Lecture09.Exceptions;

using System;

class PaymentFailedException : Exception
{
    public PaymentFailedException(string message) : base(message) { }
}
//we define custom exceptions for business rules in our application
//this helps us to provide more meaningful error messages and handle specific error scenarios gracefully.
