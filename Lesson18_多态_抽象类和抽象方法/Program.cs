namespace Lesson18_多态_抽象类和抽象方法
{
    //练习二
    abstract class Graph
    {
        public abstract void Area();
        public abstract void Perimeter();
    }
    class Rect : Graph
    {
        float x, y;
        public Rect(float x, float y)
        {
            this.x = x;
            this.y = y;
        }   
        public override void Area()
        {
            Console.WriteLine(x * y);
        }
        public override void Perimeter()
        {
            Console.WriteLine(2 * (x + y));
        }
    }
    class Square : Graph
    {
        float l;
        public Square(float l)
        {
            this.l = l;
        }
        public override void Area()
        {
            Console.WriteLine(l * l);
        }
        public override void Perimeter()
        {
            Console.WriteLine(4 * l);
        }
    }
    class Circle : Graph
    {
        float r;
        public Circle(float r)
        {
            this.r = r;
        }
        public override void Area()
        {
            Console.WriteLine(3.14f * r * r);
        }
        public override void Perimeter()
        {
            Console.WriteLine(2 * 3.14f * r);
        }
    }

    //练习一
    abstract class Animal
    {
        public abstract void Speak();
    }
    class Human : Animal
    {
        public override void Speak() { }
    }
    class Dog : Animal
    {
        public override void Speak() { }
    }
    class Cat : Animal
    {
        public override void Speak() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Rect r1 = new Rect(2, 3);
            r1.Area();
            r1.Perimeter();
            Square s1 = new Square(10);
            s1.Area();
            s1.Perimeter();
            Circle c1 = new Circle(10);
            c1.Area();
            c1.Perimeter();

        }
    }
}