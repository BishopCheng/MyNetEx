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

            #region 扩展方法练习
            //Console.WriteLine("开始扩展方法的练习！");
            //string s = "ABCDE";
            //int c= s.GetCount();
            //Console.WriteLine(c);
            //Console.ReadKey();
            #endregion

            #region 虚函数练习
            //virtualEx virtualEx = new virtualEx();
            //virtualEx.Cal CA = new virtualEx.CalPerimete();
            //CA.Calculate(1, 2, 7);
            //Console.ReadKey();
            #endregion

            #region 抽象类练习   
            //AbstractEx ABEx = new AbstractEx();
            //ABEx.GetInfomation();

            #endregion

            #region 接口继承练习
            InterfaceEx Ie = new InterfaceEx();
            Ie.GetMixed();
            #endregion
        }
    }
}
