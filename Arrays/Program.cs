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

            //arraylar; tek bir noktadan aynı tip değişkenleri yönetebiliriz.

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


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();    
            Console.ReadLine();

        }
    }
}
