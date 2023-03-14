namespace Lesson12_继承_继承的基本规则
{
    class People
    {
        public string name;
        public int age;

        public void Speak()
        {
            Console.WriteLine("我是{0}", name);
        }
    }
    class Warrior : People
    {
        public void Atk()
        {
            Console.WriteLine("我可以攻击");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Warrior w = new Warrior();
            w.name = "战士";
       
            w.Speak();
            w.Atk();

        }
    }
}