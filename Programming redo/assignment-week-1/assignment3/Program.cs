namespace assignment3
{
    internal class Program
    {
        const int length = 3;
        static void Main(string[] args)
        {
           Program program = new Program();
            program.Start();
        }
        void Start()
        {
            Person[] myPersons = ReadPerson();
            PrintPerson(myPersons);
        }
        Person [] ReadPerson()
        {
            Person [] persons = new Person[length];
            for (int i = 0; i < length; i++)
            {
                persons[i].FirstName = ReadString("Enter your first name:");
                persons[i].LastName = ReadString("Enter your last name:");
                persons[i].City = ReadString("Enter name of your city:");
                persons[i].Gender = ReadGenderType("Enter your gender");
                persons[i].age = ReadInt("Enter your age: ");
                Console.WriteLine();
            }
            return persons;
        }
        void PrintPerson(Person [] persons)
        {
            for (int i = 0; i< persons.Length;i++)
            {
                Console.Write($"{persons[i].FirstName} {persons[i].LastName} ");
                PrintGender(persons[i].Gender);

                Console.WriteLine();

                Console.WriteLine($"{persons[i].age} years old, {persons[i].City}");

                Console.WriteLine();
            }
        }
        GenderType ReadGenderType(string question)
        {
            Console.WriteLine(question);
            GenderType gender = (GenderType)(Enum.Parse(typeof(GenderType), Console.ReadLine()));
            return gender;

        }
        void PrintGender(GenderType gender)
        {
            Console.WriteLine($"{gender}");
        }
        string ReadString(string question)
        {
            Console.WriteLine(question);
            string result = Console.ReadLine();
            return result;
        }
        int ReadInt(string question)
        {
            Console.WriteLine(question);
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
    }
}