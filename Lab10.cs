using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata;

namespace Zhdan
{
    
    
    public static class ExtMeth
    {
        public static void sort(this int []arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++) {
                for (int sort = 0; sort < arr.Length - 1; sort++) {
                    if (arr[sort] > arr[sort + 1]) {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            
            
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            

        }
    } 
    
    class Program
    {
      
        static void Main(string[] args)
        {

            int[] arr = new[] {3, 2, 1};
            arr.sort();

        }
    }
}
