using System;

namespace workReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { projectCode = "123Ds", projectName = "Project1", spentHours = 5 });
            report.AddEntry(new WorkReportEntry { projectCode = "987Fc", projectName = "Project2", spentHours = 3 });
            Console.WriteLine(report.ToString());
            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
        }
    }
}
