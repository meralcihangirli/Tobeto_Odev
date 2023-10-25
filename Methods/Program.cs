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
            Console.ReadLine();
        }
        //don't repeat yourself!--> metotların kullanım amaclarından biri kod tekrarına düşmemektir
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
    }

}
