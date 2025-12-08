namespace Lecture09.Services;

using Lecture09.Models;
using System;
using Lecture09.Exceptions;
using Lecture09.Extensions;

class OrderService
{
    private INotifier notifier;
    private PaymentProcessor paymentProcessor; //HomeWork: use IPaymentProcessor for better abstraction and applying DIP
                                                // implementing classes could be StripePaymentProcessor, PaypalPaymentProcessor etc. 
                                                //and those classes should be sealed for security reasons.
    private List<Order> ordersHistory = new List<Order>();//TODO: use IRepository<Order> for better abstraction and applying DIP
                                                            //impementing classes could be InMemoryOrderRepository, DatabaseOrderRepository etc.
                                                            //we will continue with this exrcise in the next lecture using InMemoryOrderRepository, TextFileOrderRepository
    
    
    public OrderService(INotifier notifier, PaymentProcessor paymentProcessor){
        this.notifier = notifier; //this is called Dipendency Injection and its done via constructor
        this.paymentProcessor = paymentProcessor;
    }       

    public void ProcessOrder(Order order, Money payment, string contactInfo){
       //Homework: implement order processing logic here
    }
}