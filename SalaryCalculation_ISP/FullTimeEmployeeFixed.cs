using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation_ISP
{
    public class FullTimeEmployeeFixed : IFullTimeWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float CalculateNetSalary()
        {
           Console.WriteLine( $"{ID} { Name} { MonthlySalary + OtherBenefits}");
            return MonthlySalary + OtherBenefits;
        }
        
    }
}
