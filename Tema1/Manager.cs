namespace Tema1
{
    class Manager:Employee
    {
        public Manager(int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
        }

        public override string Salutation()
        {
            return "Hello manager!";
        }
    }
}
