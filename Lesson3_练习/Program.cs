using System;

namespace Lesson3_练习
{
    //课程枚举
    enum E_Course
    {
        Math,
        English,
        Chinese,
        Physics
    }
    //物品枚举
    enum E_Thing
    {
        Apple,
        Banana,
        Orange,
        Watermelon
    }
    
    //食物类
    class Food
    {
        public E_Thing nameOfFood;
        public float calories;
    }
    //人类
    class Person
    {
        public string name;
        public int age;
        public float height;
        public float weight;

        //成员函数-说话
        public void Speak(string str)
        {
            Console.WriteLine("{0}说：“{1}”", name, str);
        }
        //成员函数-走路
        public void Walk(int num)
        {
            Console.WriteLine("{0}走了{1}步", name, num);
        }
        //成员函数-吃饭
        public void Eat(string str)
        {
            Console.WriteLine("{0}吃了{1}", name, str);
        }

    }
    //学生类
    class Student
    {
        public Person stu;

        //学习
        public void Learn(E_Course course)
        {
            switch (course)
            {
                case E_Course.Math:
                    Console.WriteLine("{0}学习了数学", stu.name);
                    break;
                case E_Course.English:
                    Console.WriteLine("{0}学习了英语", stu.name);
                    break;
                case E_Course.Chinese:
                    Console.WriteLine("{0}学习了语文", stu.name);
                    break;
                case E_Course.Physics:
                    Console.WriteLine("{0}学习了物理", stu.name);
                    break;
            }
        }
        //吃饭
        //public void Eat(E_Thing food)//用枚举表示食物
        //{
        //    switch (food)
        //    {
        //        case E_Thing.Apple:
        //            Console.WriteLine("{0}吃了苹果", stu.name);
        //            break;
        //        case E_Thing.Banana:
        //            Console.WriteLine("{0}吃了香蕉", stu.name);
        //            break;
        //        case E_Thing.Orange:
        //            Console.WriteLine("{0}吃了桔子", stu.name);
        //            break;
        //        case E_Thing.Watermelon:
        //            Console.WriteLine("{0}吃了西瓜", stu.name);
        //            break;
        //    }
        //}
        public void Eat(Food food)//用类表示食物
        {
            switch (food.nameOfFood)
            {
                case E_Thing.Apple:
                    Console.WriteLine("{0}吃了苹果，{1}卡路里", stu.name,food.calories);
                    break;
                case E_Thing.Banana:
                    Console.WriteLine("{0}吃了香蕉，{1}卡路里", stu.name, food.calories);
                    break;
                case E_Thing.Orange:
                    Console.WriteLine("{0}吃了桔子，{1}卡路里", stu.name, food.calories);
                    break;
                case E_Thing.Watermelon:
                    Console.WriteLine("{0}吃了西瓜，{1}卡路里", stu.name, food.calories);
                    break;
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //练习一
            //Person p1 = new Person();
            //p1.name = "王大锤";
            //p1.Speak("我是王大锤");
            //p1.Walk(10);
            //p1.Eat("汉堡包");

            //练习二
            Person p1 = new Person();
            p1.name = "巴斯光年";
           
            Student stu1 = new Student();
            stu1.stu = p1;

            //-学课程
            E_Course e_Course;
            e_Course = E_Course.Math;
            stu1.Learn(e_Course);
            //-吃东西
            //E_Thing thing = new E_Thing();
            //thing = E_Thing.Apple;
            //stu1.Eat(thing);
            Food food = new Food();
            food.nameOfFood = E_Thing.Apple;
            food.calories = 123.4f;
            stu1.Eat(food);



        }
    }
}