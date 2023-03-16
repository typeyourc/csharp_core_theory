namespace Lesson17_多态_vob
{
    
    //练习三
    class Shape
    {
        public virtual void Area()
        {

        }
        public virtual void Perimeter()
        {

        }
    }
    class Rectangle : Shape
    {
        float x;
        float y;
        public Rectangle(float x, float y)
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
    class Square : Shape
    {
        float x;
        public Square(float x)
        {
            this.x = x;
        }
        public override void Area()
        {
            Console.WriteLine(x * x);
        }
        public override void Perimeter()
        {
            Console.WriteLine(2 * (x + x));
        }
    }
    class Circle : Shape 
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


    //练习二
    class Employee
    {
        public virtual void ClockIn()
        {
            Console.WriteLine("9点打卡");
        }
    }
    class Manager : Employee
    {
        public override void ClockIn()
        {
            //base.ClockIn();
            Console.WriteLine("11点打卡");
        }
    }
    class Programmer : Employee
    {
    
    }

    //练习一
    class Duck
    {
        public virtual void Speak()
        {

        }
    }
    class RealDuck : Duck
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("嘎嘎");
        }
    }
    class WoodDuck : Duck
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("吱吱");
        }
    }
    class RubberDuck : Duck
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("唧唧");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多态-vob");
            //练习三
            Shape r3 = new Rectangle(3, 4);
            r3.Area();
            r3.Perimeter();
            Shape s = new Square(3);
            s.Area();
            s.Perimeter();
            Shape c = new Circle(3);
            c.Area();
            c.Perimeter();

            //练习二
            Employee e = new Employee();
            e.ClockIn();
            Employee m = new Manager();
            m.ClockIn();
            Employee p = new Programmer();

            //练习一
            Duck r = new RealDuck();
            r.Speak();
            Duck w = new WoodDuck();
            w.Speak();
            Duck rr = new RubberDuck();
            rr.Speak();

            
        }
    }
}