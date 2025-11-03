using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void MyFunc()
        {

            Console.WriteLine("תכניס  מספר");
            int num1 = int.Parse(Console.ReadLine());
            if (num1%2 == 0) Console.WriteLine("זוגי");

            else Console.WriteLine("אי זוגי");






            Console.WriteLine("תכניס טמפרטורה");
            int num2= int.Parse(Console.ReadLine());
            if (0 <= num2 && 30 >= num2)

                Console.WriteLine("נעימה");
            else if (num2 > 30)
                Console.WriteLine("לא נעימה");
            else Console.WriteLine("קפוא");





            Console.WriteLine("תכניס סיסמה");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 == 1234) Console.WriteLine("סיסמה נכונה");

            else Console.WriteLine("סיסמה לא נכונה");



        }   

        static void Main(string[] args)
        {
            MyFunc();
        }
    }
}
