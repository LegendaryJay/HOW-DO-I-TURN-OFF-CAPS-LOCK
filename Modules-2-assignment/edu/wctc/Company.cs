namespace Modules_2_assignment.edu.wctc
{
    public class Company
    {
        private readonly HrPerson _hr;

        public Company() {
            _hr = new HrPerson();
        }

        public void HireEmployee(string firstName, string lastName, string ssn) {
            _hr.OutputReport(_hr.HireEmployee(firstName, lastName, ssn));
        }
    }
}