namespace assignment3_week1
{
    internal class Program
    {
        const int lengthOfArray = 3;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

        }
        void Start()
        {
            Person[] people = ReadPerson();
            Console.WriteLine();
            PrintPerson(people);
        }
        Person [] ReadPerson()
        {
            Person[] mypersons = new Person[lengthOfArray];
            for (int i = 0; i<mypersons.Length; i++)
            {
                mypersons[i].FirstName = ReadString("Enter your First name: ");
                mypersons[i].LastName = ReadString("Enter your last name: ");
                mypersons[i].gender = ReadGender("Enter your gender: ");
                mypersons[i].City = ReadString("Enter your city: ");
                mypersons[i].Age = ReadInt("Enter your age: ");
                Console.WriteLine();
            }
            return mypersons;
        }

        void PrintPerson(Person[] persons)
        {
            for (int i = 0; i<persons.Length; i++)
            {
                Console.WriteLine($"{persons[i].FirstName} {persons[i].LastName}");
                PrintGender(persons[i].gender);
                Console.WriteLine($"{persons[i].Age} {persons[i].City}");
                Console.WriteLine();
            }
        }

        GenderType ReadGender(string question)
        {
            Console.WriteLine(question);
            GenderType gender = (GenderType) Enum.Parse(typeof(GenderType),Console.ReadLine());
            return gender;
        }
        void PrintGender(GenderType gender)
        {
            Console.WriteLine($"{gender}");
        }

        int ReadInt(string question)
        {
            Console.WriteLine(question);
            int age = int.Parse(Console.ReadLine());
            return age;
        }
        string ReadString(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
    }
}