using System;

namespace Assignment
{
    // This program demo. how to create Aggregation
    class Aggregation
    {
        static void Main()
        {
            Students student1 = new Students(500, "Rachana");
            School school1 = new School("Vivekananda", 12);
            Console.WriteLine($"{ school1.SchoolName} school has total classrooms of : {school1.NoOfClassrooms}");
            Console.ReadLine();
        }
    }
    class School
    {
        public string SchoolName { get; set; }
        public int NoOfClassrooms { get; set; }
        public School(string schoolName, int noOfClassrooms)
        {
            this.SchoolName = schoolName;
            this.NoOfClassrooms = noOfClassrooms;

        }

    }
    class Students
    {
        public int NoOfStudents { get; set; }
        public string StudentName { get; set; }
        public Students(int noOfStudents, string studentName)
        {
            this.NoOfStudents = noOfStudents;
            this.StudentName = studentName;
        }

    }
}
