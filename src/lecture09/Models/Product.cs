namespace Lecture09.Models;
using System;

class Product{
    public Guid Id{get;}
    public string Name{get; set;}
    public Money Price{get; set;}

    public Product(string name, Money price){
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
    }
}
//product is an entity in our project
//entities are reference types that have a distinct identity that runs through time and different states.
//we use class for entities because we care about their identity and reference, not just their value