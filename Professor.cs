namespace OOP {
    class Professor : Person {
        private string _employeeId;

        public Professor() {
            _name = "";
            _age = 0;
            _employeeId = "";
        }

        public Professor(string name, int age, string employeeId) {
            _name = name;
            _age = age;
            _employeeId = employeeId;
        }

         public override void Display() {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Employee ID: {_employeeId}");
        }

        public void Teach() {
            Console.WriteLine($"Professor {_name} is teaching!");
        }
    }
}