using System.ComponentModel.DataAnnotations;
using ValueObjects.ValueObject;
 

namespace Version2.Data.Models
{
    public class GetEmployee
    {
        public int? Id { get; set; }
        public string EmpCode { get; set; }
    }
    public class Employee : Entity, IEntity
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal  Rate { get; set; }
        [Required]
        public string Company { get; set; }
        public string Department { get; set; }
        public static Result<Employee> Create(string empid, string empname, decimal rate,
            string company)
        {
            var emp = new Employee();
            emp.EmployeeId = empid;
            emp.EmployeeName = empname;
            emp.Rate = rate;
            emp.Company = company;
            if (string.IsNullOrEmpty(company))
                return Result<Employee>.Failed<Employee>("Company Required");

            return Result<Employee>.Ok<Employee>(emp);
        }
    }
    public class CreateorEditEmployeeDto : Entity
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Rate { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
    }
    public class EmployeeDto : Entity
    {
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; } = "";
        public decimal Rate { get; set; }
        [Required]
        public string Company { get; set; }
        public string Department { get; set; }
    }
}
