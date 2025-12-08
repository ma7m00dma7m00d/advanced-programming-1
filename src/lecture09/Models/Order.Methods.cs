namespace Lecture09.Models;
using System.Text;
using System;
using Lecture09.Extensions;

partial class Order{

    public string GenerateRecipt(){
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Id.ToString());
        sb.AppendLine(new string('-',10));
        foreach (var product in Products)
        {
         sb.AppendLine(product.Name+"\t"+product.Price.ToString());
        }
        sb.AppendLine(new string('-',10));
        sb.AppendLine("Total: \t"+ this.CalculateTotal());
        return sb.ToString();
    }
    //we use stringbuilder here instead of string concatenation
    //because stringbuilder is more efficient when we have multiple string manipulations
    //strings are immutable in C#, so each concatenation creates a new string object in memory
    //stringbuilder maintains a mutable buffer that can be modified without creating new string objects 

    public void AddProduct(Product p){
        if(p == null)
            throw new ArgumentNullException("product to add can not be null");

        Products.Add(p);
    }

}