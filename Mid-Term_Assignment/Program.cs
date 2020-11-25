using System;

namespace Mid_Term_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("University Management System");
            Console.WriteLine("");
            Console.WriteLine("");
            Course c = new Course("C#", 001, 3, 5.0);
            Course c1 = new Course("C++", 002, 3, 5.0, 1);
            Section s1 = new Section("A", "C#", 003, 3, 5.0);
            Section s2 = new Section("B", "HCI", 004, 3, 3.0);
            Section s3 = new Section("C", "SQT", 005, 3, 3.0);
            Section s4 = new Section("D", "C++", 006, 3, 3.0);
            Section s5 = new Section("E", "CAD", 007, 3, 3.0);
            Section s6 = new Section("F", "AI", 008, 3, 3.0);
            Section s7 = new Section("G", "DLD", 009, 3, 3.0);
            Section s8 = new Section("H", "CN", 010, 3, 3.0);
            Section s9 = new Section("I", "Math", 011, 3, 3.0);
            Section s10 = new Section("J", "English", 012, 3, 3.0);
            Console.WriteLine("Seacrhing For Section");
            Console.WriteLine("");
            c.ShowInfo();
            Console.WriteLine("");
            Console.WriteLine("");
            Department d = new Department("FST");
            Department d1 = new Department("LLB");
            Department d2 = new Department("FBA");
            Department d3 = new Department("EEE");
            d.AddCourse(c, c1);
            d.ShowAllCourses();
            Console.WriteLine("");
            Console.WriteLine("Adding Courses In Dept");
            d.ShowAllCourses();
            Console.WriteLine("");
            Console.WriteLine("Faculty Taking Courses");
            Console.WriteLine("");
            Faculty f1 = new Faculty("Tanvir Ahmed", "10-111");
            Faculty f2 = new Faculty("Shahreen Chowdhury", "11-025");
            Faculty f3 = new Faculty("Abdur Rahman", "21-013");
            Faculty f4 = new Faculty("A.G.M. Zaman", "15-041");
            Faculty f5 = new Faculty("Tohedul Islam", "13-025");
            Weekly_Teaching_Hours t = new Weekly_Teaching_Hours("C", 3, d);
            Weekly_Teaching_Hours t1 = new Weekly_Teaching_Hours("C++ ", 3, d);
            Weekly_Teaching_Hours t2 = new Weekly_Teaching_Hours("OOP1 ", 3, d);
            Weekly_Teaching_Hours t3 = new Weekly_Teaching_Hours("TOC", 3, d);
            Weekly_Teaching_Hours t4 = new Weekly_Teaching_Hours("OOAD", 3, d);
            Weekly_Teaching_Hours t5 = new Weekly_Teaching_Hours("OOAD", 3, d);
            Weekly_Teaching_Hours t6 = new Weekly_Teaching_Hours("Computer Networking", 3, d2);
            Weekly_Teaching_Hours t7 = new Weekly_Teaching_Hours("Operting System", 3, d);
            Weekly_Teaching_Hours t8 = new Weekly_Teaching_Hours("AOS", 3, d1);
            Weekly_Teaching_Hours t9 = new Weekly_Teaching_Hours("Python", 3, d1);
            Weekly_Teaching_Hours t10 = new Weekly_Teaching_Hours("SDPM", 3, d1);
            Weekly_Teaching_Hours t11 = new Weekly_Teaching_Hours("SRE", 3, d1);
            Weekly_Teaching_Hours t12 = new Weekly_Teaching_Hours("Compiler", 3, d2);
            Console.WriteLine("");
            Console.WriteLine("Faculty Info");
            Console.WriteLine("");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5, t8);
            f1.ShowAllCredits();
            Console.WriteLine("");
            Console.WriteLine("Faculty Info");
            Console.WriteLine("");
            f3.ShowInfo();
            f3.AddCredit(t, t1, t2, t3, t4, t5, t8, t12);
            f3.ShowAllCredits();
            Console.WriteLine("AIUB Software Solutions");

        }
    }

}
