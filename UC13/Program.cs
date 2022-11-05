using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC13
{
    public interface Isalary
    {
        public void Salary();
        public void AddCompanyEmpWage(string Company, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
    }
    public class CompanyEmpWage
    {
        public int wagePerHour;
        public int workingHours;
        public int workingDaysPerMonth;
        public int maxWorkingDays;
        public int maxWorkingHours;
        public string Company;
        public int totalSalary;
        public CompanyEmpWage(string Company, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.Company = Company;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setTotalSalary(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public string toString()
        {
            return "Total Employee Wage for Company : " + this.Company + " is: " + this.totalSalary;
        }
        public class TotalSalary : Isalary
        {
            public int numOfCompany = 0;
            private LinkedList<CompanyEmpWage> companyEmpWageList;
            public TotalSalary()
            {
                this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            }
            public void AddCompanyEmpWage(string Company, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
            {
                CompanyEmpWage companyEmpWage = new CompanyEmpWage(Company, wagePerHour, maxWorkingDays, maxWorkingHours);
                this.companyEmpWageList.AddLast(companyEmpWage);
            }

            public void Salary()
            {
                foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
                {
                    companyEmpWage.setTotalSalary(this.salary(companyEmpWage));
                    Console.WriteLine(companyEmpWage.toString());
                }
            }
            private int salary(CompanyEmpWage companyEmpWage)
            {
                int workingHours = 0;
                int workingDaysPerMonth = 0;
                int totalWorkingHours = 0;

                while ((totalWorkingHours <= companyEmpWage.maxWorkingHours) && (workingDaysPerMonth < companyEmpWage.maxWorkingDays))
                {
                    Random attendanceCheck = new Random();
                    int isPresent = attendanceCheck.Next(0, 4);
                    workingDaysPerMonth++;
                    switch (isPresent)
                    {
                        case 1:
                            //Console.WriteLine("Employee is present and working Full Time!");
                            workingHours += 8;
                            break;
                        case 2:
                            //Console.WriteLine("Employee is present and working Part Time!");
                            workingHours += 4;
                            break;
                        case 0:
                            //Console.WriteLine("Employee is Absent!");
                            workingHours = 0;
                            break;
                        default:
                            //Console.WriteLine("Something went wrong!!");
                            break;
                    }
                    int dailyWage = workingHours * companyEmpWage.wagePerHour;
                    Console.WriteLine("Wage per day : " + dailyWage);
                    totalWorkingHours += workingHours;
                    Console.WriteLine("Days# : " + workingDaysPerMonth + " Total Working Hours :" + workingHours);
                }
                int amount = (totalWorkingHours * companyEmpWage.wagePerHour);
                Console.WriteLine(amount);
                return amount;
            }

            internal void getTotalWage(string v)
            {
                throw new NotImplementedException();
            }
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employ Wage Computation Program!");
            TotalSalary totalSalary = new TotalSalary();
            totalSalary.AddCompanyEmpWage("abc", 20, 2, 10);
            totalSalary.AddCompanyEmpWage("xyz", 10, 4, 20);
            totalSalary.Salary();
            Console.Write("Total Wage for abc Company : ");
            totalSalary.getTotalWage("abc");
        }
    }
}