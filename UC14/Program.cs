using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC14
{
    public interface IComputeEmpWage
    {

    }
    public class CompanyEmpWage
    {
        public string company;
        public int Emp_Rate_Per_Hr;
        public int Num_Of_Working_Days;
        public int Max_Hrs_Per_Month;
        public int totalEmpWage;
        public CompanyEmpWage(String company, int Emp_Rate_Per_Hr, int Num_Of_Working_Days, int Max_Hrs_Per_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hr = Emp_Rate_Per_Hr;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hrs_Per_Month = Max_Hrs_Per_Month;
            this.totalEmpWage = 0;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for Company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
    public class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int Emp_Rate_Per_Hr, int Num_Of_Working_Days, int Max_Hrs_Per_Month)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, Emp_Rate_Per_Hr, Num_Of_Working_Days, Max_Hrs_Per_Month);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //Computation
            while (totalEmpHrs <= companyEmpWage.Max_Hrs_Per_Month && totalWorkingDays < companyEmpWage.Num_Of_Working_Days)
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
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.Emp_Rate_Per_Hr;
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("TCS", 22, 3, 15);
            empWageBuilder.addCompanyEmpWage("Jio", 15, 3, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for TCS company : " + empWageBuilder.getTotalWage("TCS"));
            Console.WriteLine("Total wage for Jio company : " + empWageBuilder.getTotalWage("Jio"));
        }
    }
}