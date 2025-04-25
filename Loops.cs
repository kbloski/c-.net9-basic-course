using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Loops
    {
        public static void Example() 
        {
            ForLoop();
            WhileLoop();
        }

        public static void ForLoop()
        {
            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine($"for_counter: {i}");
            }
        }

        public static void WhileLoop()
        {
            int i = 1;
            while( i < 10)
            {
                Console.WriteLine($"while_counter: {i++}");
            }
        }
    }
}
