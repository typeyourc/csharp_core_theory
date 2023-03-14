namespace Lesson12_继承_继承的基本规则
{
    class People
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public void Speak()
        {
            Console.WriteLine("我是{0}", Name);
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
            w.Name = "战士";
       
            w.Speak();
            w.Atk();

        }
    }
}