namespace 测试专用2
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Skill(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public object Clone()
        {
            return new Skill(ID, Name);
        }
    }
    public class Monster
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public Skill Skill { get; set; }

        public Monster(int attack, int defense, int health, Skill skill)
        {
            Attack = attack;
            Defense = defense;
            Health = health;
            Skill = skill;
        }

        public object Clone()
        {
            Skill clonedSkill = (Skill)Skill.Clone();
            return new Monster(Attack, Defense, Health, clonedSkill);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Monster m = new Monster(100, 100, 100, new Skill(1, "火球术"));
            //Monster m2 = (Monster)m.Clone();
            Monster m2 = (Monster)m.Clone();

            Console.WriteLine(m.Skill.Name);
            Console.WriteLine(m2.Skill.Name);

            m2.Skill.Name = "闪电";
            Console.WriteLine(m.Skill.Name);
            Console.WriteLine(m2.Skill.Name);
        }
    }
}