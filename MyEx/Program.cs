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
            //EnumEx enumEx = new EnumEx();
            //enumEx.GetCharDays();
            #endregion

            #region 重载练习
            //OverLoad ov = new OverLoad();
            //ov.PrintMember();
            #endregion

            #region 构造函数练习
            //Constructed.Vehicle vehicle = new Constructed.Vehicle("阳光牌");
            //Constructed.Vehicle vehicle2 = new Constructed.Vehicle("保时捷牌", 4);
            #endregion

            #region 匿名内部类练习
            Anonymous anonymous = new Anonymous();
            anonymous.Say();
            #endregion
        }
    }
}
