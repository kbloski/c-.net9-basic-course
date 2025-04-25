using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Switch_Case
    {
        public static void Example() 
        {
            DateTime dateTime = DateTime.Now;
            int Hour = dateTime.Hour;

            switch (Hour)
            {
                case 12:
                    Console.WriteLine("It is noon day");
                    break;
                default:
                    Console.WriteLine($"It's {Hour}");
                    break;
            }
        }
    }
}
