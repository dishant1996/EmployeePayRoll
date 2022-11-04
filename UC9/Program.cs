using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC9
{
    public class UC9
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject tcs = new EmpWageBuilderObject("TCS", 25, 8, 100);
            EmpWageBuilderObject amazon = new EmpWageBuilderObject("Amazon", 40, 5, 150);
            tcs.computeEmpWage();
            Console.WriteLine(tcs.toString());
            amazon.computeEmpWage();
            Console.WriteLine(amazon.toString());
        }
    }
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHr;
        private int NUM_OF_WORKING_DAYS;
        private int MAX_HR_PER_MONTH;
        private int totalEmpWage;
        public EmpWageBuilderObject(string company, int empRatePerHr, int NUM_OF_WORKING_DAYS, int MAX_HR_PER_MONTH)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_HR_PER_MONTH = MAX_HR_PER_MONTH;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= this.MAX_HR_PER_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine("Total Emp Wage for Company : " + company + " is: " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for Company : " + this.company + " is: " + this.totalEmpWage;
        }


    }
}