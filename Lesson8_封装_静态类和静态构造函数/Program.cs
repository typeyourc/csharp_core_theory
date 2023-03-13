namespace Lesson8_封装_静态类和静态构造函数
{
    static class Math
    {
        public static float PI;

        static Math()
        {
            PI = 3.14f;
            Console.WriteLine("调用次数");
        }

        public static float AreaOfCircle(float r)
        {
            return PI * r * r;
        }
        public static float PeriOfCircle(float r)
        {
            return PI * r * 2;
        }
        public static float AreaOfRect(float width, float height)
        {
            return width * height;
        }
        public static float PeriOfRect(float width, float height)
        {
            return 2 * (width + height);
        }
        public static float Abs(float num)
        {
            return num > 0 ? num : (-num);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-9));
            Console.WriteLine(Math.AreaOfCircle(2));

            //Math a = new Math();

        }
    }
}