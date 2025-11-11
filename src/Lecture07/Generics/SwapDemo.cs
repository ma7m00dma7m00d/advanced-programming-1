
namespace Lecture07.Generics
{
    public static class SwapDemo
    {
        // --- Step 1: The Duplicated, Typed Way ---
        // PROBLEM: Code duplication. We need a new method
        // for every single type (double, bool, etc.)
        //we are violating the DRY (Don't Repeat Yourself) principle
        public static void Swap_Typed(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap_Typed(ref bool a, ref bool b)
        {
            bool temp = a;
            a = b;
            b = temp;
        }



        // --- Step 2: The 'object' Way (Dangerous) ---
        // Solves duplication, but creates a new, worse problem.
        // PROBLEM: We lose all type safety. The compiler
        // will let us swap an int with a string,
        // leading to a runtime crash (InvalidCastException).
        public static void Swap_Object(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }



        // --- Step 3: The Generic Way (Correct) ---
        // This is the best solution.
        // - We write the code ONCE.
        // - It is 100% type-safe. The <T> enforces that
        //   'a' and 'b' MUST be the same type.
        // - The compiler will stop us from swapping an int and a string.
        public static void Swap_Generic<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}