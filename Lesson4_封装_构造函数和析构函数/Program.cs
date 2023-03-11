namespace Lesson4_封装_构造函数和析构函数
{
    //人-类
    class Person
    {
        public string name;
        public int age;

        //构造函数-当写了有参数的构造函数后，无参的构造函数失效
        //public Person()
        //{
        //    name = "唐老师";
        //    age = 18;
        //}
        //构造函数重载
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }

    //班级-类
    class Classis
    {
        public string nameMajor;
        public int numOfTeacher;
        public int numOfStudent;
        public Person[] students;

        //构造函数-当写了有参数的构造函数后，无参的构造函数失效
        //public Classis()
        //{
        //    nameMajor = "计算机";
        //    numOfTeacher = 1;
        //    numOfStudent = 20;
        //    students = new Person[numOfStudent];
        //}
        //构造函数重载
        public Classis(string nameMajor, int numOfTeacher, int numOfStudent, Person[] stu)
        {
            this.nameMajor = nameMajor;
            this.numOfTeacher = numOfTeacher;
            this.numOfStudent = numOfStudent;
            students = stu;
        }
    }

    //票-类
    class Ticket
    {
        public ulong distance;
        public float price;

        //构造函数
        public Ticket(ulong distance)
        {
            this.distance = distance;
            price = GetPrice();
        }

        //成员参数
        private float GetPrice()
        {
            if (distance <= 100)
            {
                price = distance * 1.0f;
            }
            else if (distance >= 101 && distance <= 200)
            {
                price = 0.95f * distance * 1.0f;
            }
            else if (distance >= 201 && distance <= 300)
            {
                price = 0.9f * distance * 1.0f;
            }
            else if (distance >= 301)
            {
                price = 0.8f * distance * 1.0f;
            }
            return price;
        }
        //方法2
        public void ShowPrice()
        {
            Console.WriteLine("{0}公里{1}块钱", distance, price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Person p = new Person();

            //GC.Collect();

            //练习一
            Person p2 = new Person("李白",10);
            //p2.name = "唐老师";
            Person p3 = new Person("汪伦",18);
            //Console.WriteLine(p2.name + " " + p3.name);

            //练习二
            Person[] stu = new Person[2] { p2, p3 };

            Classis classis = new Classis("化学", 1, 2, stu);

            Console.WriteLine("{0}班，学生数量{1},老师数量{2}",classis.nameMajor,classis.numOfStudent,classis.numOfTeacher);

            //练习三
            Ticket ticket = new Ticket(500);
            
            ticket.ShowPrice();
        }
    }
}