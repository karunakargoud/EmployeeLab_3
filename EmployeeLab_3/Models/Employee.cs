using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeLab_3.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Designation { get; set; }

        public string age { get; set;}

        public int Salary { get; set; }
    }
}