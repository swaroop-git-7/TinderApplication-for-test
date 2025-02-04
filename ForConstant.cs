using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TinderApplication
{
    public class ForConstant
    {
        public const int UserNo = 12;

    }

    public class ForEnum
    {
        enum Day
        {
            Sunday=2,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        internal class FE()
        {
            static void main()
            {
                Console.WriteLine(Day.Sunday);
                Console.Write(Day.Monday);
             
                List<string> lstDays = new List<string>();
                lstDays.Add("Sunday");
                lstDays.Add("Monday");
                lstDays.Add("Tuesday");
                lstDays.Add("Wednesday");
                lstDays.Add("Thursday");
                lstDays.Add("Friday");
                lstDays.Add("Saturday");

                var Days  = new Dictionary<string, int>();
                {
                    Days.Add("Sunday", 42);
                    Days.Add("Monday", 43);
                    Days.Add("Tuesday", 44);
                    Days.Add("Wednesday", 45);
                    Days.Add("Thursday", 46);
                    Days.Add("Friday", 47);
                    Days.Add("Saturday", 48);
                }
                Console.Write(Days);

            }
        }
    }
}
