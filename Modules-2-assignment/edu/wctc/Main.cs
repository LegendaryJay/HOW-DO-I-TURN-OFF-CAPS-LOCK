namespace Modules_2_assignment.edu.wctc
{
    internal static class MainClass
    {
        public static void Main(string[] args) {
            var company = new Company();

            // Startup delegates work to Company which then delegates work to HRManager
            company.HireEmployee("John", "Doe", "444-44-4444");
            company.HireEmployee("Boo", "BooBerry", "111-11-1111");
            company.HireEmployee("moist", "Boi", "123-12-5173");
            //company.HireEmployee("Bruh", "Swammy", "This is suppose to fail");
            

        }
    }
}