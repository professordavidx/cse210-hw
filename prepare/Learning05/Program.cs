using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("123abd");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("1234agh");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee emp in employees)
        {
            float pay = emp.GetPay();
        }
  
    }

    //Polymorphism in action =  I am passing 2 different employees in one method. This method will behave differently

    public static void DisplayEmployeeInformation(Employee employee) // It takes an employee as a parameter 
    {
        Console.WriteLine($"{employee.GetIdNumber()}"); // getting specific information from the employees

        
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}"); // this will display how much money each employee is getting 
        
        
      



    }


}