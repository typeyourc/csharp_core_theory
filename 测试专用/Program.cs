namespace 测试专用
{
    class MyClass
    {
        public int a;
        public int b;
        public MyClass[] arrs = new MyClass[] { };

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("测试专用专用程序");

            MyClass myClass = new MyClass();
            MyClass arr1 = new MyClass();
            if (myClass.arrs.Length == 0)
            {
                Console.WriteLine(myClass.arrs);
            }
            
        }
    }
}