namespace OOP {
    class Student : Person {
        private string _studentId;

        public Student() {
            _name = "";
            _age = 0;
            _studentId = "";
        }

        public Student(string name, int age, string studentId) {
            _name = name;
            _age = age;
            _studentId = studentId;
        }

        public override void Display() {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Student ID: {_studentId}");
        }

        public void Study() {
            Console.WriteLine($"Student {_name} is studying!");
        }
    }
}