namespace assignment1_week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program=new Program();
            program.Start();
        }
        void Start()
        {
            int value = ReadInt("Enter a value: ");
            Console.WriteLine($"{value}");

            int age = ReadInt("Enter your age: ", 1, 120);
            Console.WriteLine($"you are {age} years old");

            string name = ReadString("Enter your name: ");
            Console.WriteLine($"Nice to meet you{name}");
        }
        int ReadInt(string question)
        {
            Console.WriteLine(question);
            int value  = int.Parse(Console.ReadLine());
            return value;
        }
        int ReadInt(string question, int min, int max)
        {
            Console.WriteLine(question);
            int age = int.Parse(Console.ReadLine());

            while (age<min || age>max)
            {
                age = ReadInt(question);
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