using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] personInfo = command.Split();
                string name = personInfo[0];
                string Id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                bool isIdExists = false;
                foreach(Person currPerson in persons)
                {
                    if (currPerson.ID == Id)
                    {
                        //This ID already exists, update name and age.
                        currPerson.Name = name;
                        currPerson.Age = age;
                        isIdExists = true;
                    }
                }

                if (!isIdExists)
                {
                    Person person = new Person(name, Id, age);
                    persons.Add(person);
                }
            }

            foreach(Person person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
}
