namespace Lesson16_继承_密封类
{

    ////这个练习没有做出来

    class Car
    {
        public float speed;
        public float maxSpeed;
        public int totalPeople;
        public People[] peoples;
        public int capacity;

        public Car(int totalPeople, People[] peoples)
        {
            speed = 1.0f;
            maxSpeed = 8.0f;
            this.totalPeople = totalPeople;
            this.peoples = peoples;
            capacity = 20;
        }

        public void Drive()
        {

        }
        public void Accident()
        {

        }

    }
    class People : Car
    {
        public People(totalPeople,)
        public void GoOnCar(People p)
        {
            peoples[totalPeople] = p;
            if (totalPeople <= 29)
            {
                ++totalPeople;
                Console.WriteLine("车上现在{0}人", totalPeople);
            }
            else
            {
                Console.WriteLine("已经满员");
            }
        }
        public void LeaverCar(People p)
        {
            peoples[totalPeople] = null;
            if (totalPeople >= 1)
            {
                --totalPeople;
                Console.WriteLine("车上现在{0}人", totalPeople);
            }
            else 
            {
                Console.WriteLine("车上已经没人");
            }
        }
    }
    class Drivers : People
    {

    }
    class Passengers : People
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ///这个练习没有做出来
            Car car = new Car();
            People p1 = new People();
            p1.GoOnCar(p1);

        }
    }
}