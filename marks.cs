// a student class stores name, roll number and marks. the school wants to track total students 
// enrolled and ensure no student can have marks below 0 or above 100.
// a) make all attributes private
// b) Implement a method setMarks(int m) such that
//  if m <0 set marks to 0
//  if m >100 set marks to 100
// c) implement a method updateMarks(int extra) that add marks without exceeding 100
// d) declare a static variable totalStudents to count the number of objects created&#x20;
// e) explain how encapsulation ensures data integrity in this scenario

using System;

class Student
{
    // Private attributes
    private string name;
    private int rollNumber;
    private int marks;

    // Static variable
    public static int totalStudents = 0;

    // Constructor
    public Student(string n, int r, int m)
    {
        name = n;
        rollNumber = r;
        setMarks(m);

        totalStudents++;
    }

    // Set marks with validation
    public void setMarks(int m)
    {
        if (m < 0)
        {
            marks = 0;
        }
        else if (m > 100)
        {
            marks = 100;
        }
        else
        {
            marks = m;
        }
    }

    // Add extra marks
    public void updateMarks(int extra)
    {
        marks = marks + extra;

        if (marks > 100)
        {
            marks = 100;
        }
        else if (marks < 0)
        {
            marks = 0;
        }
    }

    // Display student details
    public void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Marks: " + marks);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Ali", 101, 85);
        Student s2 = new Student("Sara", 102, 120);
        Student s3 = new Student("Ahmed", 103, -5);

        s1.updateMarks(10);
        s2.updateMarks(20);

        s1.display();
        Console.WriteLine();

        s2.display();
        Console.WriteLine();

        s3.display();
        Console.WriteLine();

        Console.WriteLine("Total Students: " + Student.totalStudents);
    }
}