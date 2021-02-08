using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation_ISP
{
    public interface IContractWorkerSalary : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalaculateWorkedSalary();
    }
}
