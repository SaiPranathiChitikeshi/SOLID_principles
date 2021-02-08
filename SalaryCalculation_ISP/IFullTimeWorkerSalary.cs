using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation_ISP
{
    public interface IFullTimeWorkerSalary : IBaseWorker
    {
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }
        float CalculateNetSalary();
    }
}
