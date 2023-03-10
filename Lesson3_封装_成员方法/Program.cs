using System.ComponentModel;

namespace Lesson3_封装_成员方法
{
    class Person
    {

        public string name;
        public Person[] friends;

        //成员方法-说话
        public void SayHello()
        {
            Console.WriteLine("Hello, I'm " + name);
        }

        //成员方法-添加朋友
        public void AddOneFriend(Person p)
        {
            if(friends == null)
            {
                friends = new Person[1];
                friends[0] = p;
            }
            else if (friends != null)
            {
                Person[] p1 = new Person[friends.Length + 1];
                for (int i = 0; i < friends.Length; i++)
                {
                    p1[i] = friends[i];
                }
                p1[p1.Length - 1] = p;
                friends = p1;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Person person = new Person();
            person.name = "Test";

            Person person1 = new Person();
            person1.name = "Test1";

            Person person2 = new Person();
            person2.name = "Test2";

            //注意下面这句，不能直接写  person.friends[0] = person1;，必须先new
            person.friends= new Person[1];
            person.friends[0] = person1;

            Console.WriteLine(person.friends[0].name);

            person.AddOneFriend(person2);
            Console.WriteLine(person.friends[1].name);
        }
    }
}