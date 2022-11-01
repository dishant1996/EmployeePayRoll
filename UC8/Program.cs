using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC8
{
    class Computation
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public const int NUM_OF_WORK_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static void EmpWage(String company, int Emp_Rate_Per_Hrs, int Num_Of_Work_Days, int MaxHrsInMonth)
        {
            int empHrs = 0, totalWorkDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkDays < NUM_OF_WORK_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Total Employee Hours:" + totalEmpHrs + " " + "Employee Hours:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Total Employee Wage is:" + totalEmpWage);
        }

        public static void Main(String[] args)
        {
            EmpWage("Google", 1, 2, 3);
            EmpWage("Reliance", 12, 50, 9);
            EmpWage("Mahindra", 15, 5, 25);
        }
    }
}