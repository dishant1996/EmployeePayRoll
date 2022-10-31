using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4
{
    internal class Program
    {
        //constant
        public const int IS_FullTime = 1;
        public const int IS_PRTTIME = 0;
        public const int EMP_RET_PER_HR = 20;
        static void Main(string[] args)
        {
            //local ver
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //using next() methad to genret rondom input out 0,1
            int empInput = random.Next(0, 3);

            //Switch Case programing constact
            switch (empInput)
            {
                case IS_FullTime:
                    empHrs = 8;
                    Console.WriteLine("Employee Wage Present in Full Time");
                    break;
                case IS_PRTTIME:
                    Console.WriteLine("Employee Wage Present in Part Time");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee Wage Absent");
                    empHrs = 0;
                    break;
            }
            empWage = EMP_RET_PER_HR * empHrs;
            Console.WriteLine($"Employee Wage {empWage}");
            Console.ReadLine();
        }
    }
}
