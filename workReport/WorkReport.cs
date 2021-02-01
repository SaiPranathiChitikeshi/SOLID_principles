using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workReport
{
   public class WorkReport
    {
        private readonly List<WorkReportEntry> entries;
        public WorkReport()
        {
            entries = new List<WorkReportEntry>();
        }
        public void AddEntry(WorkReportEntry entry) => entries.Add(entry);
        public void RemoveEntryAt(int index) => entries.RemoveAt(index);
        public override string ToString() =>
            string.Join(Environment.NewLine, entries.Select(x => $"Code: {x.projectCode}, Name: {x.projectName}, Hours: {x.spentHours}"));
    }
}
