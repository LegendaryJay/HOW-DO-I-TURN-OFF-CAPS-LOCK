using System;

namespace Modules_2_assignment.edu.wctc
{
    public class EmployeeReportService
    {
        private string _report = "";

        public void AddData(string data)
        {
            _report += data;
        }

        public void OutputReport()
        {
            Console.WriteLine(_report);
            //ClearReport();
        }

        //private void ClearReport()
        //{
        //    _report = "";
        //}
    }
}