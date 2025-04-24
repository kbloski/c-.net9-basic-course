using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class IfElseLesson
    {
        public static void Example()
        {
            bool isMale = true;

            if (isMale) Console.WriteLine("Man");
            else if (!isMale) Console.WriteLine("Woman");
            else Console.WriteLine("Wyjątek");
        }
    }
}
