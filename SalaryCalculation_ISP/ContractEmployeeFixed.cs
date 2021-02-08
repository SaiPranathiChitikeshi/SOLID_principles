using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation_ISP
{
    public class ContractEmployeeFixed : IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalaculateWorkedSalary() {
            Console.WriteLine(HourlyRate * HoursInMonth);
            return HourlyRate* HoursInMonth;
         }
    }
}
