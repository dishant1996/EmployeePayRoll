using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constant
            int IS_FullTime = 1;
            int IS_PRTTIME = 0;
            int EMP_RET_PER_HR = 20;
            //local ver
            int empHrs;
            int empWage;
            Random random = new Random();

            //using next() methad to genret rondom input out 0,1
            int empInput = random.Next(0, 2);
            //if else programing constact
            if (IS_FullTime == empInput)
            {
                Console.WriteLine("Employee is prsent");
                empHrs = 8;
            }
            else if (IS_PRTTIME == empInput)
            {
                Console.WriteLine("Employee is prsent but Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = EMP_RET_PER_HR * empHrs;
            Console.WriteLine($"Employee Wage {empWage}");
            Console.ReadLine();
        }
    }
}
