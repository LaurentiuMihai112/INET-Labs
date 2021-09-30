using System;

namespace Tema1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee manager = new Manager(1, "Laurentiu", "Mihai");
            Console.WriteLine(manager.Salutation());
            Console.WriteLine(manager.GetFullName());
            Employee architect = new Architect(2, new DateTime(2021, 09, 28, 18, 15, 0),
                new DateTime(2021, 10, 28, 9, 15, 0));
            architect.FirstName = "Marian";
            architect.LastName = "Iosub";
            Console.WriteLine("The employee with id: " + architect.Id + " is now active: " + architect.IsActive());
            Console.WriteLine(architect.Salutation());


            const string sentence = "This line will be split using an extension method";
            Console.WriteLine(sentence);
            Console.WriteLine($"The line has {sentence.ComputeWords()} tokens");
        }
    }
}