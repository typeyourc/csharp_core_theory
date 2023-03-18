namespace 测试专用
{
    class Son
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("测试专用专用程序");
            TestFun(1, 2, 3, 4f, 2.3, "123", new Son());
        }

        //验证用万物之父object多类型多参数传递
        static void TestFun(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is int)
                {
                    Console.WriteLine("{0}我是整形参数", array[i]);
                }
                else if (array[i] is Single)
                {
                    Console.WriteLine("{0}我是单精度类型参数", array[i]);
                }
                else if (array[i] is double)
                {
                    Console.WriteLine("{0}我是双精度类型参数", array[i]);
                }
                else if (array[i] is string)
                {
                    Console.WriteLine("{0}我是字符串类型参数", array[i]);
                }
                else if (array[i] is Son)
                {
                    Console.WriteLine("{0}我是Son类参数", array[i]);
                }

            }
        }
    }
}