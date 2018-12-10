using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    public class EnumEx
    {

        public int flag = 0;
        //枚举练习，定义从星期天到星期六的枚举，从控制台接受字符串数字输入，然后输出星期

        public enum Weekends
        {
            Sunday =1,
            Monday =2,
            Tuesday =3,
            Wendesday=4,
            Thursday=5,
            Friday =6,
            Saturday =7
        }

        public void  GetCharDays()
        {
            Console.WriteLine("开始枚举练习程序！");
            flag += 1;           
            CG: Console.WriteLine("请输入星期：");
            string keyInput= Console.ReadLine();
            int keyInt = Convert.ToInt32(keyInput);

            switch (keyInt)
            {
                case (int)Weekends.Sunday:
                    Console.WriteLine(Weekends.Sunday.ToString());
                    break;
                case (int)Weekends.Monday:
                    Console.WriteLine(Weekends.Monday.ToString());
                    break;
                case (int)Weekends.Tuesday:
                    Console.WriteLine(Weekends.Tuesday.ToString());
                    break;
                case (int)Weekends.Wendesday:
                    Console.WriteLine(Weekends.Wendesday.ToString());
                    break;
                case (int)Weekends.Thursday:
                    Console.WriteLine(Weekends.Thursday.ToString());
                    break;
                case (int)Weekends.Friday:
                    Console.WriteLine(Weekends.Friday.ToString());
                    break;
                case (int)Weekends.Saturday:
                    Console.WriteLine(Weekends.Saturday.ToString());
                    break;
                default: Console.WriteLine("NotCorrectWeekends!");
                    break;
            }
            Console.WriteLine("是否继续？是请按Y，否请按N");
            string s = Console.ReadLine();
            if (s.Equals("Y")) {
                goto CG; }
            else { Console.WriteLine("Final!"); }
        }
    }
}
