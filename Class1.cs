using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_4
{
     internal class Library
     {
          public string Title;
          public string Author;
          public string ISBN;
          public double Price;
          
          public void DisplayBookInfo()
          {
               Console.WriteLine("------------- Details -------------");
               Console.WriteLine($" Book Title :{Title}" );
               Console.WriteLine($" Book Author :{Author}");
               Console.WriteLine($" Book ISBN :{ISBN}");
               Console.WriteLine($" Book Price :{Price}");
          }
          public void ApplyDiscount(double percentage)
          {
               double discount = (Price * (percentage/100));
               Console.WriteLine($"Price after {percentage}% discount : {Price - discount}");
          }
     }
}
