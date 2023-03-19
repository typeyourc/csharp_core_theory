using System;
using static System.Net.Mime.MediaTypeNames;
//练习二
class Monster
{
    public int atk;
    public int def;
    public int hp;
    public int skillID;

    public MyClass m = new MyClass();

    public Monster Clone()
    {
        return base.MemberwiseClone() as Monster;
    }
}

class MyClass
{
    public int a = 1;
}

//练习一
class Player
{
    public string name;
    public int hp;
    public int atk;
    public int def;
    public float evasion;
    public Player(string name, int hp, int atk, int def, float evasion)
    {
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.evasion = evasion;
    }
    public override string ToString()
    {
       return "玩家"+name+","+ "血量" + hp + "," + "攻击力" + atk + "," + "防御力" + def + "," + "闪避率" + evasion;
    }
}
namespace Lesson22_面向对象相关_万物之父中的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //练习一
            Player player = new Player("哈哈哈", 100, 99, 99, 0.2f);
            Console.WriteLine(player.ToString());

            //练习二
            Monster A = new Monster();
            A.atk = 100;
            Monster B = A.Clone();
            Console.WriteLine(B.atk);
            Console.WriteLine(B.atk);

            B.atk = 200;
            Console.WriteLine(A.atk);
            Console.WriteLine(B.atk);

            //改一下问题，如果Monster类里有引用类型变量，如何保持相同对象改动原先不变
            Monster C = new Monster();
            Console.WriteLine(A.m.a);
            Console.WriteLine(C.m.a);

            C.m.a = 2;
            Console.WriteLine(A.m.a);
            Console.WriteLine(C.m.a);


        }
    }
}