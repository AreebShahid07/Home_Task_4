using System;


namespace Home_Task_4
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Library book = new Library();

               book.Author = " Areeb ";
               book.ISBN = "12345";
               book.Price = 100;
               book.Title = " Object Oriented Programming";

               book.DisplayBookInfo();

               Console.WriteLine(" How much discount you want :");
               double percentage = double.Parse(Console.ReadLine());

               book.ApplyDiscount(percentage);

               Employee employee = new Employee();
               employee.EmployeeID = 12345 ;
               employee.Name = "Areeb";
               employee.Department = "CS";
               employee.Salary = 1000;

               employee.DisplayEmployeeDetails();

               Console.WriteLine(" How much increase in Salary you want :");
               double increase = double.Parse(Console.ReadLine());

               employee.IncreaseSalary(increase);
          }
     }
}
