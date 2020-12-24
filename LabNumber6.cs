using System;

namespace Zhdan
{
    class Program
    {
        public static string stringReversing(string str)
        {
           
            char[] arr = str.ToCharArray();
            Array.Reverse( arr );
           
            
            return new string( arr );;

        }

        public static void CustomReversing(ref int[] arr)
        {
            
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            
        }

        
        public static string ReverseAfterSymbol(string str, char symbol)
        {
           
            char[] charArr = str.ToCharArray();

            int dotind = 0;
            
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == symbol)
                {
                    dotind = i;
                }
            }

            
            char[] charArrayTwo = new char[dotind];
            char[] charArrayThree = new char[charArr.Length - dotind];
            for (int i = 0; i < dotind; i++)
            {
                charArrayTwo[i] = charArr[i];
            }

            
            int j = 0;
            for (int i = dotind+1; i < charArr.Length; i++)
            {
                charArrayThree[j] = charArr[i];
                j++;
            }
           
            Array.Reverse(charArrayTwo);
            Array.Reverse(charArrayThree);
            string final = new string(charArrayTwo)+"."+new string(charArrayThree);
            charArr = final.ToCharArray() 
           
            return new string(charArr);
        }
        
        public static string doubleReversing(double num)
        {
            string x = Convert.ToString(num);
            char[] charArray = x.ToCharArray();

            int pointINDEX = 0;
            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '.')
                {
                    pointINDEX = i;
                }
            }

            char[] arr_tH = new char[charArray.Length - pointINDEX];
            char[] arr_tW = new char[pointINDEX];
            
            for (int i = 0; i < pointINDEX; i++)
            {
                arr_tW[i] = charArray[i];
            }

            
            int j = 0;
            for (int i = pointINDEX+1; i < charArray.Length; i++)
            {
                arr_tH[j] = charArray[i];
                j++;
            }
           
           Array.Reverse(arr_tW);
           Array.Reverse(arr_tH);
           string final = new string(arr_tW)+"."+new string(arr_tH);
           charArray = final.ToCharArray();
           

           
           
           
           
           Console.WriteLine(new string(charArray));
           
           return new string(charArray);
        }

        public static int reversing(int num)
        {
            string x = Convert.ToString(num);
            char[] charArray = x.ToCharArray();
            Array.Reverse( charArray );
            x = new string( charArray );

            int result = Convert.ToInt32(x);
            
            return result;

        }

       
        static void Main(string[] args)
        {

           


        }
    }
}
