using System;
namespace Mid_Term_Assignment
{
    public class Faculty
    {

        public string FacultyName { get; set; }
        public string FacultyId { get; set; }
        Weekly_Teaching_Hours[] weekly_Teaching_Hours;
        public int CreditCount { get; set; }
        public Faculty()
        {
            weekly_Teaching_Hours = new Weekly_Teaching_Hours[112];
        }
        public Department Department { get; set; }

        public Faculty(string facultyName, string facultyId)
        {
            this.FacultyName = facultyName;
            this.FacultyId = facultyId;
            weekly_Teaching_Hours = new Weekly_Teaching_Hours[112];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + FacultyName);
            Console.WriteLine("Id:" + FacultyId);
        }
        public void AddCredit(params Weekly_Teaching_Hours[] weekly_Teaching_Hours)
        {
            foreach (var a in weekly_Teaching_Hours)
            {
                if (CreditCount < 6)
                {
                    this.weekly_Teaching_Hours[CreditCount++] = a;

                }
                else
                {
                    Console.WriteLine("Student Can't Take More Than 21 Credits");
                    Console.WriteLine("Student Can't take any more course credit: " + a.CreditCount);
                }

            }
        }
        public void ShowAllCredits()
        {
            Console.WriteLine();
            for (int i = 0; i < CreditCount; i++)
            {
                weekly_Teaching_Hours[i].ShowInfo();
            }
            Console.WriteLine();
        }
    }

}
