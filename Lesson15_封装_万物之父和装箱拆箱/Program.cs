namespace Lesson15_封装_万物之父和装箱拆箱
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            object a = 1;
            int b = (int)a;

            object c = new int[88];
            int[] d = c as int[];

        }
    }
}