namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            int value = ReadInt("enter a value:");
            Console.WriteLine($"You entered {value}");

            int age = ReadInt("Enter your age", 0, 120);
            Console.WriteLine($"you are {age} years old");

            string name = ReadString("enter your name:");
            Console.WriteLine($"nice meeting you {name}");
        }
        int ReadInt(string question)
        {
            Console.WriteLine(question);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        int ReadInt(string quesion, int min, int max)
        {
            Console.WriteLine(quesion);
            int age = int.Parse(Console.ReadLine());

            while (age<min || age > max)
            {
                age = ReadInt(quesion);
            }
            return age;
        }
        string ReadString(string question)
        {
            Console.WriteLine(question);
            string name = Console.ReadLine();
            return name;

        }
    }
}