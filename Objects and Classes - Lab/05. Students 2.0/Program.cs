namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (info != "end")
            {
                string[] infoArray = info.Split();//John Smith 15 Sofia

                string firstName = infoArray[0];
                string lastname = infoArray[1];
                int age = int.Parse(infoArray[2]);
                string homeTown = infoArray[3];

                bool studentExist = false;
                foreach (var student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastname)
                    {
                        student.Age = age;
                        student.HomeTown = homeTown;
                        studentExist = true;
                        break;
                    }
                }
                if (!studentExist) // exist
                {
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastname;
                    student.Age = age;
                    student.HomeTown = homeTown;
                    //foreach (var Student in students)
                    //{
                    //    if (Student.FirstName == firstName && Student.LastName == lastname)
                    //    {
                    //        Student.Age = age;
                    //        Student.HomeTown = homeTown;

                    //    }
                    //}
                    students.Add(student);
                }








                info = Console.ReadLine();
            }
            string hometown = Console.ReadLine();
            foreach (Student currentStudent in students)
            {
                if (currentStudent.HomeTown == hometown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }

        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
    
}