using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool HasPrevious = false;

            int[] array = new int[] {1,2,3,3,4,5,5,5,6,7,8,8,8,8 };

            for (int i = 0; i < array.Length-2; i++)
            {

                if (i==0)
                {
                    if (array[array.Length-1] == array[array.Length - 2])
                    {
                        array[array.Length - 1]++;
                        array[array.Length - 2]++;
                    }
                }

                if (array[i+1] == array[i])
                {
                    HasPrevious = true;
                }
                if (HasPrevious == true)
                {
                    
                    if (array[i+1] != array[i])
                    {

                        HasPrevious = false;
                    }
                    array[i]++;
                }
            }







            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
