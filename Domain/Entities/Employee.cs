using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities

{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileImage { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int JobId { get; set; }
        public Job Job;        
        public List<JobTimeHistory> JobTimeHistories;
        public List<JobHistory> JobHistories;
    
     
        
        
        
        
        
        
                
    }
}