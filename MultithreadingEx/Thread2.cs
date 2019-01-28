using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Threading.Thread;

namespace MultithreadingEx
{
     
    public class Thread2
    {
        public static DateTime dt = System.DateTime.Now.Date;

        /// <summary>
        /// 打印99乘法表
        /// </summary>
        public static void PrintMultiplicationTable()
        {
            Sleep(TimeSpan.FromSeconds(3));   //3秒之后再运行方法
            Console.WriteLine();
            Console.WriteLine("Print is Starting!");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Sleep(TimeSpan.FromSeconds(1)); //每隔一秒钟再打印
                    Console.Write(i + " X " + j + " = " + i * j + "  ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 打印当前系统时间
        /// </summary>
        public static void PrintCurrentSystemTime()
        {
            string year = dt.Year + "";
            string month = dt.Month + "";
            string day = dt.Day + "";

            string time = System.DateTime.Now.TimeOfDay.ToString();
            Console.Write("当前时间为 " + year + " 年 " + month + " 月 " + day + " 日  " + time);
            
        }
    }
}
