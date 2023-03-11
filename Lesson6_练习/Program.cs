using System;

namespace Lesson6_练习
{
    class IntArray
    {
        //成员变量
        private int[] ints;
        //成员属性
        public int[] Ints
        {
            get { return ints; }
            set { ints = value; }
        }   

        //构造函数
        public IntArray(int[] ints)
        {
            this.ints = ints;
        }

        //索引器
        //查&改
        public int this[int index]
        {
            get
            {
                return ints[index];
            }
            set
            {
                ints[index] = value;
            }
        }
        //增
        public int[] this[int[] array]
        {
            get
            {
                int[] ints1 = new int[ints.Length + array.Length];
                for (int i = 0, j = 0; i < ints1.Length; i++)
                {
                    if (i < ints.Length)
                    {
                        ints1[i] = ints[i];
                    }
                    else
                    {
                        ints1[i] = array[j];
                        ++j;
                    }
                }
                ints = ints1;
                return ints;

            }
        }
        //删
        public int[] this[int index, bool a]
        {
            get
            {
                int[] ints1 = new int[ints.Length - 1];
                if (index < ints.Length)
                {
                    for (int i = 0, j = 0; i < ints.Length; i++)
                    {
                        if (i != index)
                        {
                            ints1[j] = ints[i];
                            ++j;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("{0}不在原有数组的索引范围内", index);
                    return null;
                }
                ints = ints1;
                return ints;
            }
        }

        #region MyRegion
        //查-成员方法
        public void Get(int index)
        {
            if (index < ints.Length)
            {
                Console.WriteLine(ints[index]);
            }
            else
            {
                Console.WriteLine("{0}超出索引范围", index);
            }
        }
        //改-成员方法
        public int Change(int index, int num)
        {
            if (index < ints.Length)
            {
                int temp = ints[index];
                ints[index] = num;
                Console.WriteLine("修改成功，数组第{0}个元素的值由{1}修改为{2}", index, temp, ints[index]);
            }
            else
            {
                Console.WriteLine("{0}超出索引范围", index);
                return 0;
            }
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            return 0;
        }
        //增-成员方法（先实现增加在原有数组最后面位置的方法）
        public void Add(params int[] array)
        {
            int[] ints1 = new int[ints.Length + array.Length];
            for (int i = 0, j = 0; i < ints1.Length; i++)
            {
                if (i < ints.Length)
                {
                    ints1[i] = ints[i];
                }
                else
                {   
                    ints1[i] = array[j];
                    ++j;
                }
            }
            ints = ints1;
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
        //删-成员方法
        public int Delete(int index)
        {
            int[] ints1 = new int[ints.Length - 1];
            if(index < ints.Length)
            {
                for (int i = 0, j = 0; i < ints.Length; i++)
                {
                    if (i != index)
                    {
                        ints1[j] = ints[i];
                        ++j;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("{0}不在原有数组的索引范围内", index);
                return 0;
            }
            ints = ints1;
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            return 0;
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 没用索引器实现
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            //IntArray array = new IntArray(arr);

            ////array.Add(new int[] { 1, 2 });
            ////array.Delete(10);
            ////array.Change(1, 99);
            //array.Get(1);
            #endregion

            #region 用索引器实现
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            IntArray array = new IntArray(arr);

            //查-----------------------------------------
            //Console.WriteLine(array[0]);

            //改-----------------------------------------
            //arr[0] = 99;
            //Console.WriteLine(array[0]);

            //增-----------------------------------------
            //用于增加的数组
            //int[] array1 = new int[] { 11, 22, 33, 44 };

            ////注意：for的条件里，不能写成i < array[array1].Length，这样每次调用都会执行索引，形成无限循环了
            //int[] array2 = array[array1];
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.WriteLine(array[array1][i]);
            //    //Console.WriteLine(array2[i]);
            //}

            //错误写法如下
            //for (int i = 0; i < array[array1].Length; i++)
            //{
            //    Console.WriteLine(array[array1][i]);
            //}

            //删
            int[] array3 = array[5, true];
            if (array3 != null)
            {
                for (int i = 0; i < array3.Length; i++)
                {
                    Console.WriteLine(array3[i]);
                }
            }

 

            #endregion
        }
    }
}