using Microsoft.AspNetCore.Http;
namespace Domain.Dtos
{
    public class AddEmployee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile ProfileImage { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int JobId { get; set; } 
    }

    public class GetEmployee
    {
           public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileImage { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public string JobName { get; set; }
        public DateTime StartJobTime{ get; set; }
        public DateTime TimeOfBeingLate { get; set; }
    
    }
}