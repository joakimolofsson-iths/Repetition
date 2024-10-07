namespace Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            Console.WriteLine("Type three names!");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Name {i+1}:");
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            foreach(Person person in persons)
            {
                Console.WriteLine($"Hello! My name is {person.ToString()}.");
            }
        }

        class Person
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
