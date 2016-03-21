using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   
    public static class Randomizer
    {

        public static void randomVal(ref int[] arr)
        {
            Random r = new Random();
            int num = r.Next(0, 13);
           
            if (num < arr.Length)
            {
                arr[num] = 0;                
            }
         
        }
        public static void Randomize(ref int[] arr, int size)
        {
            try
            {
                Exception ecxp = new Exception("Not the right size");
                if (arr.Length + 1 != size)
                    throw (ecxp);
            }
            catch
            {
                Console.WriteLine("You have to put rigth number!! you input number has been changed to " + (arr.Length + 1));
                size = arr.Length + 1;
            }
            finally
            {
                int count = 0;
                for (var i = 0; i < arr.Length;)
                {
                    Random rnd = new Random();
                    arr[i] = rnd.Next(1, size);
                    for (var j = 0; j < i; ++j)
                    {
                        if (arr[j] == arr[i])
                            ++count;
                    }
                    if (count == 0)
                        ++i;
                    count = 0;
                }
            }


        }
    }

  

    public static class Show<T>
    {
        public static bool Display(T[]arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Nothing to show!!!");
                return false;
            }
            for( var i =0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            return true;

        }
    }
    public static class Compare<T>
    {

        public static void Sum(int size, ref int sum)
        {

            if (size == 0)
                return;
            else
            {
                sum += size;
                --size;
                Sum(size, ref sum);
            }

        }
        public static void SumArr(int[] arr, ref int size, ref int sum)
        {

            if (size < 0)
                return;
            else
            {
                sum += arr[size];
                --size;
                SumArr(arr, ref size, ref sum);
            }
        }


        public static bool Comp(int[] arr)
        {
            int sum = 0;
            Compare<T>.Sum(arr.Length, ref sum);
            int t = arr.Length - 1, k = 0;
            Compare<T>.SumArr(arr, ref t, ref k);
            if (sum == k)
                return true;
            return false;
        }

        public static T[] Clone(T[]arr)
        {
            T[] arr1 = new T[arr.Length];
            for(int key = 0; key < arr.Length; ++key)
            {
                arr1[key] = arr[key];
            }

            return arr1;
        }
    }

       
}
