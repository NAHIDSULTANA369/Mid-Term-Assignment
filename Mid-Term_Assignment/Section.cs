using System;
namespace Mid_Term_Assignment
{
    public class Section
    {
        private string secName;

        public string SecName
        {
            get { return secName; }
            set { secName = value; }
        }

        protected double sectionWeeklyTeachingHours;
        public double SectionTeachingHours
        {
            get { return sectionWeeklyTeachingHours; }
            set { sectionWeeklyTeachingHours = value; }
        }
        public Section()
        {
        }
        public Section(string secName, string courseName, int courseId, int courseCredit, double courseWeeklyTeachingHours)
            
        {
            this.secName = secName;
            this.sectionWeeklyTeachingHours = sectionWeeklyTeachingHours;
        }
        virtual public void ShowSectionInfo()
        {
            Console.WriteLine("Sec Name:" + secName);

        }
    }

}
