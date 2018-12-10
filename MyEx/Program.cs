using System;

namespace MyEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            #region 循环练习
            //LoopEx loopEx = new LoopEx();
            //loopEx.GetLoopWrite();
            #endregion

            #region 枚举练习
            EnumEx enumEx = new EnumEx();
            enumEx.GetCharDays();
            #endregion
        }
    }
}
