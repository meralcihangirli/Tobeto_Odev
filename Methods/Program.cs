using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);

            //Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }
        //don't repeat yourself!--> metotların kullanım amaclarından biri kod tekrarına düşmemektir
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        //default deger ataması en sonda olur ama 2den fazlaysa en sagda olandan itibaren sola dogru degerleri atayabilirsin 
        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }

}
