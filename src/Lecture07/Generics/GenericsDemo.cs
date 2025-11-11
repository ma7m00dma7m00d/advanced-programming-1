using System;

namespace Lecture07.Generics
{
    public static class GenericsDemo
    {
        //we are going to demonstrate by trying to swap different types using the SwapDemo class
        public static void Run()
        {
            //-----------------------------------
            // step 1 : the object problem
            //-----------------------------------
            Console.WriteLine("\n--- Generics Demo: Step 1 (The 'object' Problem) ---");
            int number = 100;
            bool flag = true;

            // first We must "box" value types to treat them as objects
            object obj_num = number;
            object obj_flag = flag;
            //boxing is the process of converting a value type to an object type
            //value types are stored in stack memory, while object types are stored in heap memory

            Console.WriteLine($"Before: obj_num = {obj_num} (Type: {obj_num.GetType()})");
            Console.WriteLine($"Before: obj_flag = {obj_flag} (Type: {obj_flag.GetType()})");

            // This compiles, but it's a logical disaster.
            // We are swapping an int with a bool.
            SwapDemo.Swap_Object(ref obj_num, ref obj_flag);

            Console.WriteLine($"After:  obj_num = {obj_num} (Type: {obj_num.GetType()})");
            Console.WriteLine($"After:  obj_flag = {obj_flag} (Type: {obj_flag.GetType()})");

            //now we are going to try unboxing to the original variables
            try
            {
                // CRASH! obj_num is now the bool 'true',
                // which cannot be unboxed back into an int.
                int i = (int)obj_num;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"CRASH: We got an {ex.GetType()}");
                Console.WriteLine("       (because we can't cast a bool to an int!)");
            }


            //---------------------------------
            // Step 2: The Generic Solution 
            //---------------------------------
            Console.WriteLine("\n--- Generics Demo: Step 2 (The Generic Solution) ---");
            int x = 10;
            int y = 20;
            bool flag2 = true;
         
            Console.WriteLine($"Before: x={x}, y={y}");
            // We can call Swap_Generic, and the compiler knows <T> is <int>
            SwapDemo.Swap_Generic(ref x, ref y);
            Console.WriteLine($"After:  x={x}, y={y}");

            // The compiler will give an ERROR on the line below:
            // SwapDemo.Swap_Generic(ref x, ref flag2); //try to uncomment this line
            // preventing us from swapping different types.

            Console.WriteLine("SUCCESS: The compiler stops us from swapping an int and a bool.");
            Console.WriteLine("         (Compile-time errors are always better than runtime crashes!)");
        }
    }
}