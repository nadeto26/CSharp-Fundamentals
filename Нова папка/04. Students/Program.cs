namespace _04._Students
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

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastname;
                student.Age = age;
                student.HomeTown = homeTown;




                students.Add(student);
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