namespace Lesson13_继承_里式替换原则
{
    class GameObject
    {

    }

    class Player : GameObject
    {
        public void Atk()
        {
            Console.WriteLine("P");
        }
    }
    class Monster : GameObject
    {
        public void Atk()
        {
            Console.WriteLine("M");
        }
    }
    class Boss : GameObject
    {
        public void Atk()
        {
            Console.WriteLine("B");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            GameObject player = new Player();
            GameObject monster = new Monster();
            GameObject boss = new Boss();
            GameObject[] gameObjects = { player, player, monster, boss };

            //if (player is Player)
            //{
            //    //GameObject p = player as Player;这句是错误的
            //    Player p = player as Player;
            //    p.Atk();
            //}
            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (gameObjects[i] is Player)
                {
                    (gameObjects[i] as Player).Atk();
                }
                else if (gameObjects[i] is Monster)
                {
                    (gameObjects[i] as Monster).Atk();
                }
                else
                {
                    (gameObjects[i] as Boss).Atk();
                }
            }

        }
    }
}