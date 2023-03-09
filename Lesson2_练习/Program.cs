namespace Lesson2_练习
{
    class Person
    {
        public string name;
        public int height;
        public int age;
        public string adress;
    }
    class Student
    {
        public string name;
        public int id;
        public int age;
        public Person[] deskmates;
    }

    class Classis
    {
        public string nameMajor;
        public int numOfteacher;
        public int numOfstudent;
        public Student[] students;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //练习一：public、private、protected

            //练习二
            Person p1 = new Person();
            Person p2 = new Person();

            //练习三
            Student s1 = new Student();
            Student s2 = new Student();

            //练习四
            Classis p3 = new Classis();
            p3.students = new Student[] { s1, s2 };

            //练习五
            //p.age = 10;

            //练习六★
            //p.age = 20;

            //练习七
            //s.age = 10;

            //练习八
            //s.deskmate.age = 20;
        }
    }
}