using System;

namespace SalaryCalculation_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            ContractEmployeeFixed contractEmployeeFixed = new ContractEmployeeFixed();
            FullTimeEmployeeFixed fullTimeEmployeeFixed = new FullTimeEmployeeFixed();
            fullTimeEmployeeFixed.ID = "Pranathi";
            fullTimeEmployeeFixed.Name = "prana";
            fullTimeEmployeeFixed.MonthlySalary = 25000;
            fullTimeEmployeeFixed.OtherBenefits = 7000;
            contractEmployeeFixed.HoursInMonth = 40;
            contractEmployeeFixed.HourlyRate = 2000;
            


            fullTimeEmployeeFixed.CalculateNetSalary();
            contractEmployeeFixed.CalaculateWorkedSalary();

        }
    }
}
