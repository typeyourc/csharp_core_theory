namespace Lesson10_封装_运算符重载
{
    //练习一
    class Positon
    {
        public int x;
        public int y;

        public static bool operator ==(Positon p1, Positon p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Positon p1, Positon p2)
        {
            if (p1.x != p2.x && p1.y != p2.y)
            {
                return true;
            }
            return false;
        }
    }
    //练习二
    class Vector3
    {
        public int x, y, z;

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x + v2.x;
            v3.y = v1.y + v2.y;
            v3.z = v1.z + v2.z;
            return v3;
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x - v2.x;
            v3.y = v1.y - v2.y;
            v3.z = v1.z - v2.z;
            return v3;
        }
        public static Vector3 operator *(Vector3 v1, int num)
        {
            Vector3 v2 = new Vector3();
            v2.x = v1.x * num;
            v2.y = v1.y * num;
            v2.z = v1.z * num;
            return v2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region 练习一
            //Positon p1 = new Positon();
            //p1.x = 1;
            //p1.y = 2;
            //Positon p2 = new Positon();
            //p2.x = 1;
            //p2.y = 0;
            //if (p1 == p2)
            //{
            //    Console.WriteLine("p1 == p2");
            //}
            //else
            //{
            //    Console.WriteLine("p1 != p2");
            //}
            #endregion

            #region 练习二
            Vector3 v1 = new Vector3();
            Vector3 v2 = new Vector3();
            v1.x = 1;
            v1.y = 1;
            v1.z = 1;
            v2.x = 3;
            v2.y = 4;
            v2.z = 5;
            Vector3 v3 = new Vector3();
            v3 = v1 + v2;
            Console.WriteLine(v3.x);
            Console.WriteLine(v3.y);
            Console.WriteLine(v3.z);

            Vector3 v4 = new Vector3();
            v4 = v1 - v2;
            Console.WriteLine(v4.x);
            Console.WriteLine(v4.y);
            Console.WriteLine(v4.z);

            Vector3 v5 = new Vector3();
            v5 = v1 * 5;
            Console.WriteLine(v5.x);
            Console.WriteLine(v5.y);
            Console.WriteLine(v5.z);

            #endregion
        }
    }
}