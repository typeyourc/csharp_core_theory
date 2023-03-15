using System.Xml;

namespace Lesson14_继承_继承中的构造函数
{   
    class Laborer
    {
        public string occupation;
        public string responsibility;

        public Laborer(string str1,string str2) 
        { 
            occupation = str1;
            responsibility = str2;            
        }
        public void WorkMethod()
        {
            Console.WriteLine("我的职责是{0}", responsibility);
        }
    }
    class Programmer : Laborer
    {
        public Programmer(string str1, string str2) : base(str1, str2)
        {
            Console.WriteLine("我是程序员");
        }
    }
    class Designer : Laborer
    {
        public Designer(string str1, string str2) : base(str1, str2)
        {
            Console.WriteLine("我是策划");
        }
    }
    class FineArtist : Laborer
    {
        public FineArtist(string str1, string str2) : base(str1, str2)
        {
            Console.WriteLine("我是美术");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Programmer p = new Programmer("程序员","编程");
            p.WorkMethod();
            Designer d = new Designer("策划", "玩法策划");
            d.WorkMethod();
            FineArtist f = new FineArtist("美术", "建模");
            f.WorkMethod();

        }
    }
}