namespace 测试专用3
{
    class Monster
    {
        public int atk;
        public int def;
        public int hp;
        public int skillID;

        public MyClass n;

        public Monster(int atk, int def, int hp, int skillID, MyClass n)
        {
            this.atk = atk;
            this.def = def;
            this.hp = hp;
            this.skillID = skillID;
            this.n = n;
        }

        public Monster Clone(MyClass n)
        {
            //相当于在克隆Monster的时候，把Monster里的引用变量也克隆了一个实例，所以后续更改克隆体的引用变量值不会影响原体的引用变量的值
            return new Monster(atk, def,  hp, skillID, n.Clone());
            //return MemberwiseClone() as Monster;
        }
    }

    class MyClass
    {
        public int a = 1;
        public MyClass Clone()
        {
            return new MyClass();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            MyClass my = new MyClass();
            Monster m = new Monster(8, 9, 10, 11, my);
            Console.WriteLine(m.atk + " " + m.def + " " + m.hp+ " " + m.skillID + " " + m.n);
            Console.WriteLine(m.n.a);

            //生成m的克隆体m2
            Monster m2 = m.Clone(my);
            //测试m2现在的成员值
            Console.WriteLine(m2.atk + " " + m2.def + " " + m2.hp + " " + m2.skillID + " " + m2.n);
            Console.WriteLine(m2.n.a);

            //更改m2的引用成员的值
            m2.n.a = 9;
            //查看m和m1当下引用成员的值
            Console.WriteLine(m.n.a);
            Console.WriteLine(m2.n.a);
        }
    }
}