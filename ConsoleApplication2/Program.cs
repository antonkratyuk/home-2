using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[10];
            Randomizer.Randomize(ref arr, 11);           
            Show<int>.Display(arr);

            int[] array = Compare<int>.Clone(arr);

            Randomizer.randomVal(ref array);

            Console.WriteLine();

            Show<int>.Display(array);



            
            try
            {
                Exception exc = new Exception();
                if (Compare<int>.Comp(array))
                    throw exc;
            }
            catch
            {
                Console.WriteLine("Identic");
                System.Environment.Exit(1);
            }



            int pos = Array.IndexOf(array, 0);
            Console.WriteLine();
            Console.WriteLine( "Differs in " + pos);









        }
    }
}
