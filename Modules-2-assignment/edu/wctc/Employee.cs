using System;

namespace Modules_2_assignment.edu.wctc
{
    public class Employee
    {
        //constant stuff
        private const string RequiredMsg = " is mandatory ";
        private const string Newline = "\n";
        private readonly EmployeeReportService _reportService = new();

        //Primary stuff
        //I figured that first and last name can change but ssn could not
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("first name" + RequiredMsg);
                }
                _firstName = value;
            }
        }
        private string _firstName;
        
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("last name" + RequiredMsg);
                }
                _lastName = value;
            }
        }
        private string _lastName;
        
        public string Ssn
        {
            get => _ssn;
            private init
            {
                if (string.IsNullOrEmpty(value) || value.Length is < 9 or > 11) {
                    throw new ArgumentException("ssn" + RequiredMsg + "and must be between 9 and 11 characters (if hyphens are used)");
                }
                _ssn = value;
            }
        }
        private readonly string _ssn;

        //non-primary 
        public bool MetWithHr { get; private set; }

        public bool MetDeptStaff { get; private set; }

        public bool ReviewedDeptPolicies { get; private set; }

        public bool MovedIn { get; private set; }

        public string CubeId
        {
            get => _cubeId;
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("cube id" + RequiredMsg);
                }
                _cubeId = value;
            }
        }
        private string _cubeId;
        
        public DateTime OrientationDate
        {
            get => _orientationDate;
            private set
            {
                if (value == null) {
                    throw new ArgumentException("orientationDate" + RequiredMsg);
                }
                _orientationDate = value;
            }
        }
        private DateTime _orientationDate;

        //Constructor
        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
        }

        private string GetFormattedDate()
        {
            return OrientationDate.ToString("MM/dd/yy");
        }
        
        public void DoFirstTimeOrientation(string cubeId)
        {
            OrientationDate = DateTime.Today;
            MeetWithHrForBenefitAndSalaryInfo();
            MeetDepartmentStaff();
            ReviewDeptPolicies();
            MoveIntoCubicle(cubeId);
        }
        
        private void MeetWithHrForBenefitAndSalaryInfo()
        {
            MetWithHr = true;
            _reportService.AddData(FirstName + " " + LastName + " met with HR on "
                                   + GetFormattedDate() + Newline);
        }
        private void MeetDepartmentStaff()
        {
            MetDeptStaff = true;
            _reportService.AddData(FirstName + " " + LastName + " met with dept staff on "
                                   + GetFormattedDate() + Newline);
        }

        private void ReviewDeptPolicies()
        {
            ReviewedDeptPolicies = true;
            _reportService.AddData(FirstName + " " + LastName + " reviewed dept policies on "
                                   + GetFormattedDate() + Newline);
        }


        private void MoveIntoCubicle(string cubeId)
        {
            CubeId = cubeId;

            MovedIn = true;
            _reportService.AddData(FirstName + " " + LastName + " moved into cubicle "
                                   + cubeId + " on " + GetFormattedDate() + Newline);
        }
        
        public void PrintReport()
        {
            _reportService.OutputReport();
        }

        public override string ToString()
        {
            return "Employee{" + "firstName=" + FirstName + ", lastName=" + LastName + ", ssn=" + Ssn + '}';
        }
    }
    
}