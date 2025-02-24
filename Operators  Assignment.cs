using System;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


class Employee
{
    public int Id { get; set; } 
    public string FirstName { get; set; } 
    public string LastName { get; set; }

   
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        
        if (ReferenceEquals(emp1, emp2)) return true;

       
        if (emp1 is null || emp2 is null) return false;

       
        return emp1.Id == emp2.Id;
    }

   
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main()
    {
        
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };
        Employee employee3 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

        
        Console.WriteLine("employee1 == employee2: " + (employee1 == employee2));
        Console.WriteLine("employee1 == employee3: " + (employee1 == employee3)); 

  
        Console.WriteLine("employee1 != employee2: " + (employee1 != employee2));
        Console.WriteLine("employee1 != employee3: " + (employee1 != employee3)); 

       
        Console.ReadLine();
    }
}
