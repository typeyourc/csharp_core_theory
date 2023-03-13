using System.Security.Cryptography.X509Certificates;

namespace Lesson7_封装_静态成员
{
    class ClassObject
    {
        private static ClassObject onlyObj = new ClassObject();
        public int a = 10;
        
        public static ClassObject OnlyObj
        {
            get
            {
                return onlyObj;
            }

        }

        private ClassObject()
        {

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
   
            //ClassObject a = new ClassOject();已经实现无法实例化
            Console.WriteLine(ClassObject.OnlyObj.a);
        }
    }
}