namespace Modules_2_assignment.edu.wctc
{
    public class HrPerson
    {
        //private readonly ArrayList _employees = new();

        public Employee HireEmployee(string firstName, string lastName, string ssn)
        {
            var e = new Employee(firstName, lastName, ssn);
            //_employees.Add(e);
            OrientEmployee(e);
            return e;
        }

        // HRManager delegates work to employee
        private void OrientEmployee(Employee emp)
        {
            emp.DoFirstTimeOrientation("B101");
        }

        public void OutputReport(Employee emp)
        {
            if (emp.MetWithHr && emp.MetDeptStaff && emp.ReviewedDeptPolicies && emp.MovedIn)
            {
                emp.PrintReport();
            }
        }
    }
}