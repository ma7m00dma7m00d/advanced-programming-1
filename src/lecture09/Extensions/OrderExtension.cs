namespace Lecture09.Extensions;

using Lecture09.Models;

static class OrderExtensoin{

    public static decimal CalculateTotal(this Order order){
        decimal total = 0; 
        foreach(var product in order.Products){
            total += product.Price.Amount;
        }
        return total;
    }//This simple implementation assumes all products have the same currency. In a production system, you would need currency conversion logic.
}

//extension method is a special kind of static method that allows us to "add" methods to existing types,
// without modifying their source code or creating a new derived type.

//it is espically useful when we want to add methods to types that we do not own or cannot modify,
// such as types from third-party libraries or the .NET framework itself.

//extenstion methods must static and be defined in a static class
// the first parameter of the method specifies the type it extends,preceded by the this keyword.
