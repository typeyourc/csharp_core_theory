namespace Lesson9_封装_拓展方法
{
    //练习一
    static class MyInt
    {
        public static int SquareInt(this int a)
        {
            return a * a;
        }
    }
    //练习二
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public void Atk()
        {

        }
        public void Move()
        {

        }
        public void Injure()
        {

        }
    }
    static class Tools
    {
        public static void Suicide(this Player a)
        {
            Console.WriteLine("{0}自杀成功！", a.name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //练习一
            int a = 100;
            Console.WriteLine(a.SquareInt());

            //练习二
            Player p1 = new Player();
            p1.name = "往大锤";
            p1.Suicide();
            
        }
    }
}