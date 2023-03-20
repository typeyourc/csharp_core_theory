namespace Lesson23_面向对象相关_String
{
    internal class Program
    {   
        static public void FanZhuan(string str)
        {
            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
                str = string.Format(str[i].ToString(), str);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //练习五：
            string str = "hello";
            FanZhuan(str);

            //练习四：
            //string str = null:
            //str = "123";
            //string str2 = str;
            //str2 = "321";
            //str2 += "123";
            //上面这段c#代码，分配了多少个新的堆空间

            //练习三：一个时类名，一个是变量类型名，别名，使用基本一样


            //练习二：请将字符串1|2|3|4|5|6|7变为2|3|4|5|6|7|8，并输出(使用字符串切割的方法)
            //string str = "1|2|3|4|5|6|7";
            //string[] strArray = str.Split('|');
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    strArray[i] =(int.Parse(strArray[i]) + 1).ToString();
            //}
            //string str1 = "";

            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (i < strArray.Length - 1)
            //    {
            //        str1 = string.Format("{0}{1}{2}", str1, strArray[i], "|");
            //    }
            //    else
            //    {
            //        str1 = string.Format("{0}{1}", str1, strArray[i]);
            //    }
            //}
            //Console.WriteLine(str1);

            //练习一：截取 替换 
            //string str = "Hello, World!", str1, str2, str3;
            //str1 = str.Substring(1);
            //str2 = str.Substring(0,2);
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);

            //str3 = str.Replace("Hello", "Hi");
            //Console.WriteLine(str3);
        }
    }
}