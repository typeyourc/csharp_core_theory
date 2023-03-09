namespace Lesson1
{
    #region 类的申明
    class People
    {
        //特征——成员变量
        //行为——成员方法
        //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lesson1_类和对象");
            //github test

            People p1 = new People();
            People p2;
            p2 = p1;
            p2 = null;
        }
    }
}