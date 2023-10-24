using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";

            //arraylar; tek bir noktadan aynı tip değişkenleri yönetebiliriz.Array kullanılmadıgında üstteki string ifadeler gibi tek tek tanımlama ile uğrasılacaktır.
            // [] --> tek boyutlu array yazımı

            //array kullanımı 4
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            //array kullanımı 1
            // string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //array kullanımı 2
            //string[] students2 = new[] {"Engin","Derin","Salih"};

            //array kullanımı 3
            string[] students2 = { "Engin", "Derin", "Salih" };
            //students2[3] = "Ahmet"; -> students2'ye tanımlanan eleman sayısı 3tür, bu satırdaki de eklenince array sınır sayısını aşacağından program hata verecektir.


            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}


            // [,] --> çok boyutlu array yazımı.Çok boyutlar arraylar 0'dan başlamaz. [5,3] 5 satır 3 sütun anlamına gelmektedir. 
            string[,] regions = new string[5, 3]
            {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" },

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***********");
            }


            
            Console.ReadLine();

        }
    }
}
