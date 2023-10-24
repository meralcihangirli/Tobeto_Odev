using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü  
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");
            //Console.ReadLine();


            //ForLoop();
            //int number = 100;
            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}", number);
            //Console.ReadLine();


            //WhileLoop();
            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number >= 11);
            //Console.ReadLine();



            //DoWhileLoop();
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();

        }


        //private static void ForLoop()
        //{
        //    for (int i = 100; i >= 0; i = i - 2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("Finished!");
        //}

        //private static void WhileLoop()
        //{
        //    int number = 100;
        //    while (number >= 0)
        //    {
        //        Console.WriteLine(number);
        //        number--;
        //    }
        //}

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }





    }
}
