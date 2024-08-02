namespace OOP {
    class Professor : Person {
        private string _employeeId;

        //default constructor
        public Professor() {
            _name = "";
            _age = 0;
            _employeeId = "";
        }

        //parameterized constructor
        public Professor(string name, int age, string employeeId) {
            _name = name;
            _age = age;
            _employeeId = employeeId;
        }

        //copy constructor
        public Professor(Professor p) {
            _name = p._name;
            _age = p._age;
            _employeeId = p._employeeId;
        }

        //function that prints the name, age, and id of the professor
         public override void Display() {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Employee ID: {_employeeId}");
        }

        //function that prints the name of the professor that is teaching
        public void Teach() {
            Console.WriteLine($"Professor {_name} is teaching!");
        }
    }
}