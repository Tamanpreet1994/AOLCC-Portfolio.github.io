using System;

namespace Polymorphism_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}



interface IQuittable
{
    void Quit(); 
}


class Employee : IQuittable
{
 
    public string Name { get; set; }

 
    public Employee(string name)
    {
        Name = name;
    }

   
    public void Quit()
    {
        Console.WriteLine($"Employee {Name} has quit the job.");
    }
}

class Program
{
    static void Main()
    {
        
        Employee employee = new Employee("John Doe");

       
        IQuittable quittableEmployee = employee;

       
        quittableEmployee.Quit();

       
        Console.ReadLine();
    }
}
