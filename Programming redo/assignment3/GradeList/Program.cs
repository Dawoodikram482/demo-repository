namespace GradeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            List<Course> gradeList = ReadGradeList(3);
            Console.WriteLine();
            DisplayGradeList(gradeList);
        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            PracticalGrade practicalGrade = (PracticalGrade)Enum.Parse(typeof(PracticalGrade), input);
            return practicalGrade;
        }

        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.WriteLine(practical);
        }

        Course ReadCourse(string question)
        {
            Console.WriteLine(question);

            Course courseName = new Course();

            courseName.CourseName = ReadString("Enter name of your course: ");
            courseName.theoryGrade = ReadInt($"Enter your theory grade for {courseName.CourseName}: ");
            Console.WriteLine("0. None, 1. Absent, 2. Insufficient, 3. Sufficient, 4. Good");
            courseName.practicalGrade = ReadPracticalGrade($"Enter practical grade for {courseName.CourseName}: ");
            Console.WriteLine();
            return courseName;

        }

        void DisplayCourse(Course course)
        {
            Console.WriteLine($"{course.CourseName} : {course.theoryGrade}  {course.practicalGrade}");
        }

        List<Course> ReadGradeList(int nrOfCourses)
        {
            List<Course> list = new List<Course>();
            for (int i = 0; i < nrOfCourses; i++)
            {
                Course course = ReadCourse("Enter your result for course");
                list.Add(course);
            }
            return list;
        }

        void DisplayGradeList(List<Course> list)
        {
            int passedCourse = 0;
            int cumLaude = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Passed())
                {
                    passedCourse++;
                }
                if (list[i].CumLaude())
                {
                    cumLaude++;
                }

            }
            if (cumLaude == 3)
            {
                Console.WriteLine("Congratulations you graduated cum laude");
            }
            else if (passedCourse == 3)
            {
                Console.WriteLine("Congratulations you graduated");
            }
            else
            {
                Console.WriteLine($"Too bad, you did not graduate. You got {list.Count - passedCourse} retakes");
            }
        }

        string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }
    }
}