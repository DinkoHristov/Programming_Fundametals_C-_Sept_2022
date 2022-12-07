using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            if (family.Persons.Count > 0)
            {
                Person oldestMember = family.GetOldestMember();
                Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            }
        }
    }

    public class Family
    {
        private readonly List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public List<Person> Persons
            => this.persons;

        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.Persons.OrderByDescending(x => x.Age).First();

            return oldestPerson;
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
