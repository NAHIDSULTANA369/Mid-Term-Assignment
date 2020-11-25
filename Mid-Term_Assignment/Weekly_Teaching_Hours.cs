using System;
namespace Mid_Term_Assignment
{
    public class Weekly_Teaching_Hours
    {
        public string CourseName { get; set; }
        public int CourseCreditNumber { get; set; }
        public Department Department { get; set; }
        Course[] courses;
        public int CreditCount { get; set; }
        public Weekly_Teaching_Hours()
        {
            courses = new Course[5];
        }
        public Weekly_Teaching_Hours(string courseName, int courseCreditNumber, Department department)
        {
            CourseName = courseName;
            CourseCreditNumber = courseCreditNumber;
            Department = department;
            courses = new Course[5];
        }
        public void AddWeeklyTeachingHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 6)
                    this.courses[CreditCount++] = course;
            }

        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNumber);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
    }
}
