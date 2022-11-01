using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7
{
    internal class Program
    {
        public const int IS_FullTime = 1;
        public const int IS_PRTTIME = 2;
        public const int EMP_RET_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 10;
        public static int computeEmpWage()
        {
            // local variable
            int empHrs = 0; int totalEmphrs = 0; int totalWorkingDays = 0;
            //Computaion
            while (totalEmphrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmphrs = totalEmphrs + empHrs;
                Console.WriteLine($"Day: {totalWorkingDays} Emp Hrs:{empHrs} ");
            }
            int totalEmpwage = totalEmphrs * EMP_RET_PER_HR;
            Console.WriteLine($"Total emp wage : {totalEmpwage}");
            return totalEmpwage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
            Console.ReadLine();
        }
        
    }
}
