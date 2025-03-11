using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    //[Index(nameof(DeptID))]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeptID { get; set; }

        // علاقة واحد إلى متعدد مع Employee
        public ICollection<Employee> Employees { get; } = new List<Employee>();
    }

    [Index(nameof(FullName),nameof(Position))]
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }

        // FK وعلاقته بـ Company
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }  
    public class CompanyTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TestId { get; set; }
        public int TestName { get; set; }
        // علاقة واحد إلى متعدد مع Employee
        public ICollection<EmployeeTest> EmployeesTest { get; } = new List<EmployeeTest>();
    }

    public class EmployeeTest
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int TestName { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }


        // FK وعلاقته بـ Company
        public CompanyTest CompanyTest { get; set; }
    }

}
