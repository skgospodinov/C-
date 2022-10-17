using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("This is not a name");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lastName;
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("This is not a name");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("This is not a valid age");
                }
                this.age = value;
            }
        }
        public decimal Salary
        {
            get => this.salary;
            set
            {
                if (value < 50)
                {
                    throw new ArgumentException("This is not a valid salary");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                percentage /= 2;
            }
            Salary += Salary * percentage / 100;
        }
    }
}
