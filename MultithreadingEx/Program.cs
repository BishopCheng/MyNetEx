using System;
using System.Threading;  //启用线程
using static System.Console;

namespace MultithreadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  线程暂停练习

            //开启线程
            //由于在printMultiplicationTablez中加入了Sleep，所以尽管先开启的是printMultiplication方法，但PrintCurrentSystemTime
            //方法仍将率先执行
            //Thread thread = new Thread(Thread1.PrintMultiplicationTable);
            //thread.Start();
            //Thread1.PrintCurrentSystemTime();
            //Console.ReadKey();

            #endregion

            #region  线程等待练习
            //Thread thread = new Thread(Thread2.PrintMultiplicationTable);
            //thread.Start();
            //thread.Join(); //让Thread2.PrintCurrentSystemTime 等待thread中的任务完成
            //Thread2.PrintCurrentSystemTime();
            //Console.ReadKey();
            #endregion

            #region 线程中止练习(不支持)
            //WriteLine("Starting...");
            //Thread t = new Thread(Thread3.PrintMultiplicationTable);
            //t.Start();
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            //t.Abort();//中断线程
            //WriteLine("A Thread has been Abort!");
            //t = new Thread(Thread3.PrintCurrentSystemTime);
            //t.Start();
            #endregion
        }
    }
}
