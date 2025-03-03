using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_4
{
     internal class Employee
     {
          public int EmployeeID;
          public string Name;
          public string Department;
          public double Salary;

          public Employee() 
          {
               EmployeeID = 1;
               Name = string.Empty;
               Department = string.Empty;
               Salary = 0;
          }

          public void DisplayEmployeeDetails()
          {
               Console.WriteLine("------------- Details -------------");
               Console.WriteLine($" Employee ID :{EmployeeID}");
               Console.WriteLine($" Employee Name :{Name}");
               Console.WriteLine($" Employee Department :{Department}");
               Console.WriteLine($" Employee Salary :{Salary}");
          }

          public void IncreaseSalary(double amount)
          {
               Salary += amount;
               Console.WriteLine($"Increased Employee Salary : {Salary}");
          }
     }
}
