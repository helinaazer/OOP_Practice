using System;

namespace OOP {
    class Person : UniversityMemeber {
        protected string _name;
        protected int _age;

        //default constructor
        public Person() {
            _name = "";
            _age = 0;
        }

        //parameterized constructor
        public Person(string name, int age) {
            _name = name;
            _age = age;
        }

        //copy constructor
        public Person(Person p) {
            _name = p._name;
            _age = p._age;
        }

        //function that prints the name and age of the person
        public virtual void Display() {
            Console.WriteLine($"Name: {_name}, Age {_age}");
        }

        //function that increments the age of the person if it is their birthday
        public void CelebrateBirthday() {
            _age++;
            Console.WriteLine($"Happy Birthday, {_name}! You turned {_age}!");
        }

        //function that calls the display function of the passed object
        public static void PrintPersonDetails(Person p) {
            p.Display();
        }

        public void DisplayRole() {
            Console.WriteLine($"The role of {_name} is a person.");
        }
    }
}