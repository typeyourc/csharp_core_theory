using UI;
namespace UI
{
    class Image
    {

    }
}
namespace Graph
{
    class Image
    {

    }
}
namespace Lesson21_面向对象相关_命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //练习一：using的用处，引入某个命名空间

            Image image = new Image();
            Graph.Image image1 = new Graph.Image();

        }
    }
}