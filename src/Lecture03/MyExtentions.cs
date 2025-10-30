namespace test.myextentions
{
    public static class MyExtentions
    {
        //the purpose of this class is to hold extension methods for int type
        //this calss is not a part of the point struct exercise sulotion 
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(this int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static void Increment(this ref int number)
        {
            number = number + 1;
        }

    }
}