namespace Lesson2_封装_成员变量和访问修饰符
{
    struct Pet
    {
        public Pet()
        {

        }
    }
    class Person
    {
        //特征——成员变量
        //姓名
        string name = "唐老师";
        //年龄
        int ages;
        //女朋友
        Person girlFriend;
        //朋友
        Person[] friends;
        public Pet pet;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine(default(int));
            //× Console.WriteLine(default(Person.pet)); Person.pet是错误的不知为啥，知道了，需要先把类实例化成对象
            //× Person.pet = new Pet();  Person.pet是错误的不知为啥，知道了，需要先把类实例化成对象

            //正确的√
            Person p = new Person();
            p.pet = new Pet();

            //接上面，如下即使示例化了之后的写法是错误的，因为pp是变量，不是类型，Pet和Person是类型
            //Person p;
            //Pet pp;
            //× Console.WriteLine(default(pp));
            Console.WriteLine(default(Person));//正确的√
            Console.WriteLine(default(Pet));//正确的√
        }
    }
}