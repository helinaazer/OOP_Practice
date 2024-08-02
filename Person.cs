namespace OOP {
    class Person {
        protected string _name;
        protected int _age;

        public Person() {
            _name = "";
            _age = 0;
        }
        public Person(string name, int age) {
            _name = name;
            _age = age;
        }

        public virtual void Display() {
            Console.WriteLine($"Name: {_name}, Age {_age}");
        }

        public void CelebrateBirthday() {
            _age++;
            Console.WriteLine($"Happy Birthday, {_name}! You turned {_age}!");
        }
    }
}