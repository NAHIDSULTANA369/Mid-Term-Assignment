using System;
namespace Mid_Term_Assignment
{
    public class Course
    {
        public int Number { get; set; }

        private int courseId;
        public int CourseId { get; set; }

        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private int courseCredit;
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

        private double courseWeeklyTeachingHours;

        public double CourseTeachingHours
        {
            get { return courseWeeklyTeachingHours; }
            set { courseWeeklyTeachingHours = value; }
        }

        private Section[] sections;
        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }

        public Course()
        {
            sections = new Section[5];
            sectionCount = 0;
        }

        public Course(string courseName, int courseId, int courseCredit, double courseWeeklyTeachingHours)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseWeeklyTeachingHours = courseWeeklyTeachingHours;

            sections = new Section[5];
            sectionCount = 0;
        }

        public Course(string courseName, int courseId, int courseCredit, double courseTeachingHours, int Number)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseWeeklyTeachingHours = courseWeeklyTeachingHours;
            this.Number = Number;

            sections = new Section[5];
            sectionCount = 0;
        }

        public void AddScetion(params Section[] sections)
        {
            foreach (var a in sections)
            {
                if (sectionCount < 10)
                {
                    this.sections[sectionCount++] = a;
                }
                else
                {
                    Console.WriteLine("Section can not be entered");
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Id : " + courseId);
            Console.WriteLine("Course Credit : " + courseCredit);
            Console.WriteLine("Course Weekly Teaching Hours : " + courseWeeklyTeachingHours);

        }
        public void AddCourseNumber(int x)
        {
            Number += x;
        }
    }

}
