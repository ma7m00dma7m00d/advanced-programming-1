namespace Lecture09.Models;

enum Currency
{
    USD,
    SYB,
    EURO,
}
//enums are value types that represent a set of named constants.
//they are useful when we have a variable that can only take one out of a small set of possible values.
//using enums improves code readability and maintainability by giving meaningful names to these constant values.
//by default, the underlying type of each element in the enum is int, starting from 0,
//so USD = 0, SYB = 1, EURO = 2 in this case.
//integral values(like byte, int, long) can also be specified explicitly.

//a common practice is to write enum values in all UPPERCASE letters to distinguish them from regular variables.