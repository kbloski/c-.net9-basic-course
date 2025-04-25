using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class VariablesInfo
    {
        public static void VarriblesTypes() 
        {
            // Typy niejawne
            var a = "this get type when get first value";
            var b = 33;
            var c = 33.123;

            // Jawne typy
            char OneChar = 'a';
            string Name = "Kamil";

            decimal Decim = 33.33m;
            double Dbl = 0.3332;
            float Flt = 0.3331231232F;
            int Integer = 123;
            long BigInteger = 1231231212321312312;

            Console.WriteLine($"char - {OneChar}");
            Console.WriteLine($"string - {Name}");
            Console.WriteLine($"decimal - {Decim}");
            Console.WriteLine($"double - {Dbl}");
            Console.WriteLine($"float - {Flt}");
            Console.WriteLine($"int - {Integer}");
            Console.WriteLine($"long (big int) - {BigInteger}");


            //int x, y, z;
            //x = 10;
            //y = 20;
            //z = 30;
            int x = 10, y = 20, z = 30;
            x++;
            y--;

            //String -> double
            string TextDouble = "2022.22";
            double doubleV = Convert.ToDouble(TextDouble);
            Console.WriteLine(doubleV);

            //String -> float
            string TextFloat = "2022.22";
            float floatVar = Convert.ToSingle(TextFloat);
            Console.WriteLine(floatVar);

            //String -> Int
            string TextAge = "2022";
            int age = Convert.ToInt32(TextAge);
            Console.WriteLine(age);

            //String -> long
            string TextBigInt = "1231232131212123";
            long bigInt = Convert.ToInt64(TextBigInt);
            Console.WriteLine(bigInt);

            // Reszta z dzielenia 
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);
            Console.WriteLine(32 % 30);

        }


    }
}
