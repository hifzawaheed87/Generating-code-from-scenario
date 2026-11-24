using System;

//Suppose you have to implement a software for a College or
// University Student Record Management System. University
// should maintain the information about student’s full name, roll
// number, cgpa, matric marks, fsc marks, ecat marks, current
// semester, fees, home town, whether day scholar or hostelite
// and whether availing a scholarship or not.Merit of student
// can be calculated by adding 60% of Fsc Marks and 40% of
// ECat marks. Students can check their scholarship status: A
// student is eligible for scholarship if her merit is greater than
// 80% and she is hostelite.
class Student
{
    // Data Members

    public string fullName;
    public string rollNumber;
    public double cgpa;

    public double matricMarks;
    public double fscMarks;
    public double ecatMarks;

    public int currentSemester;
    public double fees;

    public string homeTown;

    public bool isHostelite;
    public bool isAvailingScholarship;


    // Constructor

    public Student(string name, string roll, double cgpa,
                   double matric, double fsc, double ecat,
                   int semester, double fees,
                   string town, bool hostel,
                   bool scholarship)
    {
        fullName = name;
        rollNumber = roll;
        this.cgpa = cgpa;

        matricMarks = matric;
        fscMarks = fsc;
        ecatMarks = ecat;

        currentSemester = semester;
        this.fees = fees;

        homeTown = town;

        isHostelite = hostel;
        isAvailingScholarship = scholarship;
    }


    // Behaviour 1: Calculate Merit

    public double CalculateMerit()
    {
        double merit = (fscMarks * 0.60) + (ecatMarks * 0.40);

        return merit;
    }


    // Behaviour 2: Check Scholarship Eligibility

    public bool CheckScholarshipEligibility()
    {
        if (CalculateMerit() > 80 && isHostelite == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // Behaviour 3: Display Student Information

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Student Information");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Name: " + fullName);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("CGPA: " + cgpa);

        Console.WriteLine("Matric Marks: " + matricMarks);
        Console.WriteLine("FSC Marks: " + fscMarks);
        Console.WriteLine("ECAT Marks: " + ecatMarks);

        Console.WriteLine("Semester: " + currentSemester);
        Console.WriteLine("Fees: " + fees);

        Console.WriteLine("Home Town: " + homeTown);

        if (isHostelite == true)
        {
            Console.WriteLine("Student Type: Hostelite");
        }
        else
        {
            Console.WriteLine("Student Type: Day Scholar");
        }

        Console.WriteLine("Merit: " + CalculateMerit() + "%");

        if (CheckScholarshipEligibility() == true)
        {
            Console.WriteLine("Scholarship Eligible: Yes");
        }
        else
        {
            Console.WriteLine("Scholarship Eligible: No");
        }

        if (isAvailingScholarship == true)
        {
            Console.WriteLine("Scholarship Availing: Yes");
        }
        else
        {
            Console.WriteLine("Scholarship Availing: No");
        }
    }
}


class Program
{
    static void Main()
    {
        Student s1 = new Student(
            "Hifza Waheed",
            "SE-101",
            3.79,
            95,
            85,
            90,
            3,
            85000,
            "Lahore",
            true,
            true
        );

        s1.DisplayStudentInfo();
    }
}