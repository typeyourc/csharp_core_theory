using System;

namespace Lesson5_封装_成员属性
{
    /// <summary>
    /// 性别枚举
    /// </summary>
    enum E_Sex
    {
        /// <summary>
        /// 男
        /// </summary>
        Male,
        /// <summary>
        /// 女
        /// </summary>
        Female,
    }
    /// <summary>
    /// 学生类
    /// </summary>
    class Student
    {
        //成员变量
        public string name;
        private E_Sex sex;
        private int age;
        private float scoreOfCsharp;
        private float scoreOfUnity;
        //打招呼成员方法
        public void SayHello()
        {
            Console.WriteLine("我的名字叫{0}，今年{1}岁了，性别是{2}", name, age, sex);
            Console.WriteLine("总分数为{0}，平均分为{1}", (scoreOfCsharp + scoreOfUnity) * 1.0f, (scoreOfCsharp + scoreOfUnity) / 2.0f);
        }
        //年龄成员属性
        public int Age
        {
            get
            {            
                return age; 
            }
            set
            {
                if (value > 0 && value < 150)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("学生的年龄不对，超出了0~150之间这个范围，请重新给年龄赋值");
                    Environment.Exit(0);
                }               
            }
        }
        //Csharp成绩成员属性
        public float ScoreOfCsharp
        {
            get
            {
                return scoreOfCsharp;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    scoreOfCsharp = value;
                }
                else
                {
                    Console.WriteLine("学生的Csharp成绩不对，超出了0~100之间(包含边界)这个范围，请重新给Csharp成绩赋值");
                    Environment.Exit (0);
                }

            }
        }
        //Unity成绩成员属性
        public float ScoreOfUnity
        {
            get
            {
                return scoreOfUnity;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    scoreOfUnity = value;
                }
                else
                {
                    Console.WriteLine("学生的Unity成绩不对，超出了0~100之间(包含边界)这个范围，请重新给Unity成绩赋值");
                    Environment.Exit(0);
                }

            }
        }
        //性别成员属性
        public E_Sex Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value == E_Sex.Male || value == E_Sex.Female)
                {
                    sex = value;
                }
                else
                {
                    Console.WriteLine("学生的性别不对，请重新给性别赋值(0男/1女)");
                    Environment.Exit(0);
                }
               
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student stu = new Student();
            stu.name = "李白";
            stu.Age = 50;
            stu.Sex = (E_Sex)0;
            stu.ScoreOfCsharp = 100;
            stu.ScoreOfUnity = 30;
            stu.SayHello();

            Student stu1 = new Student();
            stu.name = "白居易";
            stu.Age = 70;
            stu.Sex = (E_Sex)0;
            stu.ScoreOfCsharp = 100;
            stu.ScoreOfUnity = 30;
            stu.SayHello();


        }
    }
}