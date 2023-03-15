namespace Lesson13_练习
{
    class Monster
    {

    }
    class Boss : Monster
    {
        public void Skill(int i)
        {
            Console.WriteLine("Boss[{0}]释放技能", i);
        }
    }
    class Goblin : Monster
    {
        public void Atk()
        {
            Console.WriteLine("小怪攻击");
        }
    }
    /// <summary>
    /// 武器枚举
    /// </summary>
    enum E_Weapon
    {
        /// <summary>
        /// 冲锋枪
        /// </summary>
        SMG,
        /// <summary>
        /// 散弹枪
        /// </summary>
        Shotgun,
        /// <summary>
        /// 手枪
        /// </summary>
        Pistol,
        /// <summary>
        /// 匕首
        /// </summary>
        Dagger,
    }

    //实现一
    class Player
    {
        private E_Weapon weapon = E_Weapon.Dagger;

        public E_Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public void PickUpWeapon(int a)
        {
            //Weapon = (E_Weapon)((new Random()).Next(0, 4));
            switch ((E_Weapon)a)
            {
                case E_Weapon.SMG:
                    Console.Write("玩家拾得武器冲锋枪");
                    break;
                case E_Weapon.Shotgun:
                    Console.Write("玩家拾得武器散弹枪");
                    break;
                case E_Weapon.Pistol:
                    Console.Write("玩家拾得武器手枪");
                    break;
                case E_Weapon.Dagger:
                    Console.Write("玩家拾得武器匕首");
                    break;
            }
        }
    }
    //实现二
    class Player1
    {
        public E_Weapon[] weapons = new E_Weapon[5];
        public int capacity = 5;
        public int length = 0;
        private int nowWeapon = 3;

        public void PickUpWeapon()
        {
            E_Weapon pickWeapon = (E_Weapon)((new Random()).Next(0, 4));
            if (length <= capacity - 1)
            {
                weapons[length] = pickWeapon;
                //switch ((E_Weapon)weapons[length])
                //{
                //    case E_Weapon.SMG:
                //        Console.WriteLine("玩家拾得武器冲锋枪");
                //        break;
                //    case E_Weapon.Shotgun:
                //        Console.WriteLine("玩家拾得武器散弹枪");
                //        break;
                //    case E_Weapon.Pistol:
                //        Console.WriteLine("玩家拾得武器手枪");
                //        break;
                //    case E_Weapon.Dagger:
                //        Console.WriteLine("玩家拾得武器匕首");
                //        break;
                //}
                ++length;
            }
            else
            {
                Console.WriteLine("武器库已经满了，自动扩容了");
                //自动扩展武器库
                capacity = capacity * 2;
                E_Weapon[] weapons1 = new E_Weapon[capacity];
                for (int i = 0; i < length; i++)
                {
                    weapons1[i]= weapons[i];
                }
                weapons1[length] = pickWeapon;
                weapons = weapons1;
                ++length;
            }
            switch ((E_Weapon)weapons[length-1])
            {
                case E_Weapon.SMG:
                    Console.WriteLine("玩家拾得武器冲锋枪");
                    break;
                case E_Weapon.Shotgun:
                    Console.WriteLine("玩家拾得武器散弹枪");
                    break;
                case E_Weapon.Pistol:
                    Console.WriteLine("玩家拾得武器手枪");
                    break;
                case E_Weapon.Dagger:
                    Console.WriteLine("玩家拾得武器匕首");
                    break;
            }
        }
        public void ChangeWeapon()
        {
            Console.WriteLine("你现在拥有{0}把武器", length);

            for (int i = 0; i < length; i++)
            {
                switch ((E_Weapon)weapons[i])
                {
                    case E_Weapon.SMG:
                        Console.WriteLine("{0}-冲锋枪", i);
                        break;
                    case E_Weapon.Shotgun:
                        Console.WriteLine("{0}-散弹枪", i);
                        break;
                    case E_Weapon.Pistol:
                        Console.WriteLine("{0}-手枪", i);
                        break;
                    case E_Weapon.Dagger:
                        Console.WriteLine("{0}-匕首", i);
                        break;
                }
            }
            Console.WriteLine("你的默认武器是匕首");
            Console.WriteLine("请输入对应的数字，切换武器：");
            nowWeapon = Convert.ToInt32(Console.ReadLine());
            switch ((E_Weapon)weapons[nowWeapon])
            {
                case E_Weapon.SMG:
                    Console.WriteLine("你现在的武器是：冲锋枪");
                    break;
                case E_Weapon.Shotgun:
                    Console.WriteLine("你现在的武器是：散弹枪");
                    break;
                case E_Weapon.Pistol:
                    Console.WriteLine("你现在的武器是：手枪");
                    break;
                case E_Weapon.Dagger:
                    Console.WriteLine("你现在的武器是：匕首");
                    break;
            }   
        }

    }
    //class WeaponOfPlayer1 : Player1
    //{
    //    public E_Weapon nowWeapon = E_Weapon.Dagger;
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //练习三
            //方式一
            //Player player = new Player();
            //player.PickUpWeapon(1);
            //方式二
            Player1 player1 = new Player1();
            while (true)
            {
                player1.PickUpWeapon();

                player1.ChangeWeapon();
            }


            //练习二
            //Monster[] monsters = new Monster[10];
            //for (int i = 0; i < monsters.Length; i++)
            //{
            //    if ((new Random()).Next(0, 2) == 1)
            //    {
            //        monsters[i] = new Boss();
            //    }
            //    else
            //    {
            //        monsters[i] = new Goblin();
            //    }
            //    Console.WriteLine("mosters[{0}]是{1}", i, monsters[i]);
            //}

            //for (int i = 0; i < monsters.Length; i++)
            //{
            //    if (monsters[i] is Boss)
            //    {
            //        (monsters[i] as Boss).Skill(i);
            //    }
            //}

            //练习一：is和as区别
            //is是判断，as是转换
        }
    }
}