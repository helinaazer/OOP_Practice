namespace OOP {
    class Student : Person, UniversityMemeber {
        private string _studentId;

        //default constructor
        public Student() {
            _name = "";
            _age = 0;
            _studentId = "";
        }

        //parameterized constructor
        public Student(string name, int age, string studentId) {
            _name = name;
            _age = age;
            _studentId = studentId;
        }

        //copy construcor
        public Student(Student s) {
            _name = s._name;
            _age = s._age;
            _studentId = s._studentId;
        }

        //function that prints the name, age, and id of the student
        public override void Display() {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Student ID: {_studentId}");
        }

        //function that prints the name of the student studying
        public void Study() {
            Console.WriteLine($"Student {_name} is studying!");
        }

        public new void DisplayRole() {
            Console.WriteLine($"The role of {_name} is a student.");
        }
    }
}