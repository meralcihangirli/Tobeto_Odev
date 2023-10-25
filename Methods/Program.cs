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
            Add();
            Add();
            Add();
            Add();
            var result=Add2();    
            Console.WriteLine(result);
            Console.ReadLine();
        }
        //don't repeat yourself!--> metotların kullanım amaclarından biri kod tekrarına düşmemektir
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        //default deger ataması en sonda olur ama 2den fazlaysa en sagda olandan itibaren sola dogru degerleri atayabilirsin 
        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
    }

}
