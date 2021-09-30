using System;

namespace Tema1
{
    abstract class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _startDate;
        private DateTime _endDate;
        private double _salary;
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public DateTime EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }

        protected Employee()
        {
        }

        protected Employee(int id, DateTime startDate, DateTime endDate)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
        }

        protected Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return "The name of employee with id: " + Id + " is " + FirstName + " " + LastName;
        }

        public bool IsActive()
        {
            return EndDate.CompareTo(DateTime.Now) > 0;
        }

        public abstract string Salutation();
        // this method could have been virtual but then the derived class would not necessarily have to override it
        // and the result would not necessarily be the one desired (“Hello” + manager or “Hello” + architect)
        // because it is possible that no further implementation in the derived classes is provided.
    }
}