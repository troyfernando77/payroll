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
    }
    public class CreateorEditEmployeeDto : Entity
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Rate { get; set; }
    }
    public class EmployeeDto : Entity
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Rate { get; set; }
    }
}
