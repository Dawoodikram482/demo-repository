namespace assignment1_week4
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
            DisplayGradeList(gradeList);
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
            int grades = int.Parse(Console.ReadLine());
            return grades;
        }
        PracticalGrade ReadPracticalGrade(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            PracticalGrade practicalGrade = (PracticalGrade)(Enum.Parse(typeof(PracticalGrade), input));
            return practicalGrade;
        }
        void DisplayPracticalGrade(PracticalGrade practical) 
        {
            Console.Write(practical);
        }
        Course ReadCourse(string question)
        {
            
            Console.Write(question);
            Console.WriteLine();
            Course course= new Course();
            course.courseName = ReadString("Name of Course: ");
            course.theoryGrade = ReadInt($"Theory Grade for {course.courseName}");
            Console.Write("0. None, 1. Absent, 2. Insufficient, 3. Sufficient, 4. Good");
            course.practicalGrade= ReadPracticalGrade($"Practical grade for the {course.courseName}");
            return course;
        }
        void DisplayCourse(Course course)
        {
            Console.WriteLine($"{course.courseName} : {course.theoryGrade}  {course.practicalGrade}");
        }

        List<Course> ReadGradeList(int nrOfCourses)
        {
            List<Course> list = new List<Course>();
            for(int i = 0; i< nrOfCourses; i++)
            {
                Course course = ReadCourse("Enter a course");
                list.Add(course);
            }
            return list;
        }
        void DisplayGradeList(List<Course> list)
        {
            int passedCourse = 0;
            int cumLaude = 0;
            for (int i = 0; i<list.Count;i++)
            {
                DisplayCourse(list[i]);

                if (list[i].Passed())
                {
                    passedCourse++;
                }
                if (list[i].CumLaude()) 
                {
                    cumLaude++;
                }

                if (passedCourse < 3)
                {
                    Console.WriteLine($"Too bad, you didn't graduate, you got {list.Count - passedCourse} retakes");
                }
                else if (cumLaude == 3)
                {
                    Console.WriteLine("Congratulations, you graduated Cum Laude");
                }
                else
                {
                    Console.WriteLine("Congratulations, you graduated!");
                }
            }
        }
    }
}