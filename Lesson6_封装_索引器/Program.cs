namespace Lesson6_封装_索引器
{
    class Person
    {
        private string name;
        private int age;
        private Person[] friends;

        public Person this[int index]
        {
            get
            {
                return friends[index];
            }
            set
            {
                //如果friends为空的判断
                if (friends == null)
                {
                    friends = new Person[] { value};
                }
                friends[index] = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Person[] Friends
        {
            get
            { 
                return friends; 
            }

            set 
            { 
                friends = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 可以正确输出的写法
            //Person p1 = new Person();
            //p1.Name = "Test1";
            //p1.Age = 10;
            //p1.Friends = new Person[2] { new Person() { Name = "Test2", Age = 20 }, 
            //                             new Person() { Name = "Test3", Age = 18 } };
            //p1[1] = new Person() { Name = "Test4", Age = 30 };

            //Console.WriteLine(p1[1].Age);
            #endregion

            #region 另一种输出报错的写法
            Person p2 = new Person();
            p2.Name = "Test22";
            p2.Age = 20;
            //注意p2的friends为null

            Person p1 = new Person();
            p1.Age = 23;
            p1.Name = "Test11";
            p1.Friends = new Person[] { p2 };
            //p1的friends不为null

            Person p = new Person();
            p.Age = 10;
            p.Name = "Test00";
            p.Friends = new Person[] { p1 };//句子1
            //p[0] = new Person();//句子2
            //如上两句，如果只写句子2会出错，在执行索引器的set的时候会报错，因为相当于friends[index] = value，这里面的friends为空，没有索引。只用句子1就对
            //另外，如果想用句子1，需要在索引器的set中加上为空的判断，如上面索引器的标注。
            p[0] = p2;

            Console.Write(p[0].Name);
            #endregion

        }
    }
}