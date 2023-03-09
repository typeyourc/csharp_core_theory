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
            //× Console.WriteLine(default(Person.pet));
            Person.pet = new Pet();
        }
    }
}