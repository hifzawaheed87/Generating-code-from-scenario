// Create a base class employee with  attributes name and salary.
// Make two subclasses
// -Manager(adds bonus)
// -Developer(adds project_count)
// Each class should have a get_details() method that returns a string containing the employee's name,salary and their extra attributes.
// Write a loop that stores both subclasses in a list and display details using polymorphism.

using System;
using System.Collections.Generic;

class Employee
{
    public string name;
    public double salary;

    public Employee(string n, double s)
    {
        name = n;
        salary = s;
    }

    public virtual string get_details()
    {
        return "Name: " + name + "\nSalary: " + salary;
    }
}

class Manager : Employee
{
    public double bonus;

    public Manager(string name, double salary, double b)
        : base(name, salary)
    {
        bonus = b;
    }

    public override string get_details()
    {
        return base.get_details() + "\nBonus: " + bonus;
    }
}

class Developer : Employee
{
    public int project_count;

    public Developer(string name, double salary, int projectCount)
        : base(name, salary)
    {
        project_count = projectCount;
    }

    public override string get_details()
    {
        return base.get_details() + "\nProjects: " + project_count;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Manager("Ali", 100000, 20000));
        employees.Add(new Developer("Ahmed", 80000, 5));

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.get_details());
        }
    }
}