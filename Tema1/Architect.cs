using System;

namespace Tema1
{
    class Architect : Employee
    {
        public Architect(int id, DateTime startDate, DateTime endDate) : base(id, startDate, endDate)
        {
        }

        public override string Salutation()
        {
            return "Hello architect!";
        }
    }
}