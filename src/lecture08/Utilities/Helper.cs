namespace Lecture08.Utilities
{ 
    class Helper{
        public static void ResizeArray<T> (ref T[] arrayToResize, int newSize =0){
            T[] resizedArray = new T[newSize];
            for (int i = 0; i < arrayToResize.Length ; i++)
            {
                resizedArray[i]= arrayToResize[i];
            }
            arrayToResize = resizedArray;
        }
    }   
}