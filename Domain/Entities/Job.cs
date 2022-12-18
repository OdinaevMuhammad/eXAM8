using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
namespace Domain.Entities
{
    public class Job
    {
      
      public int JobId { get; set; }
      public string JobName { get; set; }
      public int MinSalary { get; set; }
      public int MaxSalary { get; set; }
      public List<Employee> Employees;
      public List<JobHistory> JobHistories;
   
      
      
      
      
      
      
      
      
        
        
        
        
        
    }
}