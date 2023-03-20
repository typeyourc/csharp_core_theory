using System.Text;

namespace Lesson24_面向对象相关_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            StringBuilder str = new StringBuilder("123456",4);
            Console.WriteLine(str);
            str.Replace("1", "x");
            Console.WriteLine(str);

        }
    }
}