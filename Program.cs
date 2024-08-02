using System.ComponentModel.DataAnnotations;

namespace OOP {
    class Program {
        public static void Main(String[] args) {
            Person p1 = new Person("Helina", 22);
            p1.Display();
            p1.CelebrateBirthday();

            Student s1 = new Student("bob", 57, "1234");
            s1.Display();
            s1.Study();

            Professor pro1 = new Professor("Alice", 40, "9876");
            pro1.Display();
            pro1.Teach();
        }
    }
}