namespace Lecture09.Models;
using System;

struct Money
{
    public decimal Amount{get;} //no setter to make it immutable
    //chose decimal for money to avoid floating point precision issues
    public Currency Currency{get;} //no setter to make it immutable

    //intial values are set via constructor
    public Money(decimal amount, Currency currency){
        if(amount < 0)
            throw new ArgumentException("money amount can not be negative");

        Amount = amount;
        Currency = currency;
    }

    public override string ToString()
    {
        return $"{Amount} {Currency}";
    }
}

//structs are value types in C# that are typically used to represent small, immutable(no setters) data structures.
//As value types, structs are typically stored inline (where they're declared) rather than as separate heap allocations, which can improve performance for small, frequently-used types.
//we make Money a struct because it represents a simple value with two fields (Amount and Currency)
//we only care that 10 USD is equal to 10 USD, not about any identity or reference.
//Note that if this project was a bank we would NOT use struct for money but rather a class, cuz then we would care about identity and reference (Money would represent an entity then).