using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculation_ISP
{
    public interface IBaseWorker
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
