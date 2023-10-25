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
            //int number1; -- out keyword için number1 degerinin metot dısında tanımlı olmaması gerekiyor
            int number2 = 100;
            var result2 = Add3(out number1, number2);

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

        /*ref keyword ; metod ve dışarıdaki degerin basına ref yazılmalı,örn metod içindeki tanımlanan number1 degerinin diger number1 degerine baskın gelmesini istersek geçerli olması ref keywordu kullanarak referans gostermeliyiz*/

        // out keyword ref keyword ile aynı mantıktadır ancak farkı; ref'de metod dısında bulunan number1'in mutlaka bir değeri olmalı ama out için böyle bir zorunluluk bulunmamakta.Out için gönderilecek değerin mutlaka metod içinde set edilmesi gerekir 

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }

}
