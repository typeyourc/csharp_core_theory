namespace 测试专用4
{
    interface IFly
    {
        void Fly();

        string Name
        {
            get; set;
        }
        int this[int idex]
        {
            get;set;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


        }
    }
}